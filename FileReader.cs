using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {

        public string[] Read(string filename)
        {

            //declare s string [] to hold the content of the file
            string[] wordFile = File.ReadAllLines("scrambledWords.txt"); //DON'T KNOW WHAT TO PUT HERE

            //try/catch
            try
            {
            //read from the file - ReadAllLines()
                foreach (string word in wordFile)
                {
                    return wordFile;
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            

            //return file contents, which is a string

            return wordFile;

            
        }

    }
}
