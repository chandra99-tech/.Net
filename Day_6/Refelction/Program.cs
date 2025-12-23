using System.Reflection;

namespace Refelction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Users\IET\Desktop\.Net\Day_6\MyMath\bin\Debug\net8.0\MyMath.dll";

            Assembly asm = Assembly.LoadFrom(assemblyPath);

            Type[] allType = asm.GetTypes();

            for (int i = 0; i < allType.Length; i++)
            {
                Type type = allType[i];

                Object dynamicallyCreatedObject = asm.CreateInstance(type.FullName);

                string methodSignature = "";

                MethodInfo[] allMethod = type.GetMethods();
                
                for (int j = 0; j < allMethod.Length; j++)
                {
                    MethodInfo method = allMethod[j];

                    methodSignature = method.ReturnType.ToString()+" "+method.Name+"(";

                    ParameterInfo[] parameters = method.GetParameters();
                    for (int k = 0; k < parameters.Length; k++)
                    {
                        ParameterInfo param = parameters[k];

                        methodSignature = methodSignature+param.ParameterType.ToString()+" "+param.Name+",";
                    }

                    Object[] inputValue = new object[parameters.Length];

                    for (int k = 0;k < parameters.Length; k++)
                    {
                        ParameterInfo para = parameters[k];
                        Console.WriteLine($"Enter Value for {para.Name} of type = {para.ParameterType.ToString()}");

                        inputValue[k] = Convert.ChangeType(Console.ReadLine(), para.ParameterType);
                    }

                    methodSignature = methodSignature.TrimEnd(',') + ")";
                    Console.WriteLine(methodSignature);

                    Object? result = type.InvokeMember(
                        method.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        inputValue
                        );

                    Console.WriteLine($"{method.Name} = {result}");
                }
            }
        }
    }
}
