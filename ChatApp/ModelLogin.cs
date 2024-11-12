using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal class ModelLogin : IModelLogin
    {
        private IViewLogin view;
        private IControllerLogin controller;

        void IModelLogin.createNewUser(User user)
        {
            throw new NotImplementedException();
        }

        string IModelLogin.getSalt(string username)
        {
            return "00000000";
        }

        string IModelLogin.getSalt(int phonenumber)
        {
            throw new NotImplementedException();
        }

        string IModelLogin.getSalt(MailAddress emailAdress)
        {
            throw new NotImplementedException();
        }

        User IModelLogin.login(string username, string hash)
        {
            throw new NotImplementedException();
        }

        User IModelLogin.login(int phonenumber, string hash)
        {
            throw new NotImplementedException();
        }

        User IModelLogin.login(MailAddress emailAdress, string hash)
        {
            throw new NotImplementedException();
        }

        User IModelLogin.getUser(User user)
        {
            throw new NotImplementedException();
        }

        IViewLogin IModelLogin.ViewLogin { set => view = value; }
        IControllerLogin IModelLogin.ControllerLogin { set => controller = value; }

    }
}
