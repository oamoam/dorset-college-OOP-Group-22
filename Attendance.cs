using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Attendance
    {
        public List<DateTime> absenceList;
        public List<DateTime> CourseTeached
        {
            get
            {
                return this.absenceList;
            }
            set
            {
                this.absenceList = value;
            }
        }
        public void DisplayOwnAttendance()
        {
            Console.WriteLine("You have " + absenceList.Count + " absences");
            if (absenceList.Count != 0) 
            {
                for (int i = 0; i < absenceList.Count; i++)
                {
                    Console.WriteLine("You were absent the " + absenceList[i].Date);
                }

            }

        }
    }
}
