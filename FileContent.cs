using System;
using System.IO;

namespace Iterator {
	public class FileContent : IterableText {
		public string FileText;
		private readonly string FileName;
		private readonly Iterator ICharIterator, IWordIterator;

		public FileContent(string name) {
			string currentDirectory = Environment.CurrentDirectory;
			string root = currentDirectory.Replace("\\bin\\Debug\\netcoreapp3.1", "");
			this.FileName = $"\\{name}"; string file = root + this.FileName; //Get project root directory here
			string fileContents = File.ReadAllText(file);
			fileContents = fileContents.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");
			this.FileText = fileContents.ToLower();
			this.ICharIterator = new CharIterator(this); this.IWordIterator = new WordIterator(this);
		}

		public Iterator CharIterator() => ICharIterator;

		public Iterator WordIterator() => IWordIterator;

		public string GetFileName() => FileName;
	}
}
