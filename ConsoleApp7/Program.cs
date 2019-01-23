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

                int get_your_grade = cal_grade(marks);

            }
            catch { }
        }//end of main
        private static int cal_grade(int get_marks)
        {
            if (get_marks >= 95)
            {
                string a = "A+";
                Console.WriteLine("Your grade is :"  + a);
            }
            else if (get_marks >= 90)
            {
                string a = "A";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 87)
            {
                string a = "A-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 84)
            {
                string a = "B+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 80)
            {
                string a = "B";
                Console.WriteLine("Your grade is B" + a);
            }
            else if (get_marks >= 77)
            {
                string a = "B-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 74)
            {
                string a = "C+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 70)
            {
                string a = "C";
                Console.WriteLine("Your grade is C:" + a);
            }
            else if (get_marks >= 67)
            {
                string a = "C-";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 63)
            {
                string a = "D+";
                Console.WriteLine("Your grade is :" + a);
            }
            else if (get_marks >= 60)
            {
                string a = "D";
                Console.WriteLine("Your grade is D" + a);
            }
            else
            {
                string a = "F";
                Console.WriteLine("Your grade is :" + a);
            }
            return a;
        }

    }
}
