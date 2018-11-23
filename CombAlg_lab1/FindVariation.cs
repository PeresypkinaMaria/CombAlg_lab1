using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab1
{
    //проверка комбинаций
    class FindVariation
    {
        char[] SignArr = { '+', '-', '*', ' ' };
        private int need_num;
        private int[] arr;
        public char[,] table;

        FindVariation(int nn, int[] ar)
        {
            need_num = nn;
            arr = ar;
        }

        //получение всех возможных перестановок операций
        void GetVar()
        {
            int var_len = arr.Length - 1;
            int perm = (int) Math.Pow(SignArr.Length, var_len); //количество вариантов размещений
            table = new char[perm, var_len]; //двумерный массив из всех вариантов

            for (int i = 0; i < var_len; i++) //перебор всех позиций в комбинации
            {
                int cnt = (int)Math.Pow(SignArr.Length, i); //количество комбинаций с заданной позиции
                for (int p1 = 0; p1 < perm;) //проход по всем комбинациям
                {
                    for (int j = 0; j < SignArr.Length; j++) //проходим по всем символам
                    {
                        for (int p2 = 0; p2 < cnt; p2++) //частота записи каждого символа = количество комбинаций начиная с данной позиции
                        {
                            // в каждую комбинацию в опрделенную позицию записываем символ
                            table[p1, i] = SignArr[j];
                            p1++;
                        }
                    }
                }
            }
        }

        //поиск вариантов комбинаций
        string FindVar()
        {

        }
    }
}
