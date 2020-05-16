using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class CodecString
    {

        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in strs)
            {
                sb.Append(item).Append("#");
            }
            return sb.ToString().TrimEnd('#');
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            if (s == null) return null;
            if (s.Length == 0) return new List<string>() { ""};

            IList<string> output = s.Split("#");
            return output;
        }
    }

    class Quest271EncodeandDecodeStrings
    {

        public static void Testing()
        {
            CodecString cs = new CodecString();
            IList<string> inputArray = new List<string>() { };
            var input = cs.encode(inputArray);
            var output = cs.decode(input);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
