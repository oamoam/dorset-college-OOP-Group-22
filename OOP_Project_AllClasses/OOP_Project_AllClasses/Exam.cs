using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_AllClasses
{
    public class Exam : Work
    {
        List<Double> examGrades;
        bool examIsCorriged;
        int examCoeff;
        public Exam(List<double> examGrades, bool examIsCorriged, int examCoeff, Course workCourse, DateTime workDate, string workContent, List<Class> workClasses) : base (workCourse,  workDate, workContent, workClasses)
        {
            this.examGrades = examGrades;
            this.examIsCorriged = examIsCorriged;
            this.examCoeff = examCoeff;
        }
        public List<double> ExamGrades
        {
            get
            {
                return this.examGrades;
            }
            set
            {
                this.examGrades = value;
            }
        }
        public bool ExamIsCorriged
        {
            get
            {
                return this.examIsCorriged;
            }
            set
            {
                this.examIsCorriged = value;
            }
        }
        public int ExamCoeff
        {
            get
            {
                return this.examCoeff;
            }
            set
            {
                this.examCoeff = value;
            }
        }
        public void DisplayExamInfos()
        {
            if (ExamIsCorriged == true)
            {
                Console.WriteLine(WorkCourse.CourseName + WorkDate + WorkClasses);
                Console.WriteLine(WorkContent);
                Console.WriteLine(ExamGrades);            //pareil il me faut la structure de faculty pour le faire donc on repassera mais ici on met la note
            }
            else
            {
                Console.WriteLine(WorkCourse.CourseName + WorkDate + WorkClasses);
                Console.WriteLine(WorkContent);
            }

        }
    }
}
