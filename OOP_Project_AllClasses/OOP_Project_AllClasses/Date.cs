using System;
namespace OOP_Project_AllClasses
{
    public class Date
    {
        public string days { get; set; }
        public string moments { get; set; }
        public int lessonNumber { get; set; }

        public Date(string days, string moments)
        {
            this.days = days;
            this.moments = moments;
        }

        public Date(string days, string moments, int lessonNumber)
        {
            this.days = days;
            this.moments = moments;
            this.lessonNumber = lessonNumber;
        }

        public string courseToString()
        {
            return ("Each" + days + " during the " + moments + " you will have this course.");
        }
    }
}
