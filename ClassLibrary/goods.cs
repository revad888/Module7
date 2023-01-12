using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract class goods
    {
        public string description;
        public double weight;
        public string dimensions;
        public virtual double GetWeight
        {
            get
            {
                return weight;
            }
        }
        public virtual string Description
        {
            get
            {
                return description;
            }
        }
    }
}
