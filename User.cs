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
    }
}
