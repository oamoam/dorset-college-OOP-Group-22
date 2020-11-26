using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseObjectives { get; set; }
        public int HoursDedicated { get; set; }
        public int LessonsDedicated { get; set; }
        public List<Date> CoursTT { get; set; }

        public Course(string courseName, string courseDescription, string courseObjectives, int lessonsDedicated, int hoursDedicated, List<Date> coursTT)
        {
            this.CourseName = courseName;
            this.CourseDescription = courseDescription;
            this.CourseObjectives = courseObjectives;
            this.HoursDedicated = hoursDedicated;
            this.LessonsDedicated = lessonsDedicated;
            this.CoursTT = coursTT;
        }

        public void displayLessonPlan()
        {
            string info = $"Course name : {CourseName};\nCourse description : {CourseDescription}; \nHours dedicated for this course : {HoursDedicated} hours;\nNumber of lessons : {LessonsDedicated} lessons;\n";
            info += $"This course objectives are : {CourseObjectives}  ;\n";
            info += $"The timetable : ";
            string info2 = null;
            foreach (Date timetable in CoursTT)
            {
                info2 = "-> Each lesson will be the " + timetable.days + " during the " + timetable.moments + "; \n";
            }

            Console.WriteLine(info);
            Console.WriteLine(info2);

        }
    }
}
