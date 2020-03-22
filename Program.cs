using System;
using System.Linq;

namespace OOPCodeReview
{
    class Program
    {
        static void Main()
        {
            //Creates a new FileReader and Compare object
            FileReader fr = new FileReader();
            Compare comp = new Compare();
            //Calls the file reading method in the object
            fr.FileReadAll();
            //Gives the user the options they could use
            Console.WriteLine("Please select which files to compare:");
            Console.WriteLine("1: GitRepositories_1a and _1b");
            Console.WriteLine("2: GitRepositories_2a and _2b");
            Console.WriteLine("3: GitRepositories_3a and _3b");
            //Takes the user's input for their choice
            string fileChoice = Console.ReadLine();
            //If the user's input isn't one of the options, an infinite loop is used until it is a valid input.
            while (fileChoice != "1" && fileChoice != "2" && fileChoice != "3") 
            {
                Console.WriteLine("Please input a valid number.");
                fileChoice = Console.ReadLine();
            }
            //A switchcase is used here to hold each of the different variations of the program for each option
            switch(fileChoice)
            {
                //Each case relates to each option number
                case "1":
                    Console.WriteLine("Comparing 1a and 1b");
                    comp.IsSame(fr.file1a, fr.file1b);
                    break;

                case "2":
                    Console.WriteLine("Comparing 2a and 2b");
                    comp.IsSame(fr.file2a, fr.file2b);
                    break;

                case "3":
                    Console.WriteLine("Comparing 3a and 3b");
                    comp.IsSame(fr.file3a, fr.file3b);
                    break;
            }
            //Asks the user if they want to restart the program or quit, is exception handled.
            Console.WriteLine(Environment.NewLine + "Enter r to restart or e to exit.");
            string exitChoice = Console.ReadLine();
            while (exitChoice != "r" && exitChoice != "e")
            {
                Console.WriteLine("Please input r or e.");
                exitChoice = Console.ReadLine();
            }
            switch (exitChoice)
            {
                case "r":
                    //Reiterates the program
                    Main();
                    break;

                case "e":
                    //Exits the program
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
