using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Categories
    {
        public int CategoriesId { get; set; }
        public string DescriptionCategory { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
