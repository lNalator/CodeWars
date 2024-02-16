internal class Program
{
    public static void ProgramMain()
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
            
            default:
                {
                    //TODO - Add NUnit test console control based on the input
                    goto Start;
                }
        }
    }
}
