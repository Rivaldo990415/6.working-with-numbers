using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you ca print numbers as below
            Console.WriteLine(5);

            //you can also use operators to perform operations
            Console.WriteLine(6+9);

            //module operator % to get remainders
            Console.WriteLine(6 % 9);

            //Bodmas still apply
            Console.WriteLine(6 + (9 *9));

            //what you do with integers you get integer back
            Console.WriteLine(6 / 9);

            //can give a number to a variable
            int num = 4;

            //you can incriment
            num++;
            Console.WriteLine(num);

            //calling e.g math method, abs means absolute
            //you alsways get positive num
            Console.WriteLine(Math.Abs(-70));

            //to raise to powers
            Console.WriteLine(Math.Pow(2,2));

            Console.ReadLine();




        }
    }
}
