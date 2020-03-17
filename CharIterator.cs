using System;

namespace Iterator {
	public class CharIterator : Iterator {
		private readonly FileContent Text;
		private int CurrentIndex = -1; // Check zero index for HasNext()
		public CharIterator(FileContent content) => this.Text = content;

		public bool HasNext() {
			Remove(); string fileText = Text.FileText; //Where to put Remove()?
			while (CurrentIndex < fileText.Length - 1) {
					if (Char.IsLetter(fileText[CurrentIndex + 1])) { return true; }
					else { CurrentIndex++; }
			} return false;
		}

		public string MoveNext() {
			CurrentIndex++; return Text.FileText.Trim()[CurrentIndex].ToString();
		}

		public void Remove() {
			string fileText = Text.FileText;
			string newString = "";
			for (int i = 0; i < fileText.Length; i++) {
				if (Char.IsWhiteSpace(fileText[i])) {continue;}
				newString += fileText[i];
			} Text.FileText = newString;
		}
	}
}
