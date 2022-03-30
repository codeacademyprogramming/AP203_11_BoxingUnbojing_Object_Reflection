using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLesson
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname;
        private int _age;
        public int Age
        {
            set =>_age= value;
        }
    }
}
