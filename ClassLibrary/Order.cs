using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    
    class Order <TDelivery, TStruct> where TDelivery : Delivery<TStruct> where TStruct : goods
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;


        Customer customer;
        public Order(Customer SomeCustomer, TDelivery delivery)
        {
            this.customer = SomeCustomer;
        }

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }


 

    }

   
}
