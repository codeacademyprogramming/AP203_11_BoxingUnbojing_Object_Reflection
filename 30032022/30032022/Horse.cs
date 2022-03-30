using _30032022.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Horse:Animal
    {
        static int _totalCount;
        public static int TotalCount { get => _totalCount; }

        public Horse()
        {
            _totalCount++;
        }
        public HorseSort Sort { get; set; }
    }
}
