using _30032022.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Sheep:Animal
    {
        public static int TotalCount { get; private set; }

        public Sheep()
        {
            TotalCount++;
        }
        public SheepType Type { get; set; }
    }
}
