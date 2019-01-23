using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your marks");

            try {
                int marks;
                marks = Convert.ToInt32(Console.ReadLine());

                string get_your_grade = cal_grade(marks);

            }
            catch { }
        }//end of main
        private static string cal_grade(int get_marks)
        {
            string a = " ";
            if (get_marks >= 95)
            {
                a = "A+";
                Console.WriteLine("Your grade is :"  + a);
            }
            else if (get_marks >= 90)
            {
                a = "A";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 87)
            {
                a = "A-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 84)
            {
                a = "B+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 80)
            {
                a = "B";
                Console.WriteLine("Your grade is B" + a);
            }
            else if (get_marks >= 77)
            {
                a = "B-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 74)
            {
                a = "C+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 70)
            {
                a = "C";
                Console.WriteLine("Your grade is C:" + a);
            }
            else if (get_marks >= 67)
            {
                a = "C-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 63)
            {
                a = "D+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 60)
            {
                a = "D";
                Console.WriteLine("Your grade is D" + a);
            }
            else
            {
                a = "F";
                Console.WriteLine("Your grade is :" + a);
            }
            return a;
        }

    }
}
