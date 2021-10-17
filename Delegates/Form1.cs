using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calc add = delegate (int num1, int num2)
            {
                return num1 + num2;
            };
            add = (int num1, int num2) =>
            {
                return num1 + num2;
            };
            int res = add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Calc sub = delegate (int num1, int num2)
            {
                return num1 - num2;
            };
            sub = (int num1, int num2) =>
            {
                return num1 - num2;
            };
            int res = sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = res.ToString();
        }
    }
}
