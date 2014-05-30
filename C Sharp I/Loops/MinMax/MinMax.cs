//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class MinMax
    {
        static void Main(string[] args)
        {  
            int n = int.Parse(Console.ReadLine());
            int curNum = int.Parse(Console.ReadLine());
            int minVal = curNum; 
            int maxVal = curNum;
            for (int i = 1; i < n; i++)             
            {
                curNum = int.Parse(Console.ReadLine());                                             
                if (curNum < minVal)
                {
                    minVal = curNum;
                }                         
                if (maxVal < curNum)
                {
                    maxVal = curNum;
                }
            }
            Console.WriteLine("Min value is {0}, and Max value is {1}",minVal,maxVal);
        }
    }
}
