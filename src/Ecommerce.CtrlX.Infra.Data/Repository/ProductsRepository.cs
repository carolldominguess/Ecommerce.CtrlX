using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class ProductsRepository : Repository<Products>, IProductsRepository
    {
        public ProductsRepository(CtrlXContext context) : base(context)
        {
        }

        public Products GetProductsById(int id)
        {
            return SearchFirstOrDefault(x => x.ProductsId == id && x.Ativo == true);
        }

        public async Task<Products> GetProdutosByIdAsync(int id)
        {
            var cn = Db.Database.Connection;
            var sql = "SELECT ProductsId, * FROM CtrlX_Products WHERE ProductsId = @id AND Ativo = 1";

            var result = await cn.QueryFirstOrDefaultAsync<Products>(sql, new { id });
            return result;
        }
        public IEnumerable<Products> ObterAtivos(int id)
        {
            return Search(x => x.Ativo);
        }

        public override void Remove(int id)
        {
            var prod = GetProductsById(id);
            prod.Ativo = false;
            Update(prod);
        }

        public override IEnumerable<Products> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Products";
            return cn.Query<Products>(sql);
        }
    }
}
