using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022.Exceptions
{
    internal class AnimalIsNotAllowedException:Exception
    {
        public AnimalIsNotAllowedException(string msg):base(msg)
        {
                
        }
    }
}
