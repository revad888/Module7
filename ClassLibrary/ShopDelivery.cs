using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class ShopDelivery<TProducts> : Delivery<TProducts>
    {
        public ShopDelivery (string address, TProducts products) : base (address, products) 
        { 
            this.Products = products;
            this.Address = address;
        }
    }
}
