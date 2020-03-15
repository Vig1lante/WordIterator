using System;

namespace Iterator
{
	public class CharIterator : Iterator
	{
		private FileContent Text;
		private int CurrentIndex { get; set; }
		public CharIterator(FileContent content) => this.Text = content;

		public bool HasNext()
		{
			Remove();
			CurrentIndex++;
			string fileText = Text.FileText.Trim();
			while (Text.FileText[CurrentIndex] < fileText.Length)
			{
				if (!Char.IsLetter(fileText[CurrentIndex])) { CurrentIndex++; }
				else { return true; }
			}
			return false;
		}

		public string MoveNext()
		{
			var currentChar = Text.FileText.Trim()[CurrentIndex].ToString();
			if (HasNext())
			{
				CurrentIndex++;

			}
			return currentChar;
		}

		public void Remove()
		{
			string fileText = Text.FileText;
			string newString = "";
			for (int i = 0; i < fileText.Length; i++)
			{
				if (Char.IsWhiteSpace(fileText[i]))
				{
					continue;
				}
				newString += fileText[i];
			}
			Text.FileText = newString;
		}
	}
}
