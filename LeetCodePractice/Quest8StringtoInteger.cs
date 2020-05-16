using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Quest8StringtoInteger
    {
        public static void MyAtoi()
        {
            Console.WriteLine(MyAtoi("-91283472332"));
        }
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            string[] incomingData = str.Split();
            long parsedResult = 0;
            long.TryParse(incomingData[0], out parsedResult);
            if (parsedResult > int.MaxValue)
            {
                parsedResult = int.MaxValue;
            }
            else if (parsedResult < int.MinValue)
            {
                parsedResult = int.MinValue;
            }
            return (int)parsedResult;
        }
    }
}
