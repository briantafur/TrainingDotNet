using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectManager
{
    public class UserController
    {
        private LinkedList<User> users;

        public UserController()
        {
            users = new LinkedList<User>();
        }

        internal LinkedList<User> Users { get => users; set => users = value; }

        public bool addUser(User us)
        {
            foreach (User item in users)
            {
                if (item.Username.Equals(us.Username))
                {
                    return false;
                }
            }
            users.AddLast(us);
            return true;
        }

        public User login(String username, String password)
        {
            foreach (User item in users)
            {
                if (item.Username.Equals(username) && item.Password.Equals(password))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="us"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        public bool addSubjectToUser(User us, Subject sub)
        {
            foreach (Subject item in us.Subjects)
            {
                if (item.Code.Equals(sub.Code))
                {
                    return false;
                }
            }
            us.Subjects.AddLast(sub);
            return true;
        }

        public void addGradeToSubject(Subject sub, LinkedList<Grade> grades)
        {
            foreach (Grade item in grades)
            {
                sub.Grades.AddLast(item);
            }
        }

    }
}
