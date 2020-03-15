using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IterableText
    {
        public Iterator CharIterator();

        public Iterator WordIterator();
    }
}
