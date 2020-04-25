using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Companies
    {
        public int CompaniesId { get; set; }
        public string NameCompany { get; set; }
        public string PhoneCompany { get; set; }
        public string AddressCompany { get; set; }
        public string Logo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int DepartamentsId { get; set; }
        public virtual Departaments Departaments { get; set; }
        public int CitiesId { get; set; }
        public virtual Cities Cities { get; set; }  
    }
}
