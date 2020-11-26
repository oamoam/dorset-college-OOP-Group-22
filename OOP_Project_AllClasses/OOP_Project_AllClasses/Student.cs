using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    public class Student : User
    {
        public double FeesDue { get; set; }
        public Class CurrentClass { get; set; }
        public SortedList<DateTime, double> feesMemory { get; set; }
        public Attendance absenceList { get; set; }

        public Student(string lastName, string firstName, string email, string password, int userID) : base(lastName, firstName, email, password, userID)
        {
            FeesDue = 8000;
            feesMemory = new SortedList<DateTime, double>();
        }

        public void Payfee()
        {
            Console.WriteLine($"You have to pay: {FeesDue} euros; \n");
            Console.WriteLine("Select the amount :");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount == FeesDue)
            {
                FeesDue = 0;
                Console.WriteLine("You've paid everything.");
            }
            else if (amount < FeesDue)
            {
                FeesDue -= amount;
                feesMemory.Add(DateTime.Now, amount);
                Console.WriteLine("You've paid " + amount + " euros.");
                Console.WriteLine($"Now, you have to pay: {FeesDue} euros; \n");
            }
            else if (amount > FeesDue)
            {
                Console.WriteLine("That is too much !");
            }
        }






    }
}
