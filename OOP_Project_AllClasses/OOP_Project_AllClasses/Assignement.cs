using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_AllClasses
{
    public class Assignement : Work
        
    {
        public Assignement(Course workCourse, DateTime workDate, string workContent, List<Class> workClasses) : base(workCourse, workDate, workContent, workClasses) 
        { 
        }
        public void DisplayAssignementInfos()
        {
            Console.WriteLine(WorkCourse.CourseName + WorkDate + WorkClasses);
            Console.WriteLine(WorkContent);
        }
    }
}

