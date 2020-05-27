using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class ProductsViewModel
    {
        [Key]
        public int ProductsId { get; set; }
        public string Description { get; set; }
        [Range(0,999, ErrorMessage ="O limite máximo é de 3 caracteres")]
        public int? BarCode { get; set; }
        public float? Price { get; set; }
       // public byte[] Image { get; set; }
        //[Required]
        //[DataType(DataType.Upload)]
        //[Display(Name = "Imagem")]
        //public HttpPostedFileBase ImageUpload { get; set; }
        public string Remarks { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriesId { get; set; }
        public string NameCategory { get; set; }
    }
}
