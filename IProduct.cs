using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    interface IProduct
    {
        //properties
        string Name { get; set; }
        double Price { get; set; }  
        string Category { get; set; }

        //method
        void DisplayDetails();
    }
}
