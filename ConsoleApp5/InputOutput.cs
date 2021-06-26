using System;


namespace ConsoleApp5
{
    public class InputOutput
    {
        
        public void PrintToScreen(string text)
        {
            Console.WriteLine(text);
        }

        public void LineDown()
        {
            Console.WriteLine();
        }

        public string GetParmeter()
        {
            return Console.ReadLine();
        }
    }
}
