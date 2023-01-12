using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Products : goods
    {
        List<Product> products;
        List<string> Descriptions;

        public void Add(Product product) 
        { 
            products.Add(product);
            Descriptions.Add(product.Description);
        }

        public void Remove(Product product)
        {
            products.Remove(product);
            Descriptions.Remove(product.Description);
        }

        public override double GetWeight
        {
            get
            {
                double weight = 0;
                foreach (Product product in products)
                {
                    weight += product.GetWeight;
                }
                return weight;
            }
        }

        public Dictionary<string, int> GetDimensions
        {
            get
            {
                var dimensions = new Dictionary<string, int>()
                {
                    {"SumLenght",0},
                    {"SumWidth",0},
                    {"SumHeight",0},
                };
                foreach (Product product in products)
                {
                    dimensions["SumLenght"] += product.Lenght;
                    dimensions["SumWidth"] += product.Width;
                    dimensions["SumHeight"] += product.Height;
                }
                return dimensions;
                
            }
        }
        public override string Description
        {
            get
            {
                string description = string.Join(", ", Descriptions);
                return description;
            }
        }
    }

}
