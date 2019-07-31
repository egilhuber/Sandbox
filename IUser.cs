using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    interface IUser
    {
        void Register(string emailAddress, string emailMessage, IEmailService emailService);

        void Login(string emailAddress, string password);
        void Logout();
    }
}
