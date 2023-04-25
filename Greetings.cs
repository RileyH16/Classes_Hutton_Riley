using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Hutton_Riley
{
    class Greetings
    {

        public void Welcome()
        {
            //Welcomes the user
            Console.WriteLine("Hello Traveler, Welcome!");
        }

        public void Hello(string name)
        {
            //Thanks the user for joining us
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
