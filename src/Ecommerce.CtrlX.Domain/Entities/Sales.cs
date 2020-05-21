using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Sales
    {
        public int SalesId { get; set; }
        public DateTime? Date { get; set; }
        public byte? Remarks { get; set; }
        public string Description { get; set; }
        public float? Price { get; set; }
        public byte? TaxRate { get; set; }
        public int? Quantity { get; set; }

        public int OrdersId { get; set; }
        public virtual Orders Orders { get; set; }

        public int ProducstId { get; set; }
        public virtual ICollection<Products> Products { get; set; }

        //public int CustomerId { get; set; }
    }
}
