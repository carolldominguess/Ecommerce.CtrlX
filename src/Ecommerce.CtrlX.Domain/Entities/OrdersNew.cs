using System;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class OrdersNew
    {
        public int OrdersNewId { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public byte? TaxRate { get; set; }
        public int? Quantity { get; set; }

        public int ProducstId { get; set; }
        public virtual Products Products { get; set; }

        //public int CustomerId { get; set; }
    }
}
