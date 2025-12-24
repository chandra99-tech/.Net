using BonaventureSystemsAttribute;
using System.Reflection;
using System.Text.Json.Serialization;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\.Net\Demo\31Demo\EmpLib\bin\Debug\net8.0\EmpLib.dll";

            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] allType = asm.GetTypes();
            for (int i = 0; i < allType.Length; i++)
            {
                Type type = allType[i];

                Attribute[] allAttribute = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttribute.Length; j++)
                {
                    Attribute atr = allAttribute[j];
                    if (atr is Class1)
                    {
                        Class1 bvsAttr = atr as Class1;

                        Console.WriteLine($"Class {type.Name} is developed by {bvsAttr.DeveloperName} of (c) {bvsAttr.CompanyName}");
                    }

                    if (atr is JsonSerializableAttribute)
                    {
                        Console.WriteLine($"Class {type.Name} is marked as Serializable");
                    }
                }
            }
        }
    }
}
