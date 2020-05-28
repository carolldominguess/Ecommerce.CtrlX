﻿using System;
using System.Web;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Products
    {
        public int ProductsId { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public float? Price { get; set; }
        //public byte[] Image { get; set; }
        public string Remarks { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
        public string NameCategory { get; set; }
    }
}
