using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class HomeDelivery<TProducts> : Delivery<TProducts>
    {
        private DateTime intervalStart;
        private DateTime intervalEnd;
        private List<Courier> deliveryTeam;

        public DateTime IntervalStart{ get => intervalStart; set => intervalStart = value; }
        public DateTime IntervalEnd { get => intervalEnd; set => intervalEnd = value; }

        public HomeDelivery(string address, TProducts products)  : base(address, products)
        {
            double weight = products.GetWeight;
            for (int i = 0; i < weight / 2; i++)
            {
                deliveryTeam.Add(new Courier($"Курьер {i}"));
            }
        }
        

       

        
    }
}
