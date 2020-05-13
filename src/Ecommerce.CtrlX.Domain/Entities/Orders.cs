using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Orders
    {
        public int OrderId { get; set; }
        public DateTime? Date { get; set; }
        public byte? Remarks { get; set; }
        //public int CustomerId { get; set; }
    }
}
