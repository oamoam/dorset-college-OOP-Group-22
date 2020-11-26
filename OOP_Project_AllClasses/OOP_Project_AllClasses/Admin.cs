using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    public class Admin : User
    {
        public Faculty listUser = new Faculty();

        public Admin(string lastName, string firstName, string email, string password, int userID) : base(lastName, firstName, email, password, userID)
        {

        }

        // Instead of a DateTime maybe we can use List<Date> where Date(Day, Morning or evening)
        public void createACourse()
        {
            Console.WriteLine("Write the name :");
            string courseName = Console.ReadLine();

            Console.WriteLine("Write the description :");
            string courseDescription = Console.ReadLine();

            Console.WriteLine("Write the objectives :");
            string courseObjectives = Console.ReadLine();

            Console.WriteLine("Write the number of lessons");
            int lessonsDedicated = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How long will a lesson be ?");
            int hoursDedicated = (Convert.ToInt32(Console.ReadLine())) * lessonsDedicated;

            Console.WriteLine("Which day ?");
            string day = Console.ReadLine().ToLower();

            Console.WriteLine("the lessons will be during the morning or evening ?");
            string moment = Console.ReadLine().ToLower();

            List<Date> coursTT = new List<Date>();

            for (int i = 1; i <= lessonsDedicated; i++)
            {
                Date newDate = new Date(day, moment, i);
                coursTT.Add(newDate);
            }

            Course newCourse = new Course(courseName, courseDescription, courseObjectives, lessonsDedicated, hoursDedicated, coursTT);
            Console.WriteLine(" The course is added! ");
            newCourse.displayLessonPlan();

        }



        public Admin AddAdmin()//idem pour student, faculty...
        {
            Console.WriteLine("Write his last name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Write his first name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Write his email :");
            string login = Console.ReadLine();

            Console.WriteLine("Write his password :");
            string password = Console.ReadLine();

            Console.WriteLine("Write his ID :");
            int userID = Convert.ToInt32(Console.ReadLine());

            Admin newAdmin = new Admin(lastName, firstName, login, password, userID);
            return newAdmin;


        }

        /*
        public Student addStudent()// idem pour faculty...
        {
            Console.WriteLine("Write his last name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Write his first name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Write his email :");
            string login = Console.ReadLine();

            Console.WriteLine("Write his password :");
            string password = Console.ReadLine();

            Console.WriteLine("Write his ID :");
            int userID = Convert.ToInt32(Console.ReadLine());

            Student newStudent = new Student(lastName, firstName, login, password, userID);
            return newStudent;

        }
        */


        public void CheckPublicInfos(List<User> allUsers)
        {
            string ans = null;
            Console.WriteLine("Write the ID of the person that you're looking for.");
            int userID = Convert.ToInt32(Console.ReadLine());
            foreach (User users in allUsers)
            {
                if (users.userID == userID)
                {

                    ans += users.showPublicInformation() + "\n";
                }
            }
            if (ans == null) ans += "The person doesn't exist \n";
            Console.WriteLine(ans);
        }







    }
}
