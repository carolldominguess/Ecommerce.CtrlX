using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.CtrlX.Domain.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }

    }
}
