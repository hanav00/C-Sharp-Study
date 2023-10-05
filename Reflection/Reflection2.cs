using System.Reflection;

namespace ReflectionPractice
{
    class Inventory
    {
        private string product;
        private int count;
        public Inventory()
        {
            product = "";
            count = 0;
        }
        public Inventory(string product, int count)
        {
            this.product = product;
            this.count = count;
        }
        public void Print()
        {
            Console.WriteLine($"{product}: {count}");
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++) {
                string instanceType = (i % 2 == 0) ? "ReflectionPractice.Inventory" : "NothingHere";

                Type type = Type.GetType(instanceType);

                if (type == typeof(ReflectionPractice.Inventory)) {
                    MethodInfo methodInfo = type.GetMethod("Print");
                    PropertyInfo productProperty = type.GetProperty("Product");
                    PropertyInfo countProperty = type.GetProperty("Count");

                    object inventory = Activator.CreateInstance(type, "Grape", 12);
                    methodInfo.Invoke(inventory, null);

                    inventory = Activator.CreateInstance(type);
                    productProperty.SetValue(inventory, "Pear", null);
                    countProperty.SetValue(inventory, 3, null);

                    Console.WriteLine($"{productProperty.GetValue(inventory, null)}: {countProperty.GetValue(inventory, null)}");
                }
                else {
                    Console.WriteLine("^__^");
                }
            }
            
        }
    }
}
