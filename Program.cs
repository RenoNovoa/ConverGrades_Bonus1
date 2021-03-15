using System;
using System.Text;

namespace Bonus_1ConvertNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bienvenido = new StringBuilder();
            Bienvenido.Append("Welcome to the");
            Bienvenido.Append(" Letter ");
            Bienvenido.Append(" Converter!");
            Console.WriteLine(Bienvenido.ToString());

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
               
                var grade = GetGrade("\nEnter a numerical grade: ");
               
                if (grade <= 100 && grade >= 88)
                {
                    Console.WriteLine("\nAwesome, you got an: A ");
                }
                else if (grade <= 87 && grade >= 80)
                {
                    Console.WriteLine("\nNice Job, you got an: B ");
                }
                else if (grade <= 79 && grade >= 67)
                {
                    Console.WriteLine("\nGood Job, you got an: C");
                }
                else if (grade <= 66 && grade >= 60)
                {
                    Console.WriteLine("\nCool, you got an:  D ");
                }
                else if (grade <= 60 && grade >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo Bueno, you got an: F ");
                }
                else
                {
                    Console.WriteLine("\nEstas un poco Loco Att: Danny Novoa");
                }

            } while (PrompToContinue());
            Console.WriteLine("\nAdios amigo ");
            Console.ReadKey();
        }

        private static bool PrompToContinue()
        {
            Console.WriteLine("To Continue enter (Y/N): ");
            string respons = Console.ReadLine();
            while (!respons.Equals("Y", StringComparison.OrdinalIgnoreCase) && !respons.Equals("N",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("NO BUENO, Try again: ");
                respons = Console.ReadLine();
            }
            return respons.Equals("Y", StringComparison.OrdinalIgnoreCase);
        }

        private static int  GetGrade(string messege)
        {
            Console.Write(messege);
            int grade;
            while (!int.TryParse(Console.ReadLine(), out grade))
            {
                Console.Write("\nNo Bueno, Intenta Nuevamente\nEnter a numerical grade:");
            }
            return grade;

        }
    }
}             
