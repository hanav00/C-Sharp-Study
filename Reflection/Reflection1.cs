using System.Collections;
using System.Reflection;

namespace ReflectionPractice
{
    class MainApp
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("----- Interfaces -----");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces) {
                Console.WriteLine($"Name: {i.Name}");
            }
        }
        static void PrintFields(Type type)
        {
            Console.WriteLine("----- Fields -----");

            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo f in fields) {
                string accessLevel = "protected";
                if (f.IsPublic) {
                    accessLevel = "Public";
                }
                else if (f.IsPrivate) {
                    accessLevel = "Private";
                }
                Console.WriteLine($"Access: {accessLevel}, Type: {f.FieldType.Name}, Name: {f.Name}");
            }
        }
        static void PrintMethods(Type type)
        {
            Console.WriteLine("----- Methods -----");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo m in methods) {
                Console.Write($"ReturnType: {m.ReturnType.Name}, Name: {m.Name}, Parameter: ");

                ParameterInfo[] parameters = m.GetParameters();
                for (int i=0; i<parameters.Length; i++) {
                    Console.Write(parameters[i].ParameterType.Name);
                    if (i < parameters.Length - 1) {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void PrintProperties(Type type)
        {
            Console.WriteLine("----- Properties -----");

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo p in properties) {
                Console.WriteLine($"Type: {p.PropertyType.Name}, Name: {p.Name}");
            }
        }
        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();
            Console.WriteLine(type.Name); // Int32

            PrintInterfaces(type);
            PrintFields(type);
            PrintMethods(type);
            PrintProperties(type);

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            Inventory inventory = new Inventory();
            Type type2 = inventory.GetType();
            Console.WriteLine(type2.Name); // Inventory

            PrintInterfaces(type2);
            PrintFields(type2);
            PrintMethods(type2);
            PrintProperties(type2);

            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n");

            ArrayList list = new ArrayList();
            Type type3 = list.GetType();
            Console.WriteLine(type3.Name); // ArrayList

            PrintInterfaces(type3);
            PrintFields(type3);
            PrintMethods(type3);
            PrintProperties(type3);
        }
    }

    class Inventory
    {
        public string? Product { get; set; }
        public int Count { get; set; }
    }

}
