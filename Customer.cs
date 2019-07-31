using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Customer //: IUser, IProfile
    {
        //member variables
        ShoppingCart cart;
        //ctor
        public Customer()
        {
            cart = new ShoppingCart();
        }
        //member methods

        public void Register(string emailAddress, string password, IEmailService emailService)
        {
            emailService.SendEmail(emailAddress, "Confirm registration");
        }

        public void CreateProfile()
        {

        }

    }
}
