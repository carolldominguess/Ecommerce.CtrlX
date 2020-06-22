using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class OrdersNewViewModel
    {
        [Key]
        public int OrdersNewId { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Data")]
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Remarks { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "O limite máximo é de 150 caracteres")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string ValorTotal { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string NumeroCartao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string DtValidadeCartao { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int? CodSeguranca { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CPFCliente { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]        
        public string Endereco { get; set; }
        public byte[] Image { get; set; }
        public int ProducstId { get; set; }
        public virtual ProductsViewModel Products { get; set; }
        public string User { get; set; }
    }
}
