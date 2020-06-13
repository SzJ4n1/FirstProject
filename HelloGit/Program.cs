using System;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "-help")
            {
                Console.WriteLine("This is a test app to learn how to use github");
            }
            else
            {
                Console.WriteLine("Hello Git!");
            }
        }
    }
}
