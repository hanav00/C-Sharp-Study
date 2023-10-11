using System;
using System.Threading;

public class Program
{
    private static int counter = 0;
    private static object lockObject = new object();

    public static void Main()
    {
        Thread t1 = new Thread(IncrementCounter);
        Thread t2 = new Thread(IncrementCounter);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter Value: " + counter);
    }

    public static void IncrementCounter()
    {
        for (int i = 0; i < 100000; i++) {
            lock (lockObject) 
            {
                counter++; 
            }
        }
    }
}
