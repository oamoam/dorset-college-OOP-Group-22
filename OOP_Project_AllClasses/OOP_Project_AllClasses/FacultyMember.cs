using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_AllClasses
{
    public class FacultyMember : User 
    {
        private List<Course> courseTeached;
        private List<Class> classTeached;
        private List<Assignement> assignementCreated;
        public List<Exam> examCreated;
        public FacultyMember(string lastName, string firstName, string email, string password, int userID, List<Course> courseTeached, List<Class> classTeached, List<Assignement> assignementCreated, List<Exam> examCreated) : base(lastName, firstName, email, password, userID)
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
        public List<Exam> ExamCreated
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
        private void CreateWork(Course workCourse, DateTime workDate, string workContent, List<Class> workClasses, int examCoeff)
        {
            if (examCoeff == 0)
            {                
                this.AssignementCreated.Add(new Assignement (workCourse,workDate,workContent,workClasses ));
            }
            else
            {
                List<double> examGrades = new List<double>();
                this.ExamCreated.Add(new Exam (examGrades, false, examCoeff, workCourse, workDate, workContent, workClasses));
            }
        }
        private void UpdateExam(int ExamPosition, bool examIsCorriged, List<double> examGrades)
        {
            this.ExamCreated[ExamPosition].ExamIsCorriged = examIsCorriged;
            this.ExamCreated[ExamPosition].ExamGrades = examGrades;
        }
        private void CheckOwnStudentInfos(int studentID) //jte les mis en commentaire ça va dans le main
        {            
        }
        private void UpdateOwnStudentAttendance (int studentID) // pareil en comm dans le main

        { 
        }
    }
}

