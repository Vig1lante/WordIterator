namespace Iterator {
    class StatisticalAnalysis {
        private const int BaseWordOccurences = 0;
        private readonly Iterator IteratorType;
        public StatisticalAnalysis(Iterator iterator) => IteratorType = iterator;

        public int CountOf(params string[] arguments) {
            var countOfArgs = new int[arguments.Length];
            for (int i = 0; i < arguments.Length; i++){
                var size = BaseWordOccurences;
                while (IteratorType.HasNext()) {
                    if (!IteratorType.MoveNext().Contains(arguments[i])) {continue;}
                    size++;
                }
                countOfArgs[i] = size;
            }
            return countOfArgs[0];
        }

        public int DictionarySize() {
            return -1;
        }

        public int Size() {
            return -1;
        }

        public string OccurMoreThan(int integer) {
            return "";
        }

        
    }
}
