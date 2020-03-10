using System;

namespace Iterator
{
    interface Iterator
    {
        public bool HasNext()
        {
            return false;
        }

        public string MoveNext()
        {
            return "";
        }

        public void Remove()
        {

        }
    }
}
