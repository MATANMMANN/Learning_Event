using System;


namespace ConsoleApp5
{
    public class Parser
    {
        public int ParseNumber(string number)
        {
            InputOutput IOcommands = new InputOutput();
            while (true)
            {
                try
                {
                    return int.Parse(number);
                }
                catch (Exception)
                {
                    IOcommands.PrintToScreen("you need to Enter an integer number: ");
                    number = IOcommands.GetParmeter();
                }
            }
        }

    }
}
