using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class StringPossibleSolution
    {
        public void PrintAllPossibleSubsetDemo()
        {
            PrintAllPossibleSubset("ABC");
        }

        private void PrintAllPossibleSubset(string str)
        {
            HelperPrint(str, "", 0);
        }

        private void HelperPrint(string str, string temp, int index)
        {

            if (index == str.Length)
            {
                Console.WriteLine(temp + "");
                return;
            };
            HelperPrint(str, temp, index + 1);
            HelperPrint(str, temp + str[index], index + 1);
        }
    }
}
