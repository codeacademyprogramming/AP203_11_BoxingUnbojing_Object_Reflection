using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }


        public override string ToString()
        {
            return $"Brand: {Brand} -  Model: {Model}";
           
        }
    }
}
