using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Toto je retezec predstavovany nekolika radky,\n"
                                     + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                                     + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                                     + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                                     + "posledni veta!";

            StringStatistics stringStatistics = new StringStatistics(testText);
            Console.WriteLine("Count of words: "+stringStatistics.WordCount());
            Console.WriteLine("Count of lines: "+stringStatistics.LineCount());
            Console.WriteLine("Count of sentences: "+stringStatistics.SentenceCount());
         
            foreach (string word in stringStatistics.LongestWord())
            {
                Console.WriteLine("Longest words: " + word);
            }

            Console.WriteLine("Shortest words: {0}", string.Join(", ", stringStatistics.ShortestWord()));

            foreach (var word in stringStatistics.FrequentWords()) 
            {
                if (word.Value == stringStatistics.FrequentWords().Values.Max()) 
                {
                    Console.WriteLine("Frequent words: " + word.Key);
                }
            }
            Console.WriteLine("Alphabeticaly sorted words: {0}", string.Join(", ", stringStatistics.AlphabeticalySortString()));
            Console.WriteLine("Is safe from Putin ? : " + stringStatistics.IsSafeFromPutin());


            Console.ReadLine();



        }
    }
}
