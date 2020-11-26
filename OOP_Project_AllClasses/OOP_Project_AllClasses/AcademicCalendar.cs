using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP_Project_AllClasses
{
    public class AcademicCalendar
    {

        public List<Date> CourseCalendar { get; set; }
        public List<Date> WorkCalendar { get; set; }

        public AcademicCalendar(List<Date> CourseCalendar, List<Date> WorkCalendar)
        {
            this.CourseCalendar = CourseCalendar;
            this.WorkCalendar = WorkCalendar;
        }

    }
}