using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class ProductsViewModel
    {
        [Key]
        public int ProductsId { get; set; }
        public string Description { get; set; }
        public int? BarCode { get; set; }
        public float? Price { get; set; }
        public byte? Image { get; set; }
        public byte? Remarks { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriesId { get; set; }
    }
}
