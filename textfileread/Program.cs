using System;
using System.IO;

namespace Assessment2
{
    class Program
    {
        static void Main()
        {
            // Manually listing the text files that can be read and compared
            Console.WriteLine("All Files to Compare Below:");
            Console.WriteLine("\n1. GitRepositories_1a.txt");
            Console.WriteLine("2. GitRepositories_1b.txt");
            Console.WriteLine("3. GitRepositories_2a.txt");
            Console.WriteLine("4. GitRepositories_2b.txt");
            Console.WriteLine("5. GitRepositories_3a.txt");
            Console.WriteLine("6. GitRepositories_3b.txt");

            // Asking the user to select a file and giving an example of the format for the input
            Console.WriteLine("\nSelect first file: for example 3 = GitRepositories_2a.txt");

            // While loop declared for input validation, so the user can't break the program
            while (true)
            {
                // User's input is monitored for validation
                string fileChoice = Console.ReadLine();
                
                // TryParse used in an infinite loop until a condition is met
                int num = -1;
                if (!int.TryParse(fileChoice, out num))
                {
                    Console.WriteLine("Please enter a value between 1 and 6");
                }
                else
                {
                    if (fileChoice == "1")
                    {
                        string[] GitRep1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_1a.txt = {0}", GitRep1a);
                    }
                    else if (fileChoice == "2")
                    {
                        string[] GitRep1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_1b.txt = {0}", GitRep1b);
                    }
                    else if (fileChoice == "3")
                    {
                        string[] GitRep2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_2a.txt = {0}", GitRep2a);
                    }
                    else if (fileChoice == "4")
                    {
                        string[] GitRep2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_2b.txt = {0}", GitRep2b);
                    }
                    else if (fileChoice == "5")
                    {
                        string[] GitRep3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_3a.txt = {0}", GitRep3a);
                    }
                    else if (fileChoice == "6")
                    {
                        string[] GitRep3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_3b.txt = {0}", GitRep3b);
                    }
                    Console.WriteLine("\nSelect second file: for example 4 = GitRepositories_2b.txt");

                    while (true)
                    {
                        string fileChoice2 = Console.ReadLine();
                        int num2 = -1;
                        if (!int.TryParse(fileChoice2, out num2))
                        {
                            Console.WriteLine("Please enter a value between 1 and 6");
                            break;
                        }
                        else
                        {
                            if (fileChoice2 == "1")
                            {
                                string[] GitRep1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_1a.txt = {0}", GitRep1a);
                            }
                            else if (fileChoice2 == "2")
                            {
                                string[] GitRep1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_1b.txt = {0}", GitRep1b);
                            }
                            else if (fileChoice2 == "3")
                            {
                                string[] GitRep2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_2a.txt = {0}", GitRep2a);
                            }
                            else if (fileChoice2 == "4")
                            {
                                string[] GitRep2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_2b.txt = {0}", GitRep2b);
                            }
                            else if (fileChoice2 == "5")
                            {
                                string[] GitRep3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_3a.txt = {0}", GitRep3a);
                            }
                            else if (fileChoice2 == "6")
                            {
                                string[] GitRep3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_3b.txt = {0}", GitRep3b);
                            }
                            else if (fileChoice2 == "")
                                Console.WriteLine("Please input values between 1 and 6");

                            if (fileChoice2 != fileChoice)
                            {
                                Console.WriteLine("\nThe files are not the same");
                            }
                            else if (fileChoice2 == fileChoice)
                            {
                                Console.WriteLine("\nThe files are the same");
                            }
                            //Else, if the files aren't the same, then they are the same with this statement
                            string Yes = "1";
                            string No = "2";
                            Console.WriteLine("Would You Like To Read Another File, 1 = Yes, 2 = No");
                            Console.WriteLine(Yes);
                            Console.WriteLine(No);
                            string userInput = Console.ReadLine();
                            if (userInput == Yes)
                            {
                                Main();
                            }
                            else if (userInput == No)
                            {
                                string endChoice = Console.ReadLine();
                                int num3 = -1;
                                if (!int.TryParse(endChoice, out num3))
                                {
                                    Console.WriteLine("Please enter only these values, 1 for Yes, 2 for No");
                                }

                                Console.WriteLine("Task Completed, Program Terminated");
                                System.Environment.Exit(-1);
                            }
                        }
                    }
                }
            }
        }
    }
}