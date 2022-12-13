using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int num = 10;
            float totalPrice = 20.95f;
            decimal totalDiscount = 10m;
            char character= 'a';
            var name = "Prasiddha";
            bool isWorking = true;
            
            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(totalPrice);
            Console.WriteLine(totalDiscount);
            Console.WriteLine( character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);


        }
    }
}