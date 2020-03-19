using System;
using System.Collections.Generic;


namespace Iterator {
    class StatisticalAnalysis : View {
        private const int BaseForOccurences = 0;
        private readonly Iterator IteratorType;

        public StatisticalAnalysis(Iterator iterator) => IteratorType = iterator;

        public int CountOf(params string[] arguments) {
            IteratorType.Reset(); int countOfArgs = BaseForOccurences;
            for (int i = 0; i < arguments.Length; i++){
                var size = BaseForOccurences;
                while (IteratorType.HasNext()) {
                    if (!IteratorType.MoveNext().Contains(arguments[i])) {continue;}
                    size++;
                } countOfArgs += size;
            } return countOfArgs;
        }

        public int DictionarySize() => MakeDict().Count;
        
        public int Size() {
            IteratorType.Reset(); int size = 0;
            while (IteratorType.HasNext()) {IteratorType.MoveNext(); size++; }
            return size;
        }

        private Dictionary<string, int> MakeDict() { 
            IteratorType.Reset();
            Dictionary<string, int> wordBase = new Dictionary<string, int>();
            while (IteratorType.HasNext()) {
                string word = IteratorType.MoveNext();
                if (!wordBase.ContainsKey(word)) { wordBase.Add(word, 1); }
                else { wordBase[word]++; }
            } return wordBase;
        }

        public string OccurMoreThan(int integer) {
            IteratorType.Reset(); string wordsMoreThan = "";
            var wordBase = MakeDict();
            foreach (string x in wordBase.Keys) {
                if (wordBase[x] > integer) {wordsMoreThan+= $"{x} ";}
            } if (wordsMoreThan == "") { return "No words found"; }
            return wordsMoreThan;
        }
        
        private int GetPercentageOfVowels() {
            IteratorType.Reset(); int vowelNumber = 0;
            string[] vowels = new string[] { "a", "o", "i", "e", "u", "y" };
            while (IteratorType.HasNext()) {
                var character = IteratorType.MoveNext(); 
                foreach (string vowel in vowels) {
                    if (character.Equals(vowel)) {vowelNumber++;}}    
            } return vowelNumber;
        }

        public int GetVowels() {
            float stringVolume = Convert.ToSingle(Size());
            float vowelsToFloat = Convert.ToSingle(GetPercentageOfVowels());
            double final = (vowelsToFloat / stringVolume) * 100.00; // need the assignment to get that decimal
            return (int)final;
        }
    }
}
