using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Assignement : Work
    {
        public void DisplayAssignementInfos() 
        {
            Console.WriteLine(WorkCourse.CourseName + WorkDate + WorkClasses);
            Console.WriteLine(WorkContent);
        }
    }
}
