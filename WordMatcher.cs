using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {

        public List<MatchedWord> Match(string[] scrambledWords, string [] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (var scrambledWord in scrambledWords)
            {

                foreach(var word in wordList)
                {

                    //scrambledWord already matched word
                    if(scrambledWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                    }
                    else
                    {
                        //convert strings into chraters arrays
                        char[] scrambledWordArray = scrambledWord.ToCharArray();


                        //sort both charater arrays(Array.sort())
                        Array.Sort(scrambledWordArray);
                        for(int i =0; i < scrambledWord.Length; i++)
                        {
                            Console.WriteLine(scrambledWord[i]);
                        }
                        
                        //convert character arrays back to strings
                        string scrambledString = new string(scrambledWordArray);
                        //compare the two strings
                        //if they are equal, add to matchedWord list
                        if (scrambledWord.Equals(scrambledString, StringComparison.OrdinalIgnoreCase){
                            matchedWords.Add(BuildMatchedWord(scrambledWord, scrambledString));
                        }
                        else
                        {
                            Console.WriteLine("no word");
                        }
                    }
                    //end of if

                }
                //end of 2nd foraech
                 
            }
            //end of 1st foreach

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {

                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };
                return matchedWord;
            }

            return matchedWords;

        }

    }
}
