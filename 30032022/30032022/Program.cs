using System;
using System.Reflection;

namespace _30032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BoxingUnboxing
            Car car = new Car();
            car.Brand = "Mercedes";
            car.Model = "E200";

            object carObj = car;

            int num1 = 5;
            object numObj = num1;


            //int? num2 = numObj as int?;
            int num2 = (int)numObj;

            #endregion

           
        }
    }
}
