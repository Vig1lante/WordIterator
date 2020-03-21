using System;

namespace Iterator {
	//TODO class test test
	public class CharIterator : Iterator {
		private readonly FileContent Text;
		private int CurrentIndex = -1; // Check zero index for HasNext()
		public CharIterator(FileContent content) => this.Text = content;

		public bool HasNext() {
			if (CurrentIndex.Equals(-1)) { Remove(); }
			string fileText = Text.FileText; 
			while (CurrentIndex < (fileText.Length - 1)) {
					if (Char.IsLetter(fileText[CurrentIndex + 1])) { return true; }
					else { CurrentIndex++; }
			} return false;
		}
		
		public string MoveNext() {
			if (!CurrentIndex.Equals((Text.FileText.Length - 1))) {
				CurrentIndex++;}
			return Text.FileText.Trim()[CurrentIndex].ToString();
		}

		public void Remove() {
			string fileText = Text.FileText; string newString = "";
			for (int i = 0; i < fileText.Length; i++) {
				if (Char.IsWhiteSpace(fileText[i])) {continue;}
				newString += fileText[i];
			} Text.FileText = newString;
		}
		public void Reset() => CurrentIndex = -1;
	}
}
