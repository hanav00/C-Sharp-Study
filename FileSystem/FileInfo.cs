namespace FilePractice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            string[] directoriesArray = new string[]
            {
                currentDirectory,
                parentDirectory
            };

            foreach (string directory in directoriesArray) {

                Console.WriteLine($"### {directory} Directory Information");

                Console.WriteLine("--- Directories ---");
                var directories = (from dir in Directory.GetDirectories(directory)
                                   let info = new DirectoryInfo(dir)
                                   select new
                                   {
                                       Name = info.Name,
                                       Attributes = info.Attributes
                                   }).ToList();
                if (directories.Count > 0 ) {
                    foreach (var d in directories) {
                        Console.WriteLine($"{d.Name} : {d.Attributes}");
                    }
                }
                else {
                    Console.WriteLine("No Directory.");
                }

                Console.WriteLine("--- Files ---");
                var files = (from file in Directory.GetFiles(directory)
                             let info = new FileInfo(file)
                             select new
                             {
                                 Name = info.Name,
                                 FileSize = info.Length,
                                 Attributes = info.Attributes
                             }).ToList();
                if (files.Count > 0 ) {
                    foreach (var f in files) {
                        Console.WriteLine($"{f.Name} ({f.FileSize} bytes) : {f.Attributes}");
                    }
                }
                else {
                    Console.WriteLine("No Files."); 
                }

                Console.WriteLine();
            }
        }
    }
}
