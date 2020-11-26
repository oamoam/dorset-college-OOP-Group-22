using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    public class Faculty
    {
        public List<User> allUsers { get; set; }

        public Faculty()
        {
            allUsers = new List<User>();
        }

        public void facultyToString()
        {
            string ans = null;
            foreach (User user in allUsers)
            {
                if (user is Student)
                {
                    ans += $"The person called { user.firstName } is a Student\n";
                }
                if (user is Admin)
                {
                    ans += $"The person called { user.firstName } is an Admin\n";
                }
                //Add faculty members option
            }
            Console.WriteLine(ans);
        }

        public void addAUser(User user)
        {
            allUsers.Add(user);
        }

        public void removeAUser(User user)
        {
            allUsers.Remove(user);
        }


        public bool connect(string login, string password)
        {
            bool ans = false;
            foreach (User user in allUsers)
            {
                if (login == user.login && password == user.password)
                {
                    ans = true;
                }
            }
            return ans;
        }

        public User findUser(string login, string password)
        {
            User ans = null;
            foreach (User user in allUsers)
            {
                if (login == user.login && password == user.password)
                {
                    ans = user;
                }
            }
            return ans;
        }


        public User findStudent(int studentID)
        {
            User ans = null;
            foreach (User user in allUsers)
            {
                if (studentID == user.userID && user is Student)
                {
                    ans = user;
                }
            }
            return ans;
        }







    }
}
