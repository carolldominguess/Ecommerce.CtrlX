﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class ProductsViewModel
    {
        [Key]
        public int ProductsId { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(30, ErrorMessage ="O limite máximo é de 20 numeros")]
        public string BarCode { get; set; }
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
