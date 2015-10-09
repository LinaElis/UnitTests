using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class TestClass2
    {
        public bool result;

        public void bigger(int number1, int number2)
        {
            if (number1 > number2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
    }
}
