using System;

//namespace
namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declate variables
            String name;

            //Intro to app
            Console.WriteLine("Welcome to the structure of C# program demo!" +
                "\nPlease enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            //Writing information about the structure of a C# program
            Console.WriteLine("\nProgram structure demonstrated:" +
                "\nusing system: import functionality" +
                "\nnamespace : organization of code" +
                "\nClass program : container for code" +
                "\nMain() : entry point of the program" +
                "\nComments : explanations for the code");
        }//main()
    }//class
}//namespace
