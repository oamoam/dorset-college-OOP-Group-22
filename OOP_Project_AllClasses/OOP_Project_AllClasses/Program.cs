using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 23209 Adrien SFEIR, 23193 Paul CROSNIER, 22846 Brice OUCHIKH

            Console.WriteLine("Hello World!");

            // Things to create for the memory
            Faculty School = new Faculty();
            Fees fee = new Fees();
            List<Class> allclasses = new List<Class>();

            //Create the only Administrator
            Admin admin = new Admin("TEST1AD", "Luc", "23209@gmail.com", "azerty", 23209);
            School.addAUser(admin);

            //Create the first two Students of the Group A
            Student student1 = new Student("TEST2ST", "Marie", "23210@gmail.com", "qwerty", 23210);
            School.addAUser(student1);
            Student student2 = new Student("TEST3ST", "Jean", "23211@gmail.com", "qwerty", 23211);
            School.addAUser(student2);
            List<Student> studentsOfGroupA = new List<Student>();
            studentsOfGroupA.Add(student1);
            studentsOfGroupA.Add(student2);
            Class GroupA = new Class("Group A", studentsOfGroupA);


            //Create the first two Students of the Group B
            Student student3 = new Student("TEST4ST", "Luc", "23300", "qwerty", 23300);
            School.addAUser(student3);
            Student student4 = new Student("TEST5ST", "Laura", "23400", "qwerty", 23400);
            School.addAUser(student3);
            List<Student> studentsOfGroupB = new List<Student>();
            studentsOfGroupB.Add(student3);
            studentsOfGroupB.Add(student4);
            Class GroupB = new Class("Group B", studentsOfGroupB);

            //Add the new classes to the memory of all classes
            allclasses.Add(GroupA);
            allclasses.Add(GroupB);

            //Test verif ajout
            School.facultyToString();






            //Début application
            bool start = true;

            while (start == true)
            {

                string title = $"- Welcome to the login section.  -";  //Afffiche numéro de la page tout en haut (esthétique)
                int leadingSpaces = (90 - title.Length) / 2;
                Console.WriteLine(title.PadLeft(leadingSpaces + title.Length)); //Tjrs esthétique pour que le numéro soit centré
                Console.WriteLine();

                Console.WriteLine("Enter your login");
                string login = Console.ReadLine();

                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();

                bool connection = School.connect(login, password);
                Console.Clear();
                if (connection == false) Console.WriteLine("*Error ! Wrong Login or password*");



                while (connection == true)
                {

                    User personConnected = School.findUser(login, password);

                    // For an Admin
                    if (personConnected is Admin)
                    {
                        string adminTitle = $"- You're in the Administrator section.  -";
                        int leadingSpacesAdmin = (90 - adminTitle.Length) / 2;
                        Console.WriteLine(adminTitle.PadLeft(leadingSpacesAdmin + adminTitle.Length));
                        Console.WriteLine();

                        Console.WriteLine("\nWhat do you want to do ? \n1-> Add an Admin \n2-> Add a Course \n3-> Check public informations from an ID " +
                            "\n4-> Check a student's fees \n5-> See all the classes infos \n10-> Logout");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Admin newAdmin = ((Admin)personConnected).AddAdmin();
                                School.addAUser(newAdmin);
                                break;
                            case 2:
                                ((Admin)personConnected).createACourse();
                                break;
                            case 3:
                                ((Admin)personConnected).CheckPublicInfos(School.allUsers);
                                break;
                            case 4:
                                Console.WriteLine("write the ID");
                                int ID = Convert.ToInt32(Console.ReadLine());
                                Student personSearched = (Student)School.findStudent(ID);
                                if (personSearched is Student)
                                {
                                    fee.displayFeeinfo(personSearched);
                                }
                                else Console.WriteLine("It isn't a Student or doesn't exist");
                                break;
                            case 5:
                                Console.WriteLine("There are " + allclasses.Count + " different classes :");
                                foreach (Class classindex in allclasses)
                                {
                                    classindex.displayClassInfo();
                                }
                                break;
                            case 10:
                                Console.WriteLine("Good bye !\n");
                                connection = false;
                                break;
                        }
                    }

                    //For a Student
                    if (personConnected is Student)
                    {
                        Student studentConnected = (Student)personConnected;

                        string studentTitle = $"- You're in the Student section.  -";
                        int leadingSpacesStudent = (90 - studentTitle.Length) / 2;
                        Console.WriteLine(studentTitle.PadLeft(leadingSpacesStudent + studentTitle.Length));
                        Console.WriteLine();

                        Console.WriteLine("\nWhat do you want to do ? \n1-> Pay the fees \n2-> See your fees memory\n3-> Check your personal informations \n4-> Logout");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                studentConnected.Payfee();
                                break;
                            case 2:
                                fee.displayFeeMemory(studentConnected);
                                break;
                            case 3:
                                studentConnected.PersonalInformation();
                                break;
                            case 4:
                                Console.WriteLine("Good bye !\n");
                                connection = false;
                                break;
                        }
                    }

                    //For a Teacher

                    //pour Checker les infos des etudiants
                    //Console.WriteLine("write the ID");
                    //int ID = Convert.ToInt32(Console.ReadLine());
                    //Student personSearched = (Student)School.findStudent(ID);
                    //if (personSearched is Student)
                    { 
                    //for(int i= 0, i< this.ClassTeached.Count, i++)
                       
                        // if (personSearched.CurrentClass == this.ClassTeached[i])
                        //{fee.displayFeeinfo(personSearched);}
                    }

                    //UpdateOwnStudentAttendance
                    //Console.WriteLine("write the ID");
                    //int ID = Convert.ToInt32(Console.ReadLine());
                    //Student personSearched = (Student)School.findStudent(ID);
                    //if (personSearched is Student)
                    {
                       // DateTime absence = Convert.ToDateTime(Console.ReadLine());
                       // personSearched.Attendance.absencelist.Add(absence);
                    }
                }

            }
        }
    }
}

    

