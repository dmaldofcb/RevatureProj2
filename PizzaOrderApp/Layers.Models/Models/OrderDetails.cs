using System;
using System.Collections.Generic;
using System.Text;

namespace Layers.Models.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        public int OrderID { get; set; }
        public int PizzaID { get; set; }

        public int SizeID { get; set; }
        public decimal Total { get; set; }

    }
}
