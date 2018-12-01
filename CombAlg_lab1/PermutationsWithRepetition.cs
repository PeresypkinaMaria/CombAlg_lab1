using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab1
{
    //класс, генерирующий следующий вариант размещения
    class PermutationsWithRepetition
    {
        public static bool GetNextPlacing(int[] per, int len, int var_len)
        {
            int i = var_len - 1;
            while (i >= 0 && per[i] == len - 1)
                i--;
            if (i < 0)
                return false;
            if (per[i] >= len)
                i--;
            per[i]++;
            if (i == var_len - 1)
                return true;
            for (int j = i + 1; j < var_len; j++)
                per[j] = 0;
            return true;
        }
    }
}
