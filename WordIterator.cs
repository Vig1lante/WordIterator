using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class WordIterator : Iterator
    {
        private string[] WordsList;
        private int CurrentIndex { get { return this.CurrentIndex; } set { this.CurrentIndex = 0; } }

        public WordIterator(FileContent content) => this.WordsList = content.FileText.Split(' ');

        public bool HasNext()
        {
            bool validateWords = (CurrentIndex < WordsList.Length) ?  true :  false;
            return validateWords;
        }

        public string MoveNext()
        {
            if (HasNext()){ CurrentIndex++;}
            return WordsList[CurrentIndex]; 
        }

        public void Remove() { }
    }
}
