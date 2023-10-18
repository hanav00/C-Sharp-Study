using System;
using System.Reflection;

public class Calculator
{
    [Test]
    public int Add(int a, int b) => a + b;

    [Test]
    public int Subtract(int a, int b) => a - b;
}

public class Calculator2
{
    [Test]
    public int Add(int a, int b) => a + b + ((a > b) ? 1 : 0);
    [Test]
    public int Subtract(int a, int b) => a - b + ((a < b) ? 1 : 0);
}

public class UnitTestGenerator
{
    public void GenerateTests(Type type)
    {
        Random random = new Random();
        MethodInfo[] methods = type.GetMethods();

        for (int testCase = 1; testCase <= 5; testCase++) {
            foreach (MethodInfo method in methods) {
                if (method.GetCustomAttributes(typeof(TestAttribute), false).Length > 0) {

                    // Create an instance of the class to test
                    object instance = Activator.CreateInstance(type);

                    // Test data
                    int a = random.Next(1, 100);
                    int b = random.Next(1, 100);
                    int expectedResult = 0;
                    if (method.Name == "Add") {
                        expectedResult = a + b;
                    }
                    else if (method.Name == "Subtract") {
                        expectedResult = a - b;
                    }

                    object result = method.Invoke(instance, new object[] { a, b });

                    if (result.Equals(expectedResult)) {
                        Console.WriteLine($"[{method.Name, -8}] {testCase} Test : Passed.");
                    }
                    else {
                        Console.WriteLine($"[{method.Name, -8}] {testCase} Test : Failed. (a={a}, b={b}, expected={expectedResult}, result={result})");
                    }
                }
            }
        }
    }
}

[AttributeUsage(AttributeTargets.Method)]
public class TestAttribute : Attribute
{

}

class Program
{
    static void Main()
    {
        UnitTestGenerator testGenerator = new UnitTestGenerator();

        Type calculatorType = typeof(Calculator);
        testGenerator.GenerateTests(calculatorType);

        Type calculatorType2 = typeof(Calculator2);
        testGenerator.GenerateTests(calculatorType2);
    }
}
