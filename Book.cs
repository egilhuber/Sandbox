using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Book : IReadable
    {
        public void GetRead()
        {
            Console.WriteLine("reading a book");
        }
    }
}
