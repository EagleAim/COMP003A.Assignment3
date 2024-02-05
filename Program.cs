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
            Console.Write("\tEnter your numbered grade (0-100): ");
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
            else
            {
                Console.WriteLine("\t Invalid");
            }


            Console.WriteLine("***************************************************");
            Console.WriteLine("Integer to string day using an switch statement");
            Console.Write("\t Enter a integer day of the week (1-7): ");
            double numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 1:
                    Console.WriteLine("\tMonday");
                    break;

                case 2:
                    Console.WriteLine("\tTuesday");
                    break;

                case 3:
                    Console.WriteLine("\tWednesday");
                    break;

                case 4:
                    Console.WriteLine("\tThursday");
                    break;

                case 5:
                    Console.WriteLine("\tFriday");
                    break;

                case 6:
                    Console.WriteLine("\tSaturday");
                    break;

                case 7:
                    Console.WriteLine("\tSunday");
                    break;

                default:
                    Console.WriteLine("\t Invalid day");
                    break;
            }
        }
    }
}
