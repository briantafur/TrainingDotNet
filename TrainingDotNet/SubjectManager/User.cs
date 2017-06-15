using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectManager
{
    public class User
    {

        private String name;
        private String username;
        private String password;
        private LinkedList<Subject> subjects;

        public User(string name, string username, string password)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            subjects = new LinkedList<Subject>();
        }

        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        internal LinkedList<Subject> Subjects { get => subjects; set => subjects = value; }
    }
}
