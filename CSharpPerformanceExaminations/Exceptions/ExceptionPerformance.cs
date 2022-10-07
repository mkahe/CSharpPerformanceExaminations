using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpPerformanceExaminations
{
    public class ExceptionPerformance : IPerformanceExamination
    {
        public void DoWork()
        {
            var iterations = 100;
            Console.WriteLine("Starting " + iterations.ToString() + " iterations...\n");

            var stopwatch = new Stopwatch();

            // Test exceptions
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 1; i <= iterations; i++)
            {
                try
                {
                    TestExceptions();
                }
                catch (Exception)
                {
                    // Do nothing
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Exceptions: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");

            // Test return codes
            stopwatch.Reset();
            stopwatch.Start();
            int retcode;
            for (int i = 1; i <= iterations; i++)
            {
                retcode = TestReturnCodes();
                if (retcode == 1)
                {
                    // Do nothing
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Return codes: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");

            Console.WriteLine("\nFinished.");
            Console.ReadKey();
        }
        
        void TestExceptions()
        {
            throw new Exception("Something bad happened");
        }

        int TestReturnCodes()
        {
            return 1;
        }
    }
}