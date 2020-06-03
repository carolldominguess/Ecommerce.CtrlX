using System;
using System.Collections.Generic;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public string Price { get; set; }
        //public byte[] Image { get; set; }
        public string Remarks { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
        public string NameCategory { get; set; }
    }
}
