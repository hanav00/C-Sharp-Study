namespace AttributePractice
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First Release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Park")]
    [History("Kim", version = 1.1, changes = "2023-10-05 Created Function() Method")]
    [History("Lee", version = 1.2, changes = "2023-10-06 Updated Function() Method")]
    class Project
    {
        public void Function()
        {
            Console.WriteLine("Working on a project");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Type type = typeof(Project);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("Project History . . .");

            foreach (Attribute attribute in attributes) {
                if (attribute is History history) {
                    Console.WriteLine($"Ver: {history.version}, Programmer: {history.GetProgrammer()}, Changes: {history.changes}");
                }
            }
        }
    }
}
