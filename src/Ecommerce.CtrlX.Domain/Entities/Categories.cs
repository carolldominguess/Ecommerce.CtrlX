using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Categories
    {
        public int CategoriesId { get; set; }
        public string DescriptionCategory { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
