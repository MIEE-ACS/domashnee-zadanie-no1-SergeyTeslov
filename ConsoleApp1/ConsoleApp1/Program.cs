//29вариант

using System;
public enum daysOfTheWeek
{
    Monday    = 1,
    Tuesday   = 2,
    Wednesday = 3,
    Thursday  = 4,
    Friday    = 5,
    Saturday  = 6,
    Sunday    = 7
}
namespace ConsoleApp1
{
    //правочка
    class Program
    {
        static void functionNumberOfDays() 
        {
            Console.WriteLine("please enter the day ");

            var userInput = Console.ReadLine();

            //проверка введёных данных 
            //start            
            Int32 val;
            try {
                val = int.Parse(userInput);
            }
            except {
                Console.WriteLine("not a number entered");
                return;
            }
            if ((val < 1) || (val > 365))
            {
                Console.WriteLine("entered a number outside the range 1 ... 365");
                return;
            }
            //end
            //проверка введёных данных 


            int day = ((val + 4) % 7) + 1;  //    смещение дня недели, 1 января было субботой      
            var NumberOfDay = (daysOfTheWeek)day;

            Console.WriteLine($"This days of the week is {NumberOfDay} is {(int)NumberOfDay}");

        }
        static void Main(string[] args)
        {

            //while (true) 
            //{
            //    functionNumberOfDays(); 
            //}
            functionNumberOfDays();

        }
    }
}
