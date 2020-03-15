using System;

namespace Iterator
{
    class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileContent text = new FileContent(args[0]);
            CharIterator text2 = new CharIterator(text);
            bool x = text2.HasNext();
        }
    }
}
