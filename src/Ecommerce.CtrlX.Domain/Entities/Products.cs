using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int? BarCode { get; set; }
        public float? Price { get; set; }
        public byte? Image { get; set; }
        public byte? Remarks { get; set; }
        //public int CategoryId { get; set; }
    }
}
