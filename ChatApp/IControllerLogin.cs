using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal interface IControllerLogin
    {

        void Login(string username, string password);

        void Login(int phonenumber, string password);
        void Login(MailAddress email, string password);

        void Register(string username, string password);
        void Register(int phonenumber, string password);
        void Register(MailAddress emailadress,string password);


        IViewLogin ViewLogin { set; }
        IModelLogin ModelLogin { set; }
        
    }
}
