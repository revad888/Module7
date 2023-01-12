using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class PickPointDelivery<TProducts> : Delivery<TProducts>
    {

        PickPoint pickPoint;

        public PickPointDelivery (string address, TProducts products) : base(address, products)
        {
            this.Address = address;
            this.Products = products;
            this.pickPoint = new PickPoint(address);
        }

    }
}
