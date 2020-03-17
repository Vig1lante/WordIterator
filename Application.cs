using System;

namespace Iterator {
    class Application {
        static void Main(string[] args) {
            FileContent text = new FileContent(args[0]);
            Iterator x = text.WordIterator();
            StatisticalAnalysis test = new StatisticalAnalysis(x);
            Console.WriteLine(test.CountOf("x")); 
        }
    }
}
