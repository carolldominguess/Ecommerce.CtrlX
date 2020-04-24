using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Departments
    {
        public int DepartmentsId { get; set; }
        public string Name { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
