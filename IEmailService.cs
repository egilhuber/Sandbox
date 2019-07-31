using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    interface IEmailService
    {
        void SendEmail(string emailAddress, string emailMessage);
    }
}
