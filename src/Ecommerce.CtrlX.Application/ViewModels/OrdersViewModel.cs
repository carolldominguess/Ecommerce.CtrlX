using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class OrdersViewModel
    {
        [Key]
        public int OrdersId { get; set; }
        public DateTime? Date { get; set; }
        public byte? Remarks { get; set; }
        public string Description { get; set; }
        public float? Price { get; set; }
        public byte? TaxRate { get; set; }
        public int? Quantity { get; set; }
    }
}
