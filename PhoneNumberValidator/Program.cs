using System;

namespace PhoneNumberValidator
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            try
            {
                var program = new Program();
                program.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
                return 2;
            }

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