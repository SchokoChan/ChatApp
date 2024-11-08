using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatApp
{
    public partial class MainWindow : Window , IViewLogin
    {
        private IModelLogin model = new ModelLogin();
        private IControllerLogin controller = new ControllerLogin();

        public MainWindow()
        {
            InitializeComponent();
            InitializeMVC();
        }

        private void InitializeMVC()
        {
            model.ViewLogin = this;
            model.ControllerLogin = controller;

            controller.ModelLogin = model;
            controller.ViewLogin = this;
        }

        void IViewLogin.LoginCanceled(string errorMessage)
        {
            throw new NotImplementedException();
        }

        void IViewLogin.LoginFailed(string errorMessage)
        {
            throw new NotImplementedException();
        }

        void IViewLogin.LoginSuccessful(User user)
        {
            throw new NotImplementedException();
        }

        void IViewLogin.Logout()
        {
            throw new NotImplementedException();
        }

        void IViewLogin.RegisterCanceled(string errorMessage)
        {
            throw new NotImplementedException();
        }

        void IViewLogin.RegisterFailed(string errorMessage)
        {
            throw new NotImplementedException();
        }

        void IViewLogin.RegisterSuccessful(User user)
        {
            throw new NotImplementedException();
        }
    }
}