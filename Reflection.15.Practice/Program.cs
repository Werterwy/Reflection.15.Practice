using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection._15.Practice
{
    class MyClass
    {
        private int privateField;
        public int PublicField;

        public MyClass() { }

        public MyClass(int value)
        {
            privateField = value;
            PublicField = value;
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private Method invoked");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public Method invoked");
        }

    }

    public class Program
    {


        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            MyClass myObject = (MyClass)Activator.CreateInstance(myClassType);

            // 1.Исследование Типа:

            /* // Имя класса
             Console.WriteLine($"Имя класса: {myClassType.Name}");
             Console.WriteLine("");

             // Конструкторы
             ConstructorInfo[] constructors = myClassType.GetConstructors();
             Console.WriteLine("Конструкторы:");
             foreach (ConstructorInfo constructor in constructors)
             {
                 Console.WriteLine($"{constructor.Name} - {constructor.Attributes}");
             }
             Console.WriteLine("");

             // Поля и свойства
             FieldInfo[] fields = myClassType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
             PropertyInfo[] properties = myClassType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
             Console.WriteLine("Поля и свойства:");
             foreach (FieldInfo field in fields)
             {
                 Console.WriteLine($"{field.FieldType.Name} {field.Name} - {field.Attributes}");
             }
             foreach (PropertyInfo property in properties)
             {
                 Console.WriteLine($"{property.PropertyType.Name} {property.Name} - {property.Attributes}");
             }
             Console.WriteLine("");

             // Методы
             MethodInfo[] methods = myClassType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
             Console.WriteLine("Методы:");
             foreach (MethodInfo method in methods)
             {
                 Console.WriteLine($"{method.ReturnType.Name} {method.Name} - {method.Attributes}");
             }*/

            // 2.Создание Экземпляра:

            /*Console.WriteLine($"Создан экземпляр MyClass: {myObject != null}");*/

            // 3.Манипулирование Объектом:

            /*  try
              {
                  PropertyInfo publicFieldProperty = myClassType.GetProperty("PublicField");
                  if (publicFieldProperty != null)
                  {
                      publicFieldProperty.SetValue(myObject, 42);
                  }
                  else
                  {
                      Console.WriteLine("Свойство PublicField не найдено.");
                  }

                  MethodInfo publicMethod = myClassType.GetMethod("PublicMethod");
                  if (publicMethod != null)
                  {
                      publicMethod.Invoke(myObject, null);
                  }
                  else
                  {
                      Console.WriteLine("Метод PublicMethod не найден.");
                  }

                  PropertyInfo updatedPublicFieldProperty = myClassType.GetProperty("PublicField");
                  if (updatedPublicFieldProperty != null)
                  {
                      Console.WriteLine($"PublicField после изменений: {updatedPublicFieldProperty.GetValue(myObject)}");
                  }
                  else
                  {
                      Console.WriteLine("Свойство PublicField не найдено для проверки изменений.");
                  }
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Произошла ошибка: {ex.Message}");
              }*/

            // 4.Расширенное Исследование:

            // Получение приватного метода
            MethodInfo privateMethod = myClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);

            if (privateMethod != null)
            {
                privateMethod.Invoke(myObject, null);
            }
        }
    }
}
