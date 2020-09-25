using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {

        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {

            

            try
            {
                Console.WriteLine("enter scrambled word(s) manually or as a file: F - file /M - manual");
                String option = Console.ReadLine() ?? throw new Exception("String is empty/null");

                switch (option.ToUpper())
                {
                    case  "F":
                        Console.WriteLine("Enter the path to the file");
                        ExecuteScrambledWordInFileScenario();
                        break;

                    case "M":
                        Console.WriteLine("Enter the words mannually ( seperated by commas if multiple )");
                        ExecuteScrambledWordsManualEntryScenario();
                        break;

                    default:
                        Console.WriteLine("The entered option is not recognized");
                        break;
                }



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


        }




        

        //for the manually written words
        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            // get user's input - a comma seperated string containing scrambled words
            string manualWord = Console.ReadLine();


            //extract the words into a string[] - use Split()
            //char[] separators = { ',', ' ' };
            char[] commas = { ',', ' ' };

            //string[] scrambledWords = manualInput.Split();
            string[] manualWordArray = manualWord.Split(commas);

            //display matched words


            //DisplayMatchedUnscrambledWords(scrambledWords);
        }








        //for the text file.

        private static void ExecuteScrambledWordInFileScenario()
        {
            //read the user s input - file with scrambled words
            var filename = Console.ReadLine();

            //read words from the file and store in string[] scrambledWords
            string[] scrambledWords = _fileReader.Read(filename);

            //display matched words
            DisplayMatchedUnscrambledWords(scrambledWords);
        }








        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words in the wordlist.txt file (unscrambled words)
            string[] wordist = _fileReader.Read("wordlist.txt");

            //call a word matcher method, to get a list of MatchedWord structs
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordist);

            //display the match - print to console
            if (matchedWords.Any())
            {
                //loop through matchedWords and print to console the contents of the structs
                for(int i=0; i<wordist.Length; i++)
                {
                    Console.WriteLine(wordist[i]);
                }
                //foreach
                foreach(var matchedWord in matchedWords)
                {
                    

                    //matched found for act: cat

                }

                //write to console

                //matched found for act: cat
            }
            else
            {
                //no matches have been found
                Console.WriteLine("No words were the same");
            }
            
        }
    }
}
