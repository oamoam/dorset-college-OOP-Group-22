using System;
using System.Collections.Generic;

namespace OOP_Project_AllClasses
{
    public class Fees
    {
        public double amount { get; set; }
        public DateTime deadLine { get; set; }

        public void displayFeeinfo(Student student)
        {
            string info;
            if (student.FeesDue > 0)
            {
                info = $"The student has to pay: {student.FeesDue} euros; \n";

            }
            else info = "The student paid everything";
            Console.WriteLine(info);
        }

        public void displayFeeMemory(Student student)
        {
            string info = null;
            if (student.FeesDue != 8000)
            {
                foreach (KeyValuePair<DateTime, double> money in student.feesMemory)
                {
                    Console.WriteLine($"-> You have paid {money.Value} euros the {money.Key};\n");
                }
            }
            else info = "You haven't paid anything.";
            Console.WriteLine(info);
        }


    }
}

