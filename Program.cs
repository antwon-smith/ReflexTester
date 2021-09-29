using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReflexTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Reflex Tester!\n\n You will be presented with a letter on screen. " +
                "Your goal is to type the matching letter as quickly as possible.\n\nYour response time will be shown to you.");
            Console.ReadKey();  //wait for the player to read instructions and press a key to begin

            var user = new User();
            user.Run();

            var getcharacter = new GetCharacter();
            
        }

    }
}
