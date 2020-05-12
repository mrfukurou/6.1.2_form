using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Input(out int n, out int m)
        {
            n = int.Parse(Nn.Text);
            m = int.Parse(Mm.Text);
            Random rand = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = rand.Next(-100, 200);
                }
            return a;
        }

        public void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                    mas.Text += a[i, j] + " ";
                mas.Text += Environment.NewLine;
            }
        }

        public void Change(int[,] a)
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    sum += a[i, j];
            if (sum <= 999 && sum > 99)
                rez.Text = Convert.ToString("Сумма всех элементов массива: " + sum + Environment.NewLine + "Сумма является трехзначным числом");
            else
                rez.Text = Convert.ToString("Сумма всех элементов массива: " + sum + Environment.NewLine + "Сумма не является трехзначным числом");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n, m;
                int[,] myArray = Input(out n, out m);
                Print(myArray);
                Change(myArray);
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!"); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            mas.Clear();
            Nn.Clear();
            Mm.Clear();

        }
    }
}
