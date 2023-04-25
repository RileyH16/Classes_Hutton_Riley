using System;

namespace Classes_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the greetings object
            Greetings greetings = new Greetings();
            //Call the welcome method from the greetings object
            greetings.Welcome();

            //Asks the user for their name
            Console.WriteLine("What is your name, good sir?");
            //Stores the name
            string userName = Console.ReadLine();

            greetings.Hello(userName);
        }
    }
}
