using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AxWMPLib;

namespace Ten_YearsAftter01
{
    public partial class Form2 : Form
    {
        static public int count = 0;
        static public int score;
        string an = "...";
        string a = "ようこそマクガレン研究所へ。私はこの研究所を取り仕切っている博士のニックです。";
        string b = "早速ですが";
        string N;
        string c = "君はタイムマシーンに興味はありますか？";
        string ifY = "それはよかった。実は私は今相対性理論の研究のため、タイムマシーンを作っているのです。";
        string ifN = "そうか、興味ないのか。だが今日君がワシのタイムマシーンを使ったらその考えは一変する。実は私は相対性理論の研究のため、タイムマシーンを作っているのです。";
        string d = "少しは驚いたようですね。";
        string e = "そう。";
        string f = "あの映画やドラマに出てくるあのタイムマシーンです。まだ試作品段階であるが完成した。";
        string g = "そして私はそのタイムマシーンで10年後の自分に会ってきました。どうです？";
        string h = "君も会ってみたいと思わないか？　未来の自分に";
        string ifN2 = "そうですか...。";
        string ifN3 = "そんなに嫌ですか...。";
        string ifN4 ="すみません変なことを言ってしまって。私も忙しいから今日は帰ってくれないか";
        string ifY2 = "そんなに喜んでもらえると嬉しいです！では流れを説明します。";
        string i = "今から私が君に20問の質問をする。そしてその答えた質問をもとにタイムマシーンが君の情報を分析し、未来に送るというものです。";
        string j = "では用意はいいですか？";
        string k = "では始めよう";
        string l = "カチカチカチカチ.....";
        string m = "いいぞ！起動まであともう少し!!!";
        string n = "出発ーーーーー！！！";
        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Mani();
        }

        public async void Mani()
        {
            count++;
            N = Form1.Name1;
            axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\gageup.mp3");
            string output = "";
            int chartime = 50;
            int waitTime = 150;
            if(count == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(a);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach(char c in a1)
                    {
                        output += c.ToString();
                        textBox1.Text = output;
                        if("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }

            if (count == 2)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output2 = "";
                await OutputMessage1(b);
                await OutputMessage1(N);
                await OutputMessage1(c);

                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output2 += c.ToString();
                        textBox1.Text = output2;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fm = new Form3(1);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output3 = "";
                    await OutputMessage2(ifY);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char cc in a1)
                        {
                            output3 += cc.ToString();
                            textBox1.Text = output3;
                            if ("" != cc.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }

                else if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output3 = "";
                    await OutputMessage2(ifN);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char cc in a1)
                        {
                            output3 += cc.ToString();
                            textBox1.Text = output3;
                            if ("" != cc.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }

            if (count == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output4 = "";
                await OutputMessage1(an);
                textBox2.Text = N;
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output4 += c.ToString();
                        textBox1.Text = output4;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }

            if (count == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output5 = "";
                await OutputMessage1(d);

                textBox2.Text = "ニック博士";
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output5 += c.ToString();
                        textBox1.Text = output5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 5)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output6 = "";
                await OutputMessage1(e);
                await OutputMessage1(f);
                await OutputMessage1(g);
                await OutputMessage1(h);

                //textBox2.Text = N;
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output6 += c.ToString();
                        textBox1.Text = output6;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fm = new Form3(2);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output7 = "";
                    await OutputMessage2(ifY2);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char cc in a1)
                        {
                            output7 += cc.ToString();
                            textBox1.Text = output7;
                            if ("" != cc.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }

                else if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output7 = "";
                    await OutputMessage2(ifN2);
                    await OutputMessage2(ifN3);
                    await OutputMessage2(ifN4);

                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char cc in a1)
                        {
                            output7 += cc.ToString();
                            textBox1.Text = output7;
                            if ("" != cc.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    MessageBox.Show("ゲームオーバー！！\r\nあなたは博士を怒らせてしまったため未来へ行けなくなりました。");
                    Close();
                }
            }
        
            if (count == 6)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output8 = "";
                await OutputMessage1(i);
                await OutputMessage1(j);
                await Task.Delay(waitTime);
        async Task OutputMessage1(string a1)
        {
            foreach (char c in a1)
            {
                output8 += c.ToString();
                textBox1.Text = output8;
                if ("" != c.ToString())
                {
                    await Task.Delay(chartime);
                }
            }
        }
                Form3 fm = new Form3(3);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output9 = "";
                    await OutputMessage2(k);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char cc in a1)
                        {
                            output9 += cc.ToString();
                            textBox1.Text = output9;
                            if ("" != cc.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    if(Form1.Sei == 1)
                    {
                        Form4 fn = new Form4();
                        fn.Show();
                    }

                    else if(Form1.Sei == 2)
                    {
                        Form5 fn = new Form5();
                        fn.Show();
                    }
                }
            }
            if (count == 7)
            {
                pictureBox2.Image = Properties.Resources.e0a70f72bdae9885bfc32d7cd19a26a1_XL;
                axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\pc_keyboard.mp3");
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output10 = "";
                await OutputMessage1(l);
                //await OutputMessage1(j);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output10 += c.ToString();
                        textBox1.Text = output10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8)
            {
                pictureBox2.Image = Properties.Resources.e0a70f72bdae9885bfc32d7cd19a26a1_XL;
               // axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\pc_keyboard.mp3");
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output11 = "";
                await OutputMessage1(m);
                //await OutputMessage1(j);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output11 += c.ToString();
                        textBox1.Text = output11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }

            if (count == 9)
            {
                pictureBox2.Image = Properties.Resources.env_glamox_i35_labatory_environment_red_light;
                axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\factory_siren1.mp3");
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox1.Text = "3";
            }

            if(count == 10)
            {
                textBox1.Text = "２・・・";
            }

            if(count == 11)
            {
                if (Form1.Sei == 1)
                {
                    textBox1.Text = "1...";
                    Form6 fm1 = new Form6();
                    fm1.Show();
                }

                else if(Form1.Sei == 2)
                {
                    Form7 fm1 = new Form7();
                    fm1.Show();
                }
            }

        }
    }
}
