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
        //private char[,] table;

        public FindVariation(int nn, int[] ar)
        {
            need_num = nn;
            arr = ar;
        }

        //поиск вариантов комбинаций
        public string FindVar()
        {
            Calculate calc = new Calculate();

            int num_p = SignArr.Length; //количество переставляемых значений
            int len = arr.Length - 1; //на скольких местах переставляем
            int size = num_p > len ? num_p : len; // размер массива
            int[] per = new int[size];

            //заполняем массив индексами первой перестановки
            for (int i = 0; i < size; i++)
                per[i] = 0;

            string res_str = "";
            string calc_str = arr[0].ToString(); //первая цифра комбинации

            //собираем выражение в одну строку
            do
            {
                int j = 0; //индекс позиции в комбинации 
                calc_str = arr[0].ToString(); //первый символ строки - первая цифра
                for (int i = 1; i < arr.Length; i++) //цикл по числам, для которых нужно подобрать знаки
                {
                    switch (SignArr[per[j]])
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
                string res = calc.CalculateVar(calc_str); //считаем получившуюся строку

                //если полученый и требуемы ответы равны, то запоминаем комбинацию
                if (Char.IsDigit(res.ToCharArray()[0]))
                    if (Int32.Parse(res) == need_num)
                        res_str += calc_str + " = " + need_num + "\r\n";
            } while (PermutationsWithRepetition.GetNextPlacing(per, num_p, len));
            return res_str;
        }
    }
}
