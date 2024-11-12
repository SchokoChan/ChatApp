using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Konscious.Security.Cryptography;
using Org.BouncyCastle.Security;

namespace ChatApp
{
    internal class ControllerLogin : IControllerLogin
    {
        private IModelLogin model;
        private IViewLogin view;

        void IControllerLogin.Login(string username, string password)
        {
            if (username != null && password != null)
            {
                string salt = model.getSalt(username);
                string hash = hashPassword(password, salt);
                model.login(username, hash);
            }
            else
            {
                view.LoginFailed("Username or password is null ");
            }
        }

        void IControllerLogin.Login(int phonenumber, string password)
        {
            if (phonenumber != null && password != null)
            {
                string salt = model.getSalt(phonenumber);
                string hash = hashPassword(password, salt);
                model.login(phonenumber, hash);
            }
            else
            {
                view.LoginFailed("Phonenumber or password is null ");
            }
        }

        void IControllerLogin.Login(MailAddress email, string password)
        {
            if (email != null && password != null)
            {
                string salt = model.getSalt(email);
                string hash = hashPassword(password, salt);
                model.login(email, hash);
            }
            else
            {
                view.LoginFailed("Email or password is null ");
            }
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

        private static string hashPassword(string password,string  saltString)
        {
            int iterations = 2;
            int memorySize = 8192;
            int degreeOfParallelism = 4;
            int hashLength = 64;
            byte[] salt = Encoding.UTF8.GetBytes(saltString);
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                Iterations = iterations,                
                MemorySize = memorySize,                
                DegreeOfParallelism = degreeOfParallelism 
            };

            return Convert.ToBase64String(argon2.GetBytes(hashLength));         
        }

        private string generateSalt()
        {
            string salt = "";
            List<char> chars = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', '|', ';', ':', '\'', ',', '.', '<', '>', '?'
            };

            Random random = new Random();
            
            for (int i = 0; i < 8; i++)
            {
                salt += chars[random.Next(0,chars.Count())];
            }
            return salt;
        }

        IViewLogin IControllerLogin.ViewLogin { set => view = value; }
        IModelLogin IControllerLogin.ModelLogin { set => model = value; }
    }
}
