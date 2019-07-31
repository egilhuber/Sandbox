using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Kindle : IReader
    {
        //member variables
        IReadable media;
        //ctor
        public Kindle(IReadable media)
        {
            this.media = media;
        }
        //member methods

        public void Read()
        {
            media.GetRead();
        }
    }
}
