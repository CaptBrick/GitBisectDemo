using System;

namespace PhoneNumberValidator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        public void Run()
        {
            while (true)
            {
                var validator = new Validator();

                Console.WriteLine();
                Console.WriteLine("------------------");
                Console.WriteLine("Enter phone number:");
                var input = Console.ReadLine();
                Console.WriteLine();
                Console.Write("{0} is ", input);
                if (validator.IsNumberValid(input))
                {
                    Console.WriteLine("valid phone number");
                }
                else
                {
                    Console.WriteLine("invalid phone number");
                }
            }
        }
    }
}