using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab1
{
    //проверка комбинаций
    public class FindVariation
    {
        char[] SignArr = { '+', '-', '*', ' ' };
        private int need_num;
        private int[] arr;
        private char[,] table;

        public FindVariation(int nn, int[] ar)
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
        public string FindVar()
        {
            Calculate calc = new Calculate();
            GetVar();
            string res_str = "";
            string calc_str = arr[0].ToString(); //первая цифра комбинации
            for (int k = 0; k < table.GetLength(0); k++)
            {
                for(int j = 0; j < table.GetLength(1);)
                { 
            /*for (int k = 0; k <= table.Length; k++)
            {
                for (int j = 0; j < ) */               

                //собираем выражение в одну строку
                for (int i = 1; i < arr.Length; i++) //цикл по числам, для которых нужно подобрать знаки
                    {
                        switch (table[i, j])
                        {
                            case '+':
                                calc_str = calc_str + '+' + arr[i].ToString();
                                break;
                            case '-':
                                calc_str = calc_str + '-' + arr[i].ToString();
                                break;
                            case '*':
                                calc_str = calc_str + '*' + arr[i].ToString();
                                break;
                            case ' ':
                                calc_str += arr[i].ToString();
                                break;
                        }
                        j++;
                    }
                }
                //вычисляем значение получившейся строки
                string res = calc.CalculateVar(calc_str);
                if (Char.IsDigit(res.ToCharArray()[0]))
                    if (Int32.Parse(res) == need_num)
                        res_str += calc_str + " = " + need_num + "\n";
            }
            return res_str;
        }
    }
}
