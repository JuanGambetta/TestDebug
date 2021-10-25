using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestAndDebug
{
    public class FechaUtils
    {
        public static Boolean FechaIsValid(String fecha)
        {
            if (fecha.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}