using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cv4
{
    class StringStatistics
    {
        public string str { get; set; }

        public StringStatistics(string str)
        {
            this.str = str;
        }

        public int WordCount()
        {
            string[] subs = str.Split(' ', '\n') ;
           
            return subs.Length;
        }

        public int LineCount()
        {
            string[] subs = str.Split('\n');
           
            return subs.Length;
        }

        public double SentenceCount()
        {
            string[] subs = Regex.Split(str, "([!?\\.]\\s[A-Z])|([!?]^\\s)");
           
            return Math.Ceiling((double)subs.Length /2);
        }
        public List<string> LongestWord()
        {
            List <string> words = new List<string>();

            string longestWord = "";
            
            string[] subs = SplitString();


            foreach (string sub in subs) 
            {
                if (sub.Length > longestWord.Length)
                {
                    words.Clear();
                    words.Add(sub);
                    longestWord = sub;
                }
                else if (sub.Length == longestWord.Length)
                { 
                    words.Add(sub);
                    longestWord = sub;
                }
            }
            return words;
        }

        public List<string> ShortestWord()
        {
            List<string> words = new List<string>();

            string longetsWord = "                                                   ";

            string[] subs = SplitString();
            foreach (string sub in subs)
            {
                if (sub.Length < longetsWord.Length)
                {
                    words.Clear();
                    words.Add(sub);
                    longetsWord = sub;
                }
                else if (sub.Length == longetsWord.Length)
                {
                    words.Add(sub);
                    longetsWord = sub;
                }
            }
            return words;
        }

        public Dictionary<string, int> FrequentWords() 
        {
            var subs = SplitString();  // Split the string and stored it an var variable  

            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();

            for (int i = 0; i < subs.Length; i++) //loop the splited string  
            {
                if (RepeatedWordCount.ContainsKey(subs[i])) // Check if word already exist in dictionary update the count  
                {
                    int value = RepeatedWordCount[subs[i]];
                    RepeatedWordCount[subs[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(subs[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }
            return RepeatedWordCount;
        }

        public string[] AlphabeticalySortString() 
        {
            string[] subs = SplitString();

            Array.Sort(subs);
            return subs;
        }

        public string[] SplitString() 
        {
            return (str.Replace('\n', ' ').Replace(".", "").Replace("!", "")
                        .Replace("?", "").Replace(",", "").Replace("(", "")
                        .Replace(")", "").Split(' '));
        }

        public bool IsSafeFromPutin() 
        {
            string[] subs = SplitString();
            string[] dangerWords = { "war", "guns", "Putin", "bomb" };

            foreach (string word in dangerWords) 
            {
                if (subs.Contains(word)) 
                {
                    return false;   
                }
            }
            return true;
        
        }
    }
}
