using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string message = null;
            string checksum = null;



            Console.WriteLine("What is your message?");
            input = Console.ReadLine().ToUpper();

            foreach (char c in input)
            {
                int numberValue = Convert.ToInt32(c);
                message = $"{numberValue}-";
                Console.WriteLine(message);


            }

                Console.WriteLine($"Your encoded message is {message}");

            //Console.WriteLine($"Your checksum is {checksum}");

        }
    }
}
