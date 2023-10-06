namespace FilePractice
{
    class FileDirectoryCreator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# This is a File or Directory Creator. You can create a file or a directory on your local computer.");

            Console.Write("What do you want to create?\nFile/Directory: ");
            string? type = Console.ReadLine();
            // Check if the input type is valid (File or Directory)
            while (type != "File" && type != "Directory") {
                Console.WriteLine("Invalid type. Please enter 'File' or 'Directory'.");
                Console.Write("File/Directory: ");
                type = Console.ReadLine();
            }

            Console.Write("Where do you want to create?\nLocation: ");
            string? location = Console.ReadLine();
            // Check if the input location is valid
            while (!Directory.Exists(location)) {
                Console.WriteLine("Invalid path. Please enter an existing path.");
                Console.Write("Location: ");
                location = Console.ReadLine();
            }

            if (!location.EndsWith("\\")) {
                location += "\\";
            }

            Console.Write($"{type} Name: ");
            string? name = Console.ReadLine();
            // Check if the input name is valid
            if (string.IsNullOrWhiteSpace(name)) {
                Console.WriteLine("Invalid name. Please enter a name.");
                Console.Write($"{type} Name: ");
                name = Console.ReadLine();
            }

            string path = location + name;

            if (Directory.Exists(path) || File.Exists(path)) {
                Console.WriteLine($"The name of the {type} already exist.\nDo you want to update last write time?\nPress any keys to continue.\nPress N if you want to cancel.");
                string? answer = Console.ReadLine();

                try {
                    if (answer == "N") {
                        return;
                    }
                    if (type == "File") {
                        File.SetLastWriteTime(path, DateTime.Now);
                    }
                    else if (type == "Directory") {
                        Directory.SetLastWriteTime(path, DateTime.Now);
                    }
                    else {
                        throw new Exception("An error occurred.");
                    }
                    Console.WriteLine($"Updated last write time of {name} at {path} ({type})");
                }
                catch (Exception e) {
                    Console.WriteLine($"An error occurred: {e.Message}");
                }
            }
            else {
                Console.WriteLine($"Do you want to create a {type} at {location}?\nPress any keys to continue.\nPress N if you want to cancel.");
                string? answer = Console.ReadLine();

                try {
                    if (answer == "N") {
                        return;
                    }
                    if (type == "File") {
                        File.Create(path).Close();
                    }
                    else if (type == "Directory") {
                        Directory.CreateDirectory(path);
                    }
                    else {
                        Console.WriteLine("Error occurred.");
                        return;
                    }
                    Console.WriteLine($"Created {name} at {path} ({type})");
                }
                catch (Exception e) {
                    Console.WriteLine($"An error occurred: {e.Message}");
                }
            }
        }
    }
}
