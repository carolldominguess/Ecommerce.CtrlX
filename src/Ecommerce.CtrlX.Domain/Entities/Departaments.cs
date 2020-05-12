using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Departaments
    {
        public int DepartamentsId { get; set; }
        public string Name { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
