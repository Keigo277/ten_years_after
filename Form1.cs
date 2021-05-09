using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ten_YearsAftter01
{
    public partial class Form1 : Form
    {
        static public string Name1;
        static public int Sei;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Name1 = textBox1.Text;
            if(radioButton1.Checked == true)
            {
                Form2 fm01 = new Form2();
                Sei = 1;
                fm01.Show();
                Name1 = textBox1.Text;
                this.Visible = false;
            }

            if(radioButton2.Checked == true)
            {
                Form2 fm02 = new Form2();
                Sei = 2;
                fm02.Show();
                Name1 = textBox1.Text;
                this.Visible = false;
            }

        }
    }
}
