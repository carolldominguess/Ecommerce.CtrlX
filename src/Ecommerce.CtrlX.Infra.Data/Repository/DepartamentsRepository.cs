using System.Collections.Generic;
using Dapper;
using Ecommerce.CtrlX.Domain.Entities;
using Ecommerce.CtrlX.Domain.Interfaces.Repository;
using Ecommerce.CtrlX.Infra.Data.Context;

namespace Ecommerce.CtrlX.Infra.Data.Repository
{
    public class DepartamentsRepository : Repository<Departaments>, IDepartamentsRepository
    {
        public DepartamentsRepository(CtrlXContext context) : base(context)
        {
        }

        public Departaments GetDepartamentsById(int id)
        {
            return SearchFirstOrDefault(x => x.DepartamentsId == id && x.Ativo == true);
        }

        public IEnumerable<Departaments> ObterAtivos(int id)
        {
            return Search(x => x.Ativo);
        }

        public override void Remove(int id)
        {
            var dep = GetDepartamentsById(id);
            dep.Ativo = false;
            Update(dep);
        }

        public override IEnumerable<Departaments> GetAll()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM CtrlX_Departaments";
            return cn.Query<Departaments>(sql);
        }
    }
}
