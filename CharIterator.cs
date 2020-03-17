using System;

namespace Iterator {
	public class CharIterator : Iterator {
		private readonly FileContent Text;
		public int CurrentIndex { get; set; }
		public CharIterator(FileContent content) => this.Text = content; 

		public bool HasNext() {
			string fileText = Text.FileText.Trim();
			while (CurrentIndex + 1 < fileText.Length) {
				if (Char.IsLetter(fileText[CurrentIndex + 1])) { return true; }
			} 
			return false;
		}

		public string MoveNext() {
			var currentChar = Text.FileText.Trim()[CurrentIndex].ToString();
			CurrentIndex++;
			return currentChar;
		}

		public void Remove() {
			string fileText = Text.FileText;
			string newString = "";
			for (int i = 0; i < fileText.Length; i++) {
				if (Char.IsWhiteSpace(fileText[i])) {continue;}
				newString += fileText[i];
			}
			Text.FileText = newString;
		}
	}
}
