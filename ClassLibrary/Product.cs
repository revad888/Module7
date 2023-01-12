using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Product : goods
    {
        private string description;


        public Product(string Description, double Weight, int lenght, int width, int height)
        {
            this.description = Description;
            this.weight = Weight;
            this.dimensions = $"{lenght}x{width}x{height}";
        }
        public Product(string Description, string Dimensions)
        {
            this.description = Description;
            this.dimensions = Dimensions;

        }
        public int Lenght
        {
            get
            {
                return Convert.ToInt32(dimensions.Split("x")[0]);
            }
        }
        public int Width
        {
            get
            {
                return Convert.ToInt32(dimensions.Split("x")[1]);
            }
        }
        public int Height
        {
            get
            {
                return Convert.ToInt32(dimensions.Split("x")[3]);
            }
        }


    }
}
