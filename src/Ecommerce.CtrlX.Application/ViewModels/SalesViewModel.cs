using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Application.ViewModels
{
    public class SalesViewModel
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime? Date { get; set; }
        public byte? Remarks { get; set; }
        //public int OrderId { get; set; }
        //public int Customerid { get; set; }
    }
}
