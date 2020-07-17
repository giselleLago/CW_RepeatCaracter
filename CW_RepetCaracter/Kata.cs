using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_RepetCaracter
{
    public class Kata
    {
        public int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}

