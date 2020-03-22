using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class ArrayAndStraings
    {
        public static void HashtableDemo()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            foreach (DictionaryEntry item in openWith)
            {
                Console.WriteLine("key ={0} , value ={1}", item.Key, item.Value);
            }

            Console.WriteLine(openWith["txt"]);

        }

        public static void ArrayListDemo()
        {
            string[] fileType = { "txt1", "txt2", "txt3", "txt4" };
            string[] fileName = { "notepad.exe", "notepad.exe", "notepad.exe", "notepad.exe" };

            ArrayList allList = new ArrayList();

            foreach (var item in fileType)
            {
                allList.Add(item);
            }

            foreach (var item in fileName)
            {
                allList.Add(item);
            }

            foreach (var item in allList)
            {
                Console.WriteLine(item);
            }
        }

        public static bool CheckIfStringHasUniqueChar(string Str)
        {
            bool isUnique = false;


            return isUnique;
        }

    }
}
