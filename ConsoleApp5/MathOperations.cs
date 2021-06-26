using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class MathOperations
    {
        InputOutput IOcommands = new InputOutput();

        public void EnterAllOpertaionsToEvent(ref Operation operation)
        {

            operation.abc += new EventOperation(Mul);
            operation.abc += new EventOperation(Plus);
            operation.abc += new EventOperation(Power);
            operation.abc += new EventOperation(Divide);
            operation.abc += new EventOperation(Minus);
        }

        public void Mul(int x, int y)
        {
            IOcommands.PrintToScreen(string.Format("{0} * {1} = {2}", x, y, x * y));
        }

        public void Plus(int x, int y)
        {
            IOcommands.PrintToScreen(string.Format("{0} + {1} = {2}", x, y, x + y));
        }

        public void Power(int x, int y)
        {
            IOcommands.PrintToScreen(string.Format("{0} ^ {1} = {2}", x, y, Math.Pow(x,y)));
        }
        public void Divide(int x, int y)
        {
            IOcommands.PrintToScreen(string.Format("{0} / {1} = {2}", x, y, Convert.ToDouble(x) / Convert.ToDouble(y)));
        }

        public void Minus(int x, int y)
        {
            IOcommands.PrintToScreen(string.Format("{0} - {1} = {2}", x, y, x-y));
        }
    }
}
