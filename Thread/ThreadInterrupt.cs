namespace ThreadPractice
{
    class MainApp
    {
        static void DoWork(int n)
        {
            try {
                Console.WriteLine("Thread is starting.");
                int count = 0;
                while (true) {
                    Thread.Sleep(1000);

                    count++;
                    Console.WriteLine($"{count} sec");

                    if (count == n) {
                        Thread.CurrentThread.Interrupt();
                        Console.WriteLine($"3. Thread State: {Thread.CurrentThread.ThreadState}");
                    }
                }
            }
            catch (ThreadInterruptedException) {
                Console.WriteLine("Thread was interrupted.");

                Console.WriteLine($"4. Thread State: {Thread.CurrentThread.ThreadState}");
            }
        }

        static void Main()
        {
            Thread thread = new Thread(() => DoWork(5));
            Console.WriteLine($"1. Thread State: {thread.ThreadState}");

            thread.Start();
            Console.WriteLine($"2. Thread State: {thread.ThreadState}");

            thread.Join();
            Console.WriteLine($"5. Thread State: {thread.ThreadState}");

            try {
                thread.Start();
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
