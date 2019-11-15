using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaTut.Models
{
    public class Pizza
    {
        public int ID { get; set; }

        public string Type { get; set; }
        public int CrustID { get; set; }
        public int ToppingOneID { get; set; }

        public int ToppingTwoID { get; set; }

        public int ToppingThreeID { get; set; }
        public int ToppingFourID { get; set; }
        public int ToppingFiveID { get; set; }
        public int ToppingSixID { get; set; }


    }
}
