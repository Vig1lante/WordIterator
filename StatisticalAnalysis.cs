namespace Iterator {
    class StatisticalAnalysis {
        private const int BaseWordOccurences = 0;
        private readonly Iterator IteratorType;
        public StatisticalAnalysis(Iterator iterator) => IteratorType = iterator;

        public int CountOf(params string[] arguments) {
            int countOfArgs = 0;
            for (int i = 0; i < arguments.Length; i++){
                var size = BaseWordOccurences;
                while (IteratorType.HasNext()) {
                    if (!IteratorType.MoveNext().Contains(arguments[i])) {continue;}
                    size++;
                }
                countOfArgs += size;
            }
            return countOfArgs;
        }

        public int DictionarySize() {
            return -1;
        }

        public int Size() {
            int size = 0;
            IteratorType.Remove();
            while (IteratorType.HasNext()) {
                IteratorType.MoveNext();
                size++;}
            return size;
        }

        public string OccurMoreThan(int integer) {
            return "";
        }

    }
}
