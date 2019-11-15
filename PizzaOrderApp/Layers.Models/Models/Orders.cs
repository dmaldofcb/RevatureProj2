using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaTut.Models
{
    public class Orders
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
