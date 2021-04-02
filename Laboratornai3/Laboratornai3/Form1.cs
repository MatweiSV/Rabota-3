using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornai3
{
    public partial class Form1 : Form
    {
        DateTime sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text;//Выбор знака
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text;//Выбор знака
        }

        private void Ymnojit_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text; //Выбор знака
        } 

        private void Delit_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text; //Выбор знака
        }

        private void POW_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text; //Выбор знака
        }

        private void Procent_Click(object sender, EventArgs e)
        {
            znak.Text = (sender as Button).Text; //Выбор знака
        }

        private void Itog_Click(object sender, EventArgs e)
        {
            double chislo1, chislo2;
            string s = znak.Text;
            double rez = 0;
            chislo1 = Convert.ToDouble(TextBox1.Text);
            chislo2 = Convert.ToDouble(TextBox2.Text);
            switch (s[0])
            {
                case '+':
                    rez = chislo1 + chislo2; break;
                case '-':
                    rez = chislo1 - chislo2; break;
                case '*':
                    rez = chislo1 * chislo2; break;          // Решения
                case '/':
                    rez = chislo1 / chislo2; break;
                case 'P':
                    rez = Math.Pow(chislo1, chislo2); break;
                    case '%':
                    rez = chislo1 / chislo2; break;
            }
            Reshenie.Text = "= " + rez.ToString(); // Вывод результата
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = sec.AddSeconds(1);
            if (sec.Second >5)
            {
                this.timer1.Stop();
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
            }

        }
    }
}
