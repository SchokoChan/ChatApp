using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal class ControllerLogin : IControllerLogin
    {
        private IModelLogin model;
        private IViewLogin view;

        void IControllerLogin.Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        void IControllerLogin.Login(int phonenumber, string password)
        {
            throw new NotImplementedException();
        }

        void IControllerLogin.Login(MailAddress email, string password)
        {
            throw new NotImplementedException();
        }

        void IControllerLogin.Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        void IControllerLogin.Register(int phonenumber, string password)
        {
            throw new NotImplementedException();
        }

        void IControllerLogin.Register(MailAddress emailadress, string password)
        {
            throw new NotImplementedException();
        }


        IViewLogin IControllerLogin.ViewLogin { set => view = value; }
        IModelLogin IControllerLogin.ModelLogin { set => model = value; }
    }
}
