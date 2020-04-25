using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Cities
    {
        public int CitiesId { get; set; }
        public string Name { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int DepartamentsId { get; set; }
        public virtual Departaments Departaments { get; set; }
    }
}
