namespace Iterator {
    public interface Iterator {
        public bool HasNext();
        public string MoveNext();
        public void Remove();
        public void Reset(); // Need this to reset index counter for UML generalization between classes
    }
}
