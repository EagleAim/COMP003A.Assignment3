/*
 * Author:Logan King
 * course: Comp003-C#
 * Purpouse: To show that we can use if and switch commands.
*/
namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using and if-else statement");
            Console.Write("\tEnter your numbered grade (0-100) ");
            double numericGrade = Convert.ToInt32(Console.ReadLine());

            if (numericGrade >= 90 && numericGrade <= 100)
            {
                Console.WriteLine("\t Grade: A");
            }

            else if (numericGrade >= 80 && numericGrade <= 89)
            {
                Console.WriteLine("\t Grade: B");
            }
            else if (numericGrade >= 70 && numericGrade <= 79)
            {
                Console.WriteLine("\t Grade: D");
            }

            else if (numericGrade >= 60 && numericGrade <= 69)
            {
                Console.WriteLine("\t Grade: D");
            }

            else if (numericGrade >= 0 && numericGrade <= 59)
            {
                Console.WriteLine("\t Grade: F");
            }

            else if (numericGrade >= 100)
            {
                Console.WriteLine("\t Invalid");
            }
            else if (numericGrade <= 0)
            {
                Console.WriteLine("\t Invalid");
            }


            Console.WriteLine("***************************************************");
            Console.WriteLine("Integer to string day using an switch statement");
            Console.Write("\tEnter your numbered grade (0-100) ");

        }
    }
}
