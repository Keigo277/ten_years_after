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
    public partial class Form10 : Form
    {
        public Form10(int num)
        {
            InitializeComponent();
            ShowAns(num);
        }

        public void ShowAns(int kota)
        {
        switch(kota)
            {
                case 1:
                    button1.Text = "はい";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 2:
                    button1.Text = "(笑顔で)きっと元気にしていますよ";
                    button2.Text = "自業自得だからしょうがないよ";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 3:
                    button1.Text = "(ハンカチを差し出す)";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 4:
                    button1.Text = "わかりました。";
                    button2.Text = "ごめんなさい";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 5:
                    button1.Text = "ハカセって?";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 6:
                    button1.Text = "うん。むしろ楽して稼げそうだから喜んで！！";
                    button2.Text = "なりたくないわ";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 8:
                    button1.Text = "・・・・・";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 9:
                    button1.Text = "はい";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 10:
                    button1.Text = "はい。別に気にしないので";
                    button2.Text = "正直、なりたくないです。";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 11:
                    button1.Text = "過去から来ました";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 12:
                    button1.Text = "お腹大きいですね。";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 13:
                    button1.Text = "はい。なりたいです";
                    button2.Text = "別になりたいとは思いません";
                    button3.Hide();
                    button4.Hide();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
