using System;
using System.Linq;
using System.Collections.Generic;


namespace Iterator {
    class WordIterator : Iterator {
        private string[] WordsList;
        private int CurrentIndex = -1;
        public WordIterator(FileContent content) => this.WordsList = content.FileText.Split(' ');

        public bool HasNext() {
            if (CurrentIndex.Equals(-1)) { Remove(); } // Omit execution of remove when looping through HasNext()
            if (CurrentIndex + 1 < WordsList.Length) {return true;} 
            return false;}

        public string MoveNext() {
            if (HasNext()) { CurrentIndex++; return WordsList[CurrentIndex]; }
            else { return WordsList[CurrentIndex - 1]; }   
        }
        public void Remove() {
            List<string> tempList = new List<string>();
            foreach (string word in WordsList) {
                if (!word.Equals("")) {
                    tempList.Add(word);
                }
            }
            WordsList = tempList.ToArray();
        }
        public void Reset() => CurrentIndex = -1;      
    }
}
