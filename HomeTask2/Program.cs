using SubTask1;
using SubTask2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        public static void FirstTask() {
            StringCatcher stringCathcer = new StringCatcher();
            Console.WriteLine("Please enter three correct lines");
            var count = 0;
            while (count < 3)
            {
                try
                {
                    stringCathcer.CatchString(Console.ReadLine());
                    count++;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("The programm found error, please try again");
                    Console.WriteLine("Exception message: " + ex.Message);
                }
            }
            Console.WriteLine(stringCathcer.Result);
            Console.ReadLine();
        }

        public static void SecondTask()
        {
            IntConverter converter = new IntConverter();
            Console.WriteLine("Please enter three correct lines for convert");
            var count = 0;
            while (count < 3)
            {
                try
                {
                    Console.WriteLine(converter.Convert(Console.ReadLine()));
                    count++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The programm found error, please try again");
                    Console.WriteLine("Exception message: " + ex.Message);
                }
            }
        }
    }
}
