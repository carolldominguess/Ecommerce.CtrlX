using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class ProductsViewModel
    {
        [Key]
        public int ProductsId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "O limite máximo é de 150 caracteres")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(10, ErrorMessage = "O limite máximo é de 10 caracteres")]
        public string Price { get; set; }
        public byte[] Image { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase ImageUpload { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(300, ErrorMessage = "O limite máximo é de 300 caracteres")]
        public string Remarks { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriesId { get; set; }
        public string NameCategory { get; set; }
    }
}
