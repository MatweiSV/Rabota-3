using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Laboratornai3
{
    public partial class Form3 : Form
    {
        string def1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            double c = 0;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                c = a + b;
            }
            if (radioButton2.Checked == true)
            {
                c = a - b;
            }
            if (radioButton3.Checked == true)
            {
                c = a * b;
            }
            if (radioButton4.Checked == true)
            {
                c = a / b;
            }
            if (radioButton5.Checked == true)
            {
                c = Math.Pow(a, b);
            }
            if (radioButton6.Checked == true)
            {
                c = a % b;
            }
            textBox3.Text = c.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Сложение");
            listBox1.Items.Add("Вычитание");
            listBox1.Items.Add("Умножение");
            listBox1.Items.Add("Деление");
            listBox1.Items.Add("Возведение в степень");
            listBox1.Items.Add("Остаток от деления");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: def1 = "Adding"; break;
                case 1: def1 = "Substruction"; break;
                case 2: def1 = "Multiplication"; break;
                case 3: def1 = "Partion"; break;
                case 4: def1 = "Involution"; break;
                case 5: def1 = "Remainder"; break;
            }
            Class1.def = def1;
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }
    }
}
