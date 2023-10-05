using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ReflectionPractice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Assembly 만들기
            AssemblyBuilder assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            // Module 만들기
            ModuleBuilder module = assembly.DefineDynamicModule("CalculatorModule");

            // Class 만들기
            TypeBuilder type = module.DefineType("CalculatorClass");

            // Method 만들기
            MethodBuilder method = type.DefineMethod(
                "Add",
                MethodAttributes.Public,
                typeof(int), // return type
                new Type[] { typeof(int), typeof(int) }); // parameter types

            // Method 완성시키기
            ILGenerator generator = method.GetILGenerator();
            generator.Emit(OpCodes.Ldarg_1); // args[0]
            generator.Emit(OpCodes.Ldarg_2); // args[1]

            generator.Emit(OpCodes.Add); // added

            generator.Emit(OpCodes.Ret); // return

            // Type 완성시키기
            Type dynamicType =  type.CreateType();

            // 동적 인스턴스 생성
            object instance = Activator.CreateInstance(dynamicType);
            MethodInfo calculate = dynamicType.GetMethod("Add");
            Console.WriteLine(calculate.Invoke(instance, new object[] { 5, 7 }));
        }
    }
}
