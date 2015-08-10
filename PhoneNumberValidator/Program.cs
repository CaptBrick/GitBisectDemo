using System;

namespace PhoneNumberValidator
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            var program = new Program();
            program.Run();
            return 0;
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
                string validString;
                if (validator.IsNumberValid(input))
                {
                    validString = "valid";
                }
                else
                {
                    validString = "invalid";
                }
                Console.Write("{0} is {1} phone number", input, validString);
            }
        }
    }
}