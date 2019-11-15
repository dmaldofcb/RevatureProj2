using System;
using System.Collections.Generic;
using System.Text;

namespace Layers.Models.Models
{
    public class PizzaToppings
    {
        public int ID { get; set; }

        public int ToppingsID { get; set; }

        public int PizzaID { get; set; }
    }
}
