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
			this.FileName = name;
			string file = @$"C:\Users\apaki\Desktop\C#\csharp-text-analyser-Vig1lante\{name}";
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
