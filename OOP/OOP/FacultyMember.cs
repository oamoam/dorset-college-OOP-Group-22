using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class FacultyMember : User  //y a des references a d'autres classes qui existent pas encore faudra verifier si ça marche avec le code complet
    {
        private List<Course> courseTeached;
        private List<Class> classTeached;
        private List<Assignement> assignementCreated;
        private List<Exam> examCreated;
        public FacultyMember(List<Course> courseTeached,List<Class> classTeached, List<Assignement> assignementCreated, List<Exam> examCreated)
        {
            this.courseTeached = courseTeached;
            this.classTeached = classTeached;
            this.assignementCreated = assignementCreated;
            this.examCreated = examCreated;
        }
        private List<Course> CourseTeached
        {
            get
            {
                return this.courseTeached;
            }
            set 
            {
                this.courseTeached = value;
            }
        }
        private List<Class> ClassTeached
        {
            get
            {
                return this.classTeached;
            }
            set
            {
                this.classTeached = value;
            }
        }
        private List<Assignement> AssignementCreated
        {
            get
            {
                return this.assignementCreated;
            }
            set
            {
                this.assignementCreated = value;
            }
        }
        private List<Exam> ExamCreated
        {
            get
            {
                return this.examCreated;
            }
            set
            {
                this.examCreated = value;
            }
        }
        private void CreateWork(Course workCourse, DateTime workDate, string workContent, List<Class> workClasses, int examCoeff ) 
        {
            if (examCoeff == 0) 
            {
                this.AssignementCreated.Add(new Assignement { WorkCourse = workCourse, WorkDate = workDate, WorkContent = workContent, WorkClasses = workClasses });
            }
            else 
            {
                List<double> examGrades = new List<double>() ;
                this.ExamCreated.Add(new Exam { WorkCourse = workCourse, WorkDate = workDate, WorkContent = workContent, WorkClasses = workClasses, ExamGrades = examGrades, ExamIsCorriged = false, ExamCoeff = examCoeff });
            }
        }
        private void UpdateExam(int ExamPosition, bool examIsCorriged, List<double> examGrades) 
        {
            this.ExamCreated[ExamPosition].ExamIsCorriged = examIsCorriged;
            this.ExamCreated[ExamPosition].ExamGrades = examGrades;
        }
        private void CheckOwnStudentInfos(int studentID) //Je sais pas quelle est la structure finale de faculty donc ce sera a plus tard
        {            
        }
    }
}
