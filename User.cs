using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflexTester
{
    public class User //: CharacterBank (initially used inheritance to access members of CharacterBank class.  Switched to instantiation.)
   
    {
        public List<string> scoreTimes = new List<string>();
        public char choice;
        public CharacterBank Bank = new CharacterBank();

        public void Run()
        {
            Welcome();
            //GetCharacter();  Previously ran GetCharacter() here, but moved it to the switch statement below
            CharacterInput();
        }

        private void Welcome()
        {
            Console.WriteLine(@"*********************************************************************
        ____       __ _             _____         _                 
       |  _ \ ___ / _| | _____  __ |_   _|__  ___| |_ ___ _ __      
  _____| |_) / _ \ |_| |/ _ \ \/ /   | |/ _ \/ __| __/ _ \ '__|____ 
 |_____|  _ <  __/  _| |  __/>  <    | |  __/\__ \ ||  __/ | |_____|
       |_| \_\___|_| |_|\___/_/\_\   |_|\___||___/\__\___|_|        
                                                                    
*********************************************************************");
            Console.WriteLine("\n\nWelcome to Reflex Tester!\n\nPurpose:\n\tTest your reaction times.\n\nHow it works:\n\t- A letter will be presented on screen.\n\t- Once the letter appears, type the corresponding letter on your keyboard.\n\t- After you input the correct character, your reaction time will be shown.\n\t- Your scores are stored and can be viewed by pressing 'T' when prompted.\n\nWhen you are ready, press any key to begin!");
            Console.ReadKey();
        }

        public void CharacterInput()
        {
            var playerInput = true;

            while (playerInput)
            {
                char choice;

                Console.WriteLine("\nPlease select 'C' to get a character, select 'T' to view your scores, or select 'Q' to quit.");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case 'c':
                        Bank.Countdown();  //initiates countdown before letter is shown
                        Bank.GetCharacter();  //gets a random character from the character bank
                        Stopwatch stopWatch = new Stopwatch(); 
                        stopWatch.Start();
                        char input = Console.ReadKey().KeyChar;
                        stopWatch.Stop();
                        // Get the elapsed time as a TimeSpan value.
                        TimeSpan ts = stopWatch.Elapsed;

                        // Displays time in (seconds).(milliseconds).
                        string elapsedTime = String.Format("{0:00}.{1:00}",
                        ts.Seconds, ts.Milliseconds / 10);

                        // Check if input matches the character given, if so, give response time.  Otherwise, write another message.
                        if (input == Bank.fromGetCharacter2)
                        {
                            Console.WriteLine("\nYour response time is: " + elapsedTime + " seconds.");
                            scoreTimes.Add(elapsedTime);
                        }
                        else
                        {
                            Console.WriteLine("\nYour input did not match the character provided.");
                        }
                        break;
                    case 't':
                        Console.WriteLine("\n\n****Your list of scores are:****\n");
                        foreach (var i in scoreTimes)
                            Console.WriteLine("\n" + i + " seconds\n");
                        break;
                    case 'q':
                        Environment.Exit(-1);
                        break;
                }
         
            }
            
        }

    }
}
