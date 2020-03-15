using System;
using System.IO;

namespace Iterator
{
	public class FileContent: IterableText
	{
		public string FileText;
		private string FileName;
		private Iterator ICharIterator;

		public FileContent(string name)
		{
			string currentDirectory = Environment.CurrentDirectory;
			string root = currentDirectory.Replace("\\bin\\Debug\\netcoreapp3.1", "");
			this.FileName = $"\\{name}";
			string file = root + this.FileName;
			string fileContents = File.ReadAllText(file);
			fileContents = fileContents.Replace("\n", " ").Replace("\t", " ").Replace("\r", " ");
			this.FileText = fileContents.ToLower();
			this.ICharIterator = new CharIterator(this);
		}

		public Iterator CharIterator()
		{
			return ICharIterator;
		}

		public Iterator WordIterator()
		{
			return null;
		}

		public string GetFileName()
		{
			return FileName;
		}
	}
}
