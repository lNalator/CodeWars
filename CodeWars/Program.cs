using System.Collections.Generic;
using System.Linq;
using System;
using CodeWars.Katas.Tests;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string input = string.Empty;

    Start:
        {
            if (input == null || input == string.Empty)
            {
                Console.WriteLine("Please enter the name of the kata you want to execute...");
                input = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Unknown kata. \n" +
                    " please enter the name of the kata you want to execute...");
                input = Console.ReadLine();
            }
        }
        switch (input)
        {
            case "in array":
                {
                    //TODO - Add input control for tests
                    //  (make it so user can input what he want to test)
                    InArray_Test.Tests();
                    break;
                }
            case "repeat adjacent":
                {
                    //TODO - Add input control for tests
                    //  (make it so user can input what he want to test)
                    RepeatAdjacent_Test.Tests();
                    break;
                }
            case "product fib":
                {
                    //TODO - Add input control for tests
                    //  (make it so user can input what he want to test)
                    ProductFib_Test.Tests(4895);
                    break;
                }
            case "deadfish":
                {
                    //TODO - Add input control for tests
                    //  (make it so user can input what he want to test)

                    Deadfish_Test.Tests("iiisdosodddddiso");
                    break;
                }
            default:
                {
                    goto Start;
                }

        }
    }
}








//See https://aka.ms/new-console-template for more information
