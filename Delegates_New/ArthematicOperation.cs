using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_New
{
    public delegate int DelgateOperation(int x, int y);
    public class ArthematicOperation
    {
        public static int Addition(int a, int b)
        {
            return a+b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
