using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Taxes
    {
        public int TaxesId { get; set; }
        public string DescriptionTax { get; set; }
        public float Rate { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
