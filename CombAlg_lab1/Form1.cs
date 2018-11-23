using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombAlg_lab1
{
    public partial class MainForm : Form
    {
        int[] NumArr; //массив чисел
        int NeedNum; //искомое число        

        public MainForm()
        {
            InitializeComponent();
        }

        //считывание чисел
        void GetNum()
        {
            string input_str = tbInputNum.Text;
            input_str = input_str.Replace("  ", " ");
            string[] strNum = input_str.Split(' ');

            if (strNum.Length == 0)
                MessageBox.Show("Введите числа!");
            else
            {
                NumArr = new int[strNum.Length];
                int currNum;
                for (int i = 0; i < strNum.Length; i++)
                {
                    if (Int32.TryParse(strNum[i], out currNum))
                        if (currNum < 0)
                            MessageBox.Show("Введите числа без знака!");
                        else
                            NumArr[i] = currNum;
                    else
                        MessageBox.Show("Ошибка ввода чисел!");
                }
            }
        }

        //считывание требуемого результата
        void GetNeedNum()
        {
            int n;
            if (tbNeedNum.Text == "")
                MessageBox.Show("Введите искомое число!");
            else
            {
                if (Int32.TryParse(tbNeedNum.Text.Trim(), out n))
                    NeedNum = n;
                else
                    MessageBox.Show("Ошибка ввода искомого числа!");
            }
        }


    }
}
