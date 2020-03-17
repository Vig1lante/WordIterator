using System;
using System.Collections.Generic;

namespace Iterator {
    class Application {
        static void Main(string[] args) {
            FileContent text = new FileContent(args[0]);
            Iterator x = text.CharIterator();
            StatisticalAnalysis test = new StatisticalAnalysis(x);
            int yx = test.Size();
            Console.WriteLine(yx);
        }   
    }
}
