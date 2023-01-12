using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   abstract class Delivery<TProducts>
    {
        public string Address;
        public TProducts Products;
        private DateTime date;
        public Delivery(string address, TProducts products)
        {
            Address = address;
            Products = products;
        }

        public DateTime Date { get => date; set => date = value; }
    }
}
