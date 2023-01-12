using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class DeliveryService<TProducts> : Delivery<TProducts>
    {
        string companyName;
        public DeliveryService(string address, string companyName, TProducts products) : base(address, products)
        { 
            this.companyName = companyName;
        }
        
    }
}
