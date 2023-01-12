using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class PickPoint
    {
        public string Location;
        public static string MaxCellSize = "200x300x100";
        
        public PickPoint(string location)
        {
            this.Location = location;    
        }
    }
}
