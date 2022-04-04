using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(CtrlXContext context) : base(context)
        {
        }

        public Categories GetCategoriesById(int id)
        {
            return SearchFirstOrDefault(x => x.CategoriesId == id && x.Ativo);
        }

        public IEnumerable<Categories> ObterAtivos(int id)
        {
            return Search(x => x.Ativo);
        }

        public override void Remove(int id)
        {
            var cat = GetCategoriesById(id);
            cat.Ativo = false;
            Update(cat);
        }
        public override IEnumerable<Categories> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Categories WHERE Ativo = 1";
            return cn.Query<Categories>(sql);
        }

        public override Categories GetById(int id)
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Categories c " +
                      "LEFT JOIN CtrlX_Products p " +
                      "ON c.CategoriesId = p.CategoriesId " +
                      "WHERE c.CategoriesId = @sid";

            var cat = cn.Query<Categories, Products, Categories>(sql,
                (c, p) =>
                {
                    c.Products.Add(p);
                    return c;
                }, new { sid = id }, splitOn: "CategoriesId, ProductsId");

            return cat.FirstOrDefault();
        }
    }
}
