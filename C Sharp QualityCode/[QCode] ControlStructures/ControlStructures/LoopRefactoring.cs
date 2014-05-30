using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlStructures
{
    class LoopRefactoring
    {
        void Refactor()
        {
            var array = new List<int>();
            //Magic numbers.
            int length = 100;
            int expectedValue = 50;
            int divider = 10;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
                if ((i % divider == 0) && (array[i] == expectedValue))
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}