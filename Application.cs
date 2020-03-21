using System;
using System.Collections.Generic;
//TODO discription
namespace Iterator {
    class Application {
        static void Main(string[] args) {
            FileContent text = new FileContent(args[0]);
            Iterator character = text.CharIterator();
            Iterator word = text.WordIterator();
            StatisticalAnalysis wordAnalysis = new StatisticalAnalysis(word);
            StatisticalAnalysis charAnalysis = new StatisticalAnalysis(character);
            Console.WriteLine($"Name of analyzed file: {args[0]}" );
            Console.Write("Total word count: "); wordAnalysis.Print(wordAnalysis.Size());
            Console.Write("Total character count: "); charAnalysis.Print(charAnalysis.Size());
            Console.Write("Dict size: "); wordAnalysis.Print(wordAnalysis.DictionarySize());
            Console.Write("Vowels % of overall text: "); charAnalysis.Print(charAnalysis.GetVowels());
            Console.Write("Specify words you wish to check for sum of occurences in the text: "); string findWord = Console.ReadLine().ToLower();
            Console.Write($"{findWord.ToUpperInvariant()} has occured "); wordAnalysis.Print(wordAnalysis.CountOf(findWord));
            Console.WriteLine("Enter integer to find words that occur more than the integer: "); int moreThan = Int32.Parse(Console.ReadLine().ToLower());
            Console.Write($"Words that occur more than {moreThan} times: "); wordAnalysis.Print(wordAnalysis.OccurMoreThan(moreThan));
        }
    }
}
