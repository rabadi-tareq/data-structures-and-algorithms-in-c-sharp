using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.lib
{
    public class InformativeList<T> : List<T>
    {
        public override string ToString()
        {
            return $"[{string.Join(", ", this)}]";
        }

        public new T[] ToArray()
        {
            return base.ToArray();
        }
    }
}
