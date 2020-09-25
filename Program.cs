using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private static readonly string[] scrambledWords;

        static void Main(string[] args)
        {

            Constants cont = new Constants();
            string restart;
            do
            {
                try
                {
                    bool temp;

                    while (true)
                    {

                        cont.Input();
                        String option = Console.ReadLine() ?? throw new Exception("String is empty/null");


                        switch (option.ToUpper())
                        {
                            case "F":
                                cont.File();
                                ExecuteScrambledWordInFileScenario();
                                break;

                            case "M":
                                cont.Mannual();
                                ExecuteScrambledWordsManualEntryScenario();
                                break;

                            default:
                                temp = true;
                                break;

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                cont.Again();
                string rest = Console.ReadLine();
                restart = rest.ToUpper();
            }
            while (restart == "Y"); 


        }




        

        //for the manually written words
        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            // get user's input - a comma seperated string containing scrambled words
            string manualWord = Console.ReadLine();


            //extract the words into a string[] - use Split()
            //char[] separators = { ',', ' ' };
            char[] commas = { ',',' '};

            //string[] scrambledWords = manualInput.Split();
            string[] manualWordArray = manualWord.Split(commas);


            //display matched words

            DisplayMatchedUnscrambledWords(manualWordArray);
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






        //RUBEN TU DOIS ARRANGER ICI PETIT COM RAPELLE TOI

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words in the wordlist.txt file (unscrambled words)
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method, to get a list of MatchedWord structs
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            //display the match - print to console
            if (matchedWords.Any())
            {
                //loop through matchedWords and print to console the contents of the structs
                for (int i = 0; i < wordList.Length; i++)
                {
                    Console.WriteLine(wordList[i]);
                }
                //foreach
                foreach (var matchedWord in matchedWords)
                {

                    Console.WriteLine(matchedWord.ScrambledWord, matchedWord.Word);
                    //matched found for act: cat

                }

               
                //write to console

                //matched found for act: cat
            }
            else
            {
                //no matches have been found
                Console.WriteLine();
            }



            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {

                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };
                return matchedWord;
            }

            

        }


    }


    }

