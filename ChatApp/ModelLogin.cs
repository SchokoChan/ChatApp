using System;
using System.Collections.Generic;
using System.Linq;
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

        void IModelLogin.getUser(User user)
        {
            throw new NotImplementedException();
        }

        IViewLogin IModelLogin.ViewLogin { set => view = value; }
        IControllerLogin IModelLogin.ControllerLogin { set => controller = value; }

    }
}
