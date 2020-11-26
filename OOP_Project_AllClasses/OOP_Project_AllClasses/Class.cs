using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Project_AllClasses
{
    public class Class
    {
        public string className { get; set; }
        public List<Student> classOfStudents { get; set; }

        public Class(string className, List<Student> classOfStudents)
        {
            this.className = className;
            this.classOfStudents = classOfStudents;
        }


        public void displayClassMembers()
        {
            string ans = $"The students of the class { className } are : \n";
            foreach (Student student in classOfStudents)
            {
                ans += $"-> { student.firstName };   \n";
            }
            Console.WriteLine(ans);
        }



        public void displayClassInfo()
        {
            string ans = $"In the class { className }, there are { classOfStudents.Count() } students.";
            Console.WriteLine(ans);
        }        

    }
}

