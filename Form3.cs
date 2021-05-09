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
    public partial class Form3 : Form
    {
       
        public Form3(int cosmo)
        {
            InitializeComponent();
            int cun = cosmo;
            Selecta(cosmo);
          
            //button3.Hide();
            //button4.Hide();

        }

        public void Selecta(int num)
        {
            switch(num)
            {
                case 1:
                    button1.Text = "はい";
                    button2.Text = "別に";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 2:
                    button1.Text = "ハイ！！ぜひ会ってみたいです";
                    button2.Text = "そんなに興味ありません。むしろ家でゲームがしたい";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 3:
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    button1.Text = "OKです！";
                    break;
                case 4:
                   
                    button4.Hide();
                    button1.Text = "・・・";
                    button2.Text = "まさか俺・・・";
                    button3.Text = "誰？";
                    break;
                case 5:
                    button1.Text = "ハンカチを差し出す";
                    button2.Text = "ただ茫然と見ている";
                    button3.Hide();
                    button4.Hide();
                    break;
                case 6:
                    
                    button1.Text = "すごくなりたいと思いました";
                    button2.Text = "正直今、複雑な思いです";
                    button3.Text = "なりたくないです。";
                    button4.Text = "絶対嫌です。";
                    button3.Show();
                    button4.Show();
                    break;
                case 7:
                    button1.Text = "おっ俺・・・";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 8:
                    button1.Text = "(指をさして)それは？";
                    button2.Show();
                    button3.Hide();
                    button4.Hide();
                    button2.Text = "(銃のことは見なかったフリをする）";
                    break;
                case 9:
                    button2.Show();
                    button3.Hide();
                    button4.Hide();
                    button1.Text = "いえ別に...";
                    button2.Text = "その手に持っている物は？";
                    break;
                case 10:
                    button1.Text = "銃？";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 11:
                    button1.Text = "はい";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 12:
                    button1.Text = "（新聞見せて）これあなたですか？";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 13:
                    button1.Text = "(正直に過去から来たことを告白する）";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 14:
                    button1.Text = "今は何しているのですか？";
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    break;
                case 15:
                    button1.Text = "なりたいです。";
                    button2.Text = "なりたくないです。";
                    button3.Hide();
                    button4.Hide();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
