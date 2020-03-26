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
                
                // TryParse used in an infinite loop until a condition is met, which is validating user input is an integer
                int num = -1;
                if (!int.TryParse(fileChoice, out num))
                {
                    // User asked to re-enter values corresponding to the files 
                    Console.WriteLine("Please enter a value between 1 and 6");
                }
                // Otherwise "else" if the input is an integer, execute block below
                else
                {
                    // If statement for if the input is 1, read entire text file, and display contents
                    if (fileChoice == "1")
                    {
                        string[] GitRep1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_1a.txt = {0}", GitRep1a);
                    }
                    // Else if statement for if the input is 2, read entire text file, and display contents
                    else if (fileChoice == "2")
                    {
                        string[] GitRep1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_1b.txt = {0}", GitRep1b);
                    }
                    // Else if statement for if the input is 3, read entire text file, and display contents
                    else if (fileChoice == "3")
                    {
                        string[] GitRep2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_2a.txt = {0}", GitRep2a);
                    }
                    // Else if statement for if the input is 4, read entire text file, and display contents
                    else if (fileChoice == "4")
                    {
                        string[] GitRep2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_2b.txt = {0}", GitRep2b);
                    }
                    // Else if statement for if the input is 5, read entire text file, and display contents
                    else if (fileChoice == "5")
                    {
                        string[] GitRep3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_3a.txt = {0}", GitRep3a);
                    }
                    // Else if statement for if the input is 6, read entire text file, and display contents
                    else if (fileChoice == "6")
                    {
                        string[] GitRep3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");
                        System.Console.WriteLine("\nContents of GitRepositories_3b.txt = {0}", GitRep3b);
                    }
                    // Else statement to end the program if integer inputted by the user is lower than 1 or higher than 6
                    else
                        System.Environment.Exit(-1);
                    Console.WriteLine("\nSelect second file: for example 4 = GitRepositories_2b.txt");

                    // // While loop declared for input validation of the second file that's being chosen
                    while (true)
                    {
                        // User's inputted monitored
                        string fileChoice2 = Console.ReadLine();
                        // TryParse used in an infinite loop until a condition is met, which is validating user input is an integer
                        int num2 = -1;
                        if (!int.TryParse(fileChoice2, out num2))
                        {
                            // User asked to re-enter values corresponding to the files 
                            Console.WriteLine("Please enter a value between 1 and 6");
                            // While loop ended once the conditions are met, allowing a while loop to be declared later unaffected
                            break;
                        }
                        else
                        {
                            // If statement for if the input is 1, read entire text file, and display contents
                            if (fileChoice2 == "1")
                            {
                                string[] GitRep1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_1a.txt = {0}", GitRep1a);
                            }
                            // Else if statement for if the input is 2, read entire text file, and display contents
                            else if (fileChoice2 == "2")
                            {
                                string[] GitRep1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_1b.txt = {0}", GitRep1b);
                            }
                            // Else if statement for if the input is 3, read entire text file, and display contents
                            else if (fileChoice2 == "3")
                            {
                                string[] GitRep2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_2a.txt = {0}", GitRep2a);
                            }
                            // Else if statement for if the input is 4, read entire text file, and display contents
                            else if (fileChoice2 == "4")
                            {
                                string[] GitRep2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_2b.txt = {0}", GitRep2b);
                            }
                            // Else if statement for if the input is 5, read entire text file, and display contents
                            else if (fileChoice2 == "5")
                            {
                                string[] GitRep3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_3a.txt = {0}", GitRep3a);
                            }
                            // Else if statement for if the input is 6, read entire text file, and display contents
                            else if (fileChoice2 == "6")
                            {
                                string[] GitRep3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");
                                System.Console.WriteLine("\nContents of GitRepositories_3b.txt = {0}", GitRep3b);
                            }
                            // User asked to re-enter values corresponding to the files if input is out of range from 1 to 6 or a string
                            else if (fileChoice2 == "")
                                Console.WriteLine("Please input values between 1 and 6");

                            // != operator used to compare the second file to the first file
                            if (fileChoice2 != fileChoice)
                            {
                                // If the files are not equal then the outcome of the operator is TRUE
                                Console.WriteLine("\nThe files are not the same");
                            }
                            // Otherwise (else if statement) if the files are equal to each other
                            else if (fileChoice2 == fileChoice)
                            {
                                // Then they are equal, so the same file
                                Console.WriteLine("\nThe files are the same");
                            }
                            // Strings Yes and No assigned to 1 and 2 options, restarting or exiting the program
                            string Yes = "1";
                            string No = "2";
                            // User asked if they would like to read another file
                            Console.WriteLine("Would You Like To Read Another File, 1 = Yes, 2 = No");
                            // Strings from earlier outputted
                            Console.WriteLine(Yes);
                            Console.WriteLine(No);
                            
                            // User input monitored
                            string userInput = Console.ReadLine();
                            // If the user selects Yes, so inputting "1"
                            if (userInput == Yes)
                            {
                                // Program is called again, so restarting
                                Main();
                            }
                            // Else if statement, otherwise if the user selects "2", so No to end the program
                            else if (userInput == No)
                            {
                                // User's input monitored
                                string endChoice = Console.ReadLine();
                                int num3 = -1;
                                // TryParse used to validate so that the user input is only an integer
                                if (!int.TryParse(endChoice, out num3))
                                {
                                    // User asked to enter integers of only 1 and 2 for the corresponding options
                                    Console.WriteLine("Please enter only these values, 1 for Yes, 2 for No");
                                }
                                // User notified of the task being completed
                                Console.WriteLine("Task Completed, Program Terminated");
                                
                                // Program terminated
                                System.Environment.Exit(-1);
                            }
                        }
                    }
                }
            }
        }
    }
}
