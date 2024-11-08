using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal interface IModelLogin
    {

        void createNewUser(User user);
        void getUser(User user);


        IViewLogin ViewLogin { set; }
        IControllerLogin ControllerLogin { set; }
    }
}
