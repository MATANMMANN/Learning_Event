﻿using System;

namespace ConsoleApp5
{
    public delegate void EventOperation(int x, int y);
    public class Operation
    {
    

        public event EventOperation abc;

        public void Oper(int x,int y)
        {
            if (abc != null)
            {
                abc(x, y);
            }
            else
            {
                Console.WriteLine("you not reg");
            }
        }
    }
}
