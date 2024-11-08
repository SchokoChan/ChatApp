using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    internal interface IViewLogin
    {
        void LoginSuccessful(User user);
        void LoginFailed(String errorMessage);
        void LoginCanceled(String errorMessage);

        void RegisterSuccessful(User user);
        void RegisterFailed(String errorMessage);
        void RegisterCanceled(String errorMessage);


        void Logout();
    }
}
