using System.Collections.Generic;

namespace Iterator {
    //FIXME: (ignore) please implement missing method (name of a method)
    abstract class View {
        public void Print(string sampleString) { System.Console.WriteLine(sampleString); }
        public void Print(List<string> sampleList) { System.Console.WriteLine(sampleList); }
        //FIXME: (ignore) the below method should heave 2 arguments 
        public void Print(int sampleInt) { System.Console.WriteLine(sampleInt); }
        public void Print(double sampleDouble) { System.Console.WriteLine(sampleDouble); }
        public void Print(Dictionary<string, int> Integer) { System.Console.WriteLine(Integer); }
    }
}
