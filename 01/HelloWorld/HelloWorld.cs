using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(args.Length);


            if (args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0]);

                // Check the type of args[0]
                if (args[0].GetType() == typeof(string))
                {
                    Console.WriteLine("args[0] is of type string.");
                }
                else if (args[0].GetType() == typeof(int))
                {
                    Console.WriteLine("args[0] is of type int.");
                }
                else
                {
                    Console.WriteLine("args[0] is of an unknown type.");
                }
            }
            else
            {
                Console.WriteLine("No command-line arguments provided.");
            }
        }
    }
}