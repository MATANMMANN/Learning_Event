using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operation operation = new Operation();
            InputOutput IOcommands = new InputOutput();
            MathOperations mathOperations = new MathOperations();
            Parser parser = new Parser();


            IOcommands.PrintToScreen("Enter the first number of operation: ");
            string x = IOcommands.GetParmeter();
            int num1 = parser.ParseNumber(x);
            IOcommands.PrintToScreen("Enter the Second number of operation: ");
            string y = IOcommands.GetParmeter();
            int num2 = parser.ParseNumber(y);
            IOcommands.LineDown();

            mathOperations.EnterAllOpertaionsToEvent(ref operation);
            operation.Oper(num1, num2);
        }

        

       
        
    }
}
