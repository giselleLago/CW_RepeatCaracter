using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_RepetCaracter
{
    public class Kata
    {
        public int DuplicateCount(string str)
        {
            var list = new List<string>();
            for (int x = 0; x < str.Length; x++)
            {
                var countB = 0;
                var str1 = str[x].ToString().ToUpper();
                for (int y = 0; y < str.Length; y++)
                {
                    var str2 = str[y].ToString().ToUpper();
                    if (string.Equals(str2, str1))
                    {
                        countB++;
                    }
                }

                if (countB >= 2 && !list.Contains(str1))
                {
                    list.Add(str1);
                }
            }
            return list.Count;
        }
    }
}

