using System;

namespace PowerTable
{
    class Program
    {
        static void Main(string[] args)
        {

            //handle all into
            ProgramIntro();

            static void ProgramIntro()
            {
                bool loopProgram = true;
                while (loopProgram)
                {
                    //Number from User
                    Console.WriteLine("Please enter a number");
                    int x = int.Parse(Console.ReadLine()); //User Input
                    CountUp(x);


                    Console.WriteLine("Do you want to continue? y/n");
                    while (true)
                    {
                        string continueResults = Console.ReadLine();

                        if (continueResults == "y")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (continueResults == "n")
                        {
                            loopProgram = false;
                            Console.WriteLine("Goodbye, have a great day!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input");
                        }
                        
                    }

                    //Power Table Structure and Math - Done Here!
                    static void CountUp(int x)
                    {
                        Console.WriteLine($"Number\tSquared\tCubed");
                        Console.WriteLine($"======\t======\t======");
                        for (int i = 1; i <= x; i++)
                        {
                            Console.WriteLine($"{i}\t{Squard(i)}\t{Cube(i)}");
                        }


                        static int Squard(int x)
                        {
                            return x * x;
                        }


                        static int Cube(int x)
                        {
                            return x * x * x;
                        }
                    }
                }
            }
        }
    }
}
