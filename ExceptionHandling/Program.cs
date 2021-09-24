using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //start try block
            try
            {
                Console.Write("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            //catch block
            catch(Exception ex)
            {
                Console.WriteLine("Error info: " + ex.Message);
            }
            //finally block
            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }
        }
    }
}
