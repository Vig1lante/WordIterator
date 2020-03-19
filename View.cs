using System.Collections.Generic;

namespace Iterator {
    abstract class View {
        public void Print(string sampleString) {
            System.Console.WriteLine(sampleString);
        }
        public void Print(List<string> sampleList) {
            System.Console.WriteLine(sampleList);

        }
        public void Print(int sampleInt) {
            System.Console.WriteLine(sampleInt);

        }
        public void Print(Dictionary<string, int> Integer) {
            System.Console.WriteLine(Integer);
        }
    }
}
