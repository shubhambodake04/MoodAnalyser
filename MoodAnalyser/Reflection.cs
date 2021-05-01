using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    class Reflection
    {
        public static void ReflectionDemo()
        {
            Type type = Type.GetType("MoodAnalyser.MoodAnalyserFactory");
            Console.WriteLine(type.Name);
            Console.WriteLine(type.FullName);
            Console.WriteLine("Methods in customerInfo class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("Properties in CustomerInfo class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine("Constructors in CustomerInfo class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }
    }
}
