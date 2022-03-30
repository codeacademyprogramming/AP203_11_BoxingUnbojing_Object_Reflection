using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022.Exceptions
{
    internal class SheepCountOutOfRangeException:Exception
    {
        public SheepCountOutOfRangeException(string msg):base(msg)
        {

        }
    }
}
