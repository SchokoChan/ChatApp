using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChatApp
{
    internal interface IModelLogin
    {


        string getSalt(String username);
        string getSalt(int phonenumber);
        string getSalt(MailAddress emailAdress);


        void createNewUser(User user);

        User login(string username,string hash);
        User login(int phonenumber, string hash);
        User login(MailAddress emailAdress, string hash);

        User getUser(User user);



        IViewLogin ViewLogin { set; }
        IControllerLogin ControllerLogin { set; }
    }
}
