using System;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class CategoriesViewModel
    {
        public int CategoriesId { get; set; }
        public string DescriptionCategory { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
