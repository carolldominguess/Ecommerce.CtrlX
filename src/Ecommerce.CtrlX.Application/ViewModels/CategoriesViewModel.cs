using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class CategoriesViewModel
    {
        public CategoriesViewModel()
        {
            Products = new List<ProductsViewModel>();
        }
        [Key]
        public int CategoriesId { get; set; }
        public string DescriptionCategory { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public ICollection<ProductsViewModel> Products { get; set; }
    }
}
