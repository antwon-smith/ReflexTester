using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflexTester
{
    public class User : CharacterBank
   
    {
        public List<string> scoreTimes = new List<string>();
        public char choice;

        public void Run()
        {
            Welcome();
            GetCharacter();
            CharacterInput();
        }

        private void Welcome()
        {
          Console.WriteLine("Welcome to the Reflex Tester!\n\n You will be presented with a letter on screen. " +
          "Your goal is to type the matching letter as quickly as possible.\n\nYour response time will be shown to you.");
          Console.ReadKey();  //wait for the player to read instructions and press a key to begin
        }

        public void CharacterInput()
        {
            var playerInput = true;

            while (playerInput)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                char input = Console.ReadKey().KeyChar;
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;
                
                // Displays time in (seconds).(milliseconds).
                string elapsedTime = String.Format("{0:00}.{1:00}",
                ts.Seconds, ts.Milliseconds / 10);

                if (input == fromGetCharacter2)
                {
                    Console.WriteLine("\nYour response time is: " + elapsedTime + "seconds.");
                    scoreTimes.Add(elapsedTime);
                }
                else
                {
                    Console.WriteLine("\nYour input did not match the character provided.");
                }

                char choice;

                Console.WriteLine("Please select 'C' to continue, select 'T' to view your scores, or select 'Q' to quit.");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case 'c':
                        GetCharacter();
                        break;
                    case 't':
                        Console.WriteLine("\n\n****Your list of scores are:****\n");
                        foreach (var i in scoreTimes)
                        Console.WriteLine("\n" + i + " seconds\n");
                        break;
                    case 'q':
                        System.Environment.Exit(-1);
                        break;
                }

                

            }
            
        }
        public void GetUserChoice()
        {

        }



    }
}
