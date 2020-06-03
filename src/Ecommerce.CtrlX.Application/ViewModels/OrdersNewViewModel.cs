using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class OrdersNewViewModel
    {
        [Key]
        public int OrdersNewId { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public byte? TaxRate { get; set; }
        public int? Quantity { get; set; }
        public int ProducstId { get; set; }
        public virtual ProductsViewModel Products { get; set; }
    }
}
