using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";
            else textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length-1);
        }
    }
}
