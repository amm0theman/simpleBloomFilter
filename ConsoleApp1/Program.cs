using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            dictionaryLoader myDictionary = new dictionaryLoader();
            myDictionary.printDictionary();
        }

        class bloomFilter
        {
            Boolean[] bloomArray;

            public bloomFilter(int count)
            {
                bloomArray = new bool[count];
            }

            public void addValue(string value)
            {
               var characterBytes = ASCIIEncoding.ASCII.GetBytes(value);
               var hash = new MD5CryptoServiceProvider().ComputeHash(characterBytes);
               hash.
            }
        }

        class dictionaryLoader
        {
            List<string> dictionary = new List<string>();

            public dictionaryLoader()
            {
                string dictionaryTextFile = System.IO.File.ReadAllText(@"C:\Users\Ammon.Riley\Desktop\coolioBallin.txt");
                string[] dictionaryText = dictionaryTextFile.Split('\n');

                foreach(var dictionaryWord in dictionaryText) {
                    dictionary.Add(dictionaryWord);
                }
            }

            public void printDictionary()
            {
                foreach(var word in dictionary)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
