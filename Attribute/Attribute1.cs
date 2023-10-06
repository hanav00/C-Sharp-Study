using System.Runtime.CompilerServices;

namespace AttributePractice
{
    class Add
    {
        [Obsolete("This is WrongMethod. Please use CorrectMethod.")]
        public void WrongMethod(int a, int b)
        {
            Console.WriteLine(a + b + 0.1);
        }
        public void CorrectMethod(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line: {line}) {member}: {message}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Add add = new Add();
            add.WrongMethod(13, 24);
            add.CorrectMethod(13, 24);

            Trace.WriteLine("Caller !");
        }
    }
}
