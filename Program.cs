using System;
using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Einstein Riddle:");
        Stopwatch sw = new Stopwatch();
        sw.Start();

        EinsteinRiddleSolver solver = new EinsteinRiddleSolver();
        // solver.Solve_BruteForce_01();   // slow :-(
        solver.Solve_BruteForce_02();      // fast :-)

        sw.Stop();
        Console.WriteLine("[{0} msecs]", sw.ElapsedMilliseconds);
    }
}
