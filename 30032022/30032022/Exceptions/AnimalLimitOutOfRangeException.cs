using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022.Exceptions
{
    internal class AnimalLimitOutOfRangeException:Exception
    {
        public AnimalLimitOutOfRangeException(string msg):base(msg)
        {

        }
    }
}
