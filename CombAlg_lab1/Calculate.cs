using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombAlg_lab1
{
    public class Calculate
    {
        int i;

        bool is_operation(char c)
        {
            return c == '+' || c == '-' || c == '*';
        }

        int priority(char c)
        {
            return c == '+' || c == '-' ? 1 : 
                c == '*' ? 2 :
                -1;
        }

        //выполнение операции, true - успешно
        bool PerformOperation(Stack st, char c)
        {
            int n2 = Int32.Parse(st.Pop().ToString());
            int n1 = Int32.Parse(st.Pop().ToString());
            switch (c)
            {
                case '+':
                    st.Push(n1 + n2);
                    return true;
                case '-':
                    st.Push(n1 - n2);
                    return true;
                case '*':
                    st.Push(n1 * n2);
                    return true;
                default:
                    return false;
            }
        }

        //вычисление комбинации
        public string CalculateVar(string str)
        {
            Stack st_num = new Stack(); //стек с числами
            Stack st_op = new Stack(); //стек с операциями
            char[] s = str.ToCharArray();
            for(i = 0; i < s.Length; i++)
                if (is_operation(s[i]))
                {
                    char curr_op = s[i]; //запоминаем операцию
                    while (st_op.Count != 0 && priority((char)st_op.Peek()) >= priority(s[i])) //пока стек не пуст и приоритет операции ниже
                        if (!PerformOperation(st_num, (char)st_op.Pop())) //выполняем предыдущую операцию в стеке
                            return "Ошибка!";
                    st_op.Push(curr_op); //заносим в стек нашу операцию
                }
                else //если не операция
                {
                    string num = "";
                    int j = 0;
                    while (i < s.Length && Char.IsDigit(s[i]))
                    {
                        num += s[i]; //добавляем цифру к числу
                        j++;
                        i++;
                    }
                    --i;
                    st_num.Push(Int32.Parse(num));
                }
            while (st_op.Count != 0)
            {
                if (!PerformOperation(st_num, (char)st_op.Peek()))
                    return "Ошибка!";
                st_op.Pop();
            }
            if (st_num.Count != 0)
                return st_num.Peek().ToString();
            else
                return "Ошибка!";
        }
    }
}
