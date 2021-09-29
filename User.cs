using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflexTester
{
    public class User
    {
        public void CharacterInput()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string input = Console.ReadLine();
            input = input.ToLower();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Displays time in (seconds).(milliseconds).
            string elapsedTime = String.Format("{2:00}.{3:00}", 
            ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
        public void Run()
        {
            Welcome();
            LoopChar();
        }
        private void Welcome()
        {
            Console.WriteLine("Welcome to the Reflex Tester!\n\n You will be presented with a letter on screen. " +
                "Your goal is to type the matching letter as quickly as possible.\n\nYour response time will be shown to you.");
            Console.ReadKey();  //wait for the player to read instructions and press a key to begin
        }
        private void LoopChar()
        {
            
        }
    }
}
