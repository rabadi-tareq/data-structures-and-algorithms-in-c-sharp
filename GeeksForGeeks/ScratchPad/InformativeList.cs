using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad
{
    public class InformativeList<T> : List<T>
    {
        public override string ToString()
        {
            return $"[{string.Join(", ", this)}]";
        }
    }
}
