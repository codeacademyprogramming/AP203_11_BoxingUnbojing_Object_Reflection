using System;
using System.Reflection;

namespace ReflectionLesson
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine(item.Name+" properties:");
                foreach (var prop in item.GetProperties())
                {
                    Console.WriteLine(prop.Name);
                }

                Console.WriteLine(item.Name + " fields:");
                foreach (var field in item.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    Console.WriteLine(field.Name);
                }
            }

            Human human = new Human()
            {
                Name = "Tofiq",
                Surname = "Abbasov",
                Age = 45
            };

            var type = human.GetType();

            Console.WriteLine("\n===================Human fields=====================\n");
            foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine(field.Name+" - "+field.GetValue(human));
            }

            Employee employee = new Employee(2000)
            {
                Age = 45,
            };

            double salary = 0;

            foreach (var item in employee.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if(item.Name == "_salary")
                {
                    salary = (double)item.GetValue(employee);
                }
            }

            Console.WriteLine("Salary: "+salary);

            Human[] humans = { employee, new Student(), new Student(), new Teacher { Salary = 400 } };

            Console.WriteLine(CalcSalaries(humans));

            Console.WriteLine("\n==================================\n");

            Console.WriteLine(GetIntFieldVal(employee.GetType(),employee,"_salary"));
        } 

        static double? GetIntFieldVal(Type type,Object obj,string memberName)
        {
            foreach (var item in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (item.Name == memberName)
                    return (double)item.GetValue(obj);
            }
            return null;
        }
        static double CalcSalaries(Human[] humans)
        {
            double sum = 0;

            foreach (var human in humans)
            {
                foreach (var prop in human.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    if (prop.Name == "Salary")
                        sum +=(double)prop.GetValue(human);
                }

                foreach (var field in human.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
                {
                    if (field.Name == "_salary")
                        sum += (double)field.GetValue(human);
                }
            }

            return sum;
        }

    }
}
