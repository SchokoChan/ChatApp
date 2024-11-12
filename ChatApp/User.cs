using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ChatApp
{
    public class User
    {
        private int id;
        private string username;
        private MailAddress emailadress;
        private int phonenumber;

        public User(int id, string username, MailAddress emailadress, int phonenumber)
        {
            this.id = id;
            this.username = username;
            this.emailadress = emailadress;
            this.phonenumber = phonenumber;
        }
        public User(int id, string username)
        {
            this.id = id;
            this.username = username;
        }
        public User(int id, MailAddress emailadress)
        {
            this.id = id;
            this.emailadress = emailadress;
        }
        public User(int id, int phonenumber)
        {
            this.id = id;
            this.phonenumber = phonenumber;
        }
        public User()
        {

        }

        public int Id { get => id; }
        public string Username { get => username;}
        public MailAddress Emailadress { get => emailadress; }
        public int Phonenumber { get => phonenumber; }
    }
}
