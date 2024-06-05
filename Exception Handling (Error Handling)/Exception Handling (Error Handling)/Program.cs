using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling__Error_Handling_
{
    internal class Exception
    {

        public void show()
        {
          /*  Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exception obj = new Exception();
             obj.show();
             Console.WriteLine("Your result is : {0}", obj.show());*/

            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Your Result {0}",result);
            Console.ReadLine();
        }
    }
}
