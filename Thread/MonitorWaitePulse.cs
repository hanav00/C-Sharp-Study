using System;
using System.Threading;

public class Program
{
    private static string message = "";
    private static object lockObject = new object();

    public static void Main()
    {
        Thread t1 = new Thread(Receiver);
        Thread t2 = new Thread(Sender);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }

    public static void Sender()
    {
        for (int i = 0; i < 3; i++) {
            lock (lockObject) {
                Console.WriteLine("Sender is typing a message...");
                Thread.Sleep(1000);

                message = "Message " + (i + 1);
                Console.WriteLine("Sender sent: " + message);
                Thread.Sleep(500);

                Console.WriteLine("Pulsing Receiver...");
                Monitor.Pulse(lockObject); Thread.Sleep(500);

                Console.WriteLine("Sender is waiting Receiver to receive the message...");
                Monitor.Wait(lockObject); Thread.Sleep(500);
            }
        }
    }

    public static void Receiver()
    {
        for (int i = 0; i < 3; i++) {
            lock (lockObject) {
                Console.WriteLine("Receiver is waiting for a message...");
                Monitor.Wait(lockObject); Thread.Sleep(500);

                Console.WriteLine("Receiver received: " + message);
                Thread.Sleep(500);

                Console.WriteLine("Pulsing Sender...");
                Monitor.Pulse(lockObject); Thread.Sleep(500);
            }
        }
    }
}
