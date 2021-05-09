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

namespace Ten_YearsAftter01
{

    public partial class Form7 : Form
    {

        int count = 0;
        int Time;
        int sl;
        int set;
        string N = "１０年後の" + Form1.Name1;
        string nko = Form1.Name1;
        string a1 = "噓でしょ...";
        string a2 = "あの博士の言ってたことが本当だなんて";
        string a3 = "は目の前の現実があまりにも衝撃的過ぎて、言葉が出てこなかった。";
        string a4 = "額には皺が少しできていて、顔には生気がない。だがその人物の顔はまるで姉妹のように自分にそっくりだった。";
        string a5 = "あまりにも変わりすぎていてビックリした？";
        string ifa1 = "はい・・・";
        string a6 = "それもそうよね。部屋は汚いし、顔はすごく老けているし、ひとり身の独身女だなんて...";
        string ifa2 = "独身？";
        string a7 = "結婚してたけど、私のあまりのだらしなさに離婚。親権も向こうにあって子供ともう５年も会っていない";
        string a8 = "今頃どうしているのかしらあの子...";
        string ifa3 = "（笑顔で）きっと元気にしていますよ";
        string ifa3_N = "自業自得だからしょうがありませんよ";
        string aa1 = "そうかしら・・・。あの子元気にしているかしら?";
        string aaif = "ええ。きっとそうだと思います。";
        string aaa1 = "すると急に彼女は泣き出した。まるで幼い子供が嗚咽をもらすように";
        string aaaif = "(ハンカチを差し出す)";
        string aaa01 = "ありがとね。";
        string aaaif2 = "少しだけお願いがあるのだけど聞いてもらえないかな？　１０年前の私";
        string ifa4 = "はい";
        string ifa5 = "ごめんなさい";
        string aaaa001 = "１０年前の時代に戻って未来を変えてちょうだい。";
        string aaaa002 = "プログラマーになって欲しいの。未来でもプログラマーは需要があって女性でも高収入を得れる";
        string aaaa003 = "そうすればあの男に子供を盗られなくて済んだから。お願い";

        public Form7()
        {
            InitializeComponent();
            button2.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Mani();
        }

        public async void Mani()
        {
            axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\gageup.mp3");

            count++;
            string output = "";
            int chartime = 50;
            int waitTime = 150;
            if (count == 1 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;
                await OutputMessage1(a1);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output += c.ToString();
                        textBox1.Text = output;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 2 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output2 = "";
                await OutputMessage1(a2);
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
            }
            if (count == 3 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output3 = "";
                textBox2.Text = "(説明)";

                await OutputMessage1(nko);
                await OutputMessage1(a3);
                await OutputMessage1(a4);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output3 += c.ToString();
                        textBox1.Text = output3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }

            if (count == 4 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output4 = "";
                textBox2.Text = N;
                await OutputMessage1(a5);
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

                Form10 fm2 = new Form10(1);
                DialogResult dr = fm2.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string output5 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await OutputMessage2(a6);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
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
            }
            if (count == 5 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output6 = "";
                await OutputMessage1(ifa2);
                textBox2.Text = Form1.Name1;
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
            }
            if (count == 6 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output7 = "";
                await OutputMessage1(a7);
                textBox2.Text = N;
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output7 += c.ToString();
                        textBox1.Text = output7;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 7 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output8 = "";
                await OutputMessage1(a8);
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
                Form10 fn = new Form10(2);
                DialogResult dr = fn.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output9 = "";
                    await OutputMessage2(aa1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            output9 += c.ToString();
                            textBox1.Text = output9;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }


                }
                if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output9 = "";
                    int set = 1;
                    string kowa = "何ですって？アンタなんかに何がわかるのよ！！\r\n大体１０年前のアンタがクズだったからこうなったのでしょ！！　もう顔も見たくない帰ってちょうだい！！ ";
                    await OutputMessage2(kowa);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            output9 += c.ToString();
                            textBox1.Text = output9;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }

                        //if (set == 1 && Form5.point == 1 && count == 8)
                        //{
                        //    axWindowsMediaPlayer1.Ctlcontrols.play();
                        //    string output9_1 = "";
                        //    string kowa2 = "大体１０年前のアンタがクズだったからこうなったのでしょ！！　もう顔も見たくない帰ってちょうだい！！";
                        //    await OutputMessage3(kowa2);
                        //    await Task.Delay(waitTime);
                        //    async Task OutputMessage3(string a2)
                        //    {
                        //        foreach (char c in a2)
                        //        {
                        //            output9_1 += c.ToString();
                        //            textBox1.Text = output9_1;
                        //            if ("" != c.ToString())
                        //            {
                        //                await Task.Delay(chartime);
                        //            }
                        //        }
                        //    }

                        MessageBox.Show("ゲームオーバーです。\r\nあなたは未来の自分を怒らせたせいで１０年後の自分を詳しく知ることができませんでした");
                    }

                }
            }

            if (count == 8 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output10 = "";
                //textBox2.Text = "(説明)";
                await OutputMessage1(aaif);
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

            if (count == 9 && Form5.point == 1)
            {
                string outout = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(aaa1);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        outout += c.ToString();
                        textBox1.Text = outout;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 fmm = new Form10(3);
                DialogResult dr = fmm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string output11 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await OutputMessage2(aaa01);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
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
            }

            if (count == 9 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output12 = "";
                await OutputMessage1(aaaif2);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output12 += c.ToString();
                        textBox1.Text = output12;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

                Form10 fm = new Form10(4);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output13 = "";
                    await OutputMessage2(aaaa001);
                    await OutputMessage2(aaaa002);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            output13 += c.ToString();
                            textBox1.Text = output13;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output13 = "";
                    string G1 = "そう...。ならいいわ。もうアンタに用はない。帰ってちょうだいっ！！";
                    await OutputMessage2(G1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            output13 += c.ToString();
                            textBox1.Text = output13;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    MessageBox.Show("ゲームオーバーです！！\r\nあなたは１０年後のあなたを傷つけてしまい過去を変えることができませんでした。");
                }
            }

            if (count == 10 && Form5.point == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output14 = "";
                await OutputMessage1(aaaa003);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        output14 += c.ToString();
                        textBox1.Text = output14;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }

            if (count == 1 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho1 = "が目を開けた瞬間、彼女は違う場所にテレポートしていた。";
                
                await OutputMessage8(ho);

                await OutputMessage8(ho1);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme += c.ToString();
                        textBox1.Text = putme;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 2 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme2 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho2 = "人気のない場所で、カラスが不気味に鳴いている。日は暮れて、辺りは薄暗中"　+ nko + "の目の前に怪しいネオンのHOTELがそこにあった。";

               

                await OutputMessage8(ho2);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme2 += c.ToString();
                        textBox1.Text = putme2;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 3 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme3 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho3 = "一組のカップルが中から出てくるとその女性と目があった。";
                
               

                await OutputMessage8(ho3);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme3 += c.ToString();
                        textBox1.Text = putme3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme4 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho4 = "その瞬間、彼女の脳裏に衝撃が走った。";
                string ho5 = "目の前に同じ顔をした人物がいたからだ！！　一方目の前の女性も石になったかのように固まっている。";



                await OutputMessage8(ho4);
                await OutputMessage8(ho5);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme4 += c.ToString();
                        textBox1.Text = putme4;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 5 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme5 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho6 = "そしてその女性の口から出た言葉に"　+ nko + "は耳を疑った。";



                await OutputMessage8(ho6);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme5 += c.ToString();
                        textBox1.Text = putme5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 6 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme6 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = Form1.Name1;

                textBox2.Text = N;
                string ho = nko;
                string ho7 = "あの博士の言ってたことが本当だったなんて...";



                await OutputMessage8(ho7);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme6 += c.ToString();
                        textBox1.Text = putme6;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

                Form10 fh = new Form10(5);
                DialogResult dr = fh.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                    pictureBox2.Hide();
                    string putme7 = "";
                    pictureBox1.Image = Properties.Resources.top_photo;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = Form1.Name1;

                    textBox2.Text = N;
                   
                    string ho8 = "70代ぐらいの眼鏡をかけた白衣の男よ。その男が急に現れて私に数日後１０年前の私がタイムマシーンに乗って私の前に現れると言ってきたのよ。";



                    await OutputMessage9(ho8);
                    await Task.Delay(waitTime);
                    async Task OutputMessage9(string ai)
                    {
                        foreach (char c in ai)
                        {
                            putme7 += c.ToString();
                            textBox1.Text = putme7;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }

            if (count == 7 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme8 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._93d75e710b05c34e7279b19fadd7f8dc;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "隣の男性";
                string ho9 = "タイムマシーン？";



                await OutputMessage8(ho9);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme8 += c.ToString();
                        textBox1.Text = putme8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme9 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                

                textBox2.Text = "(説明）";
                string ho = nko;
                string ho10 = N + "の隣にいる男が二人に向かって戸惑った表情で言うと彼女は彼を手で制し、彼に向かって一言口にした。";



                await OutputMessage8(ho10);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme9 += c.ToString();
                        textBox1.Text = putme9;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 9 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme3 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();
              

                textBox2.Text = N;
                string ho = nko;
                string ho11 = "あんたには関係ない。もう用は済んだからとっとと帰って";



                await OutputMessage8(ho11);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme3 += c.ToString();
                        textBox1.Text = putme3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 10 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme11 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = "（説明）";
                string ho = nko;
                string ho12 = "男は彼女にそう言われると去って行った。";



                await OutputMessage8(ho12);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme11 += c.ToString();
                        textBox1.Text = putme11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 11 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme12 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = N;
                string ho = nko;
                string ho13 = "パパ活してるの私...";



                await OutputMessage8(ho13);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme12 += c.ToString();
                        textBox1.Text = putme12;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 12 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme13 = "";
                pictureBox1.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;
                pictureBox2.Hide();
                pictureBox2.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = "（説明）";
                string ho = nko;
                string ho14 = "話を聞くと事の始まりは東京オリンピック後だった。";



                await OutputMessage8(ho14);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme13 += c.ToString();
                        textBox1.Text = putme13;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 13 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme14 = "";
                pictureBox1.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;
                pictureBox2.Hide();
                pictureBox2.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = "（説明）";
                string ho = nko;
                string ho15 = "物価が上がって会社は倒産。失業者があふれ出し、治安の悪化する。街にはホームレスが拡散する世の中になる。";
                string ho16 = "日本で職のない男は海外へ出稼ぎ、若い女性は売春をするのが普通の世の中になる";
                pictureBox2.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;


                await OutputMessage8(ho15);
                await OutputMessage8(ho16);

                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme14 += c.ToString();
                        textBox1.Text = putme14;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 14 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme15 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                //pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = N;
                string ho = nko;
                string ho17 = nko + "も例外ではなかった。";
                pictureBox2.Image = Properties.Resources.R3ab69b54ea7def6ae8a583ddba4901f0;


                await OutputMessage8(ho17);

                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme15 += c.ToString();
                        textBox1.Text = putme15;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 15 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme16 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();


                textBox2.Text = N;
                string ho = nko;
                string ho18 = "仕方なかったのよ。こうするしか....";
                string ho19 = "あんな汚い金持ちオヤジなんて死ねばいいのに";



                await OutputMessage8(ho18);
                await OutputMessage8(ho19);

                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme16 += c.ToString();
                        textBox1.Text = putme16;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 15 && Form5.point == 2)
            {
                pictureBox2.Hide();
                string putme17 = "";
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                axWindowsMediaPlayer1.Ctlcontrols.play();



                string ho = nko;
                string ho20 = "今の話を聞いて私のようになりたいと思った？";



                await OutputMessage8(ho20);

                await Task.Delay(waitTime);
                async Task OutputMessage8(string ai)
                {
                    foreach (char c in ai)
                    {
                        putme17 += c.ToString();
                        textBox1.Text = putme17;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 fm = new Form10(6);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                    pictureBox2.Hide();
                    string putme18 = "";
                    pictureBox1.Image = Properties.Resources.top_photo;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                    axWindowsMediaPlayer1.Ctlcontrols.play();


                    textBox2.Text = N;
                    //string ho = nko;
                    string ho21 = "あなたは絶対後悔するわ。お願いよ過去に戻って未来を変えて！！";




                    await OutputMessage9(ho21);


                    await Task.Delay(waitTime);
                    async Task OutputMessage9(string ai)
                    {
                        foreach (char c in ai)
                        {
                            putme18 += c.ToString();
                            textBox1.Text = putme18;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                   
                }

                if (dr == DialogResult.No)
                {
                    pictureBox2.Hide();
                    string putme18 = "";
                    pictureBox1.Image = Properties.Resources.top_photo;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.s_20150522200925101600;
                    axWindowsMediaPlayer1.Ctlcontrols.play();


                    textBox2.Text = N;
                    //string ho = nko;
                    string ho21 = "そうね。じゃあ私から一つ。プログラマーになって！！　腕のあるプログラマーになれば女性でも稼ぐことができる。そうすればこんな未来にならなくて済む。お願い未来を変えて！！";




                    await OutputMessage9(ho21);


                    await Task.Delay(waitTime);
                    async Task OutputMessage9(string ai)
                    {
                        foreach (char c in ai)
                        {
                            putme18 += c.ToString();
                            textBox1.Text = putme18;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    Form8 fj = new Form8();
                    fj.Show();

                }
            }
            if (count == 1 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                string ka01 =  "がタイムスリップするとそこは病院の中だった。";
                string outp = "";
                await OutputMessage33(nko);
                await OutputMessage33(ka01);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp += c.ToString();
                        textBox1.Text = outp;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if(count == 2 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                string outp2 = "";
                string ka02 = "身の覚えのない場所にテレポートし、困惑するなか1台の担架が";
                string ka03 = nko + "の前を横切る。";
                await OutputMessage33(ka02);
                await OutputMessage33(ka03);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp2 += c.ToString();
                        textBox1.Text = outp2;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 3 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Show();
                string outp3 = "";
                pictureBox2.Image = Properties.Resources.depositphotos_33846719_stock_photo_doctors_moving_patient_on_gurney__1_;
                textBox2.Text = "(説明）";
                string ka04 = "心拍数低下。脈拍２。片山さん大丈夫ですか？　手術室まであともうすぐですからね";
                
                await OutputMessage1(ka04);

                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp3 += c.ToString();
                        textBox1.Text = outp3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                string ka05 = "騒然とする院内。状況がわからない" + nko + "が終始戸惑っていると一人の看護婦が切迫した表情で彼女の前に現れた";
                string outp4 = "";

                await OutputMessage33(ka05);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp4 += c.ToString();
                        textBox1.Text = outp4;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
                if (count == 5 && Form5.point == 3)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = "看護婦A";
                    pictureBox2.Image = Properties.Resources.L_Hypertension_de_la_blouse_blanche__98_1;
                    string ka06 = "やっと見つけた。ちょうどよかったわ"　+ nko + "さん。";
                    string outp5 = "";
                    await OutputMessage33(ka06);

                    await Task.Delay(waitTime);
                    async Task OutputMessage33(string a1)
                    {
                        foreach (char c in a1)
                        {
                            outp5 += c.ToString();
                            textBox1.Text = outp5;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
            }
            if(count == 6 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "看護婦A";
                string ka07 = "夜勤明けで申し訳ないのだけど。昨日６０５号室の患者さんがコロナで症状が悪化したの。人が足りないから至急向かって欲しいのだけど";
                string outp6 = "";
                await OutputMessage33(ka07);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp6 += c.ToString();
                        textBox1.Text = outp6;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 fmx = new Form10(8);
                DialogResult dr = fmx.ShowDialog();
                {
                  if(dr == DialogResult.Yes)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        string ka08 = "どうしたの"　+ nko + "さん？";
                        string outp7 = "";
                        await OutputMessage34(ka08);
                        

                        await Task.Delay(waitTime);
                        async Task OutputMessage34(string a1)
                        {
                            foreach (char c in a1)
                            {
                                outp7 += c.ToString();
                                textBox1.Text = outp7;
                                if ("" != c.ToString())
                                {
                                    await Task.Delay(chartime);
                                }
                            }
                        }
                    }
                }
            }
            if (count == 7 && Form5.point == 3)
            {

                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "謎の女の声";
                string ka09 = nko + "は私ですけど！";
                string outp8 = "";
                await OutputMessage33(ka09);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp8 += c.ToString();
                        textBox1.Text = outp8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
                if(count == 8 && Form5.point == 3)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = "(説明）";
                    pictureBox2.Image = Properties.Resources.Rbd105a46d8193a4635037cfc9a5fe51f;
                    string ka10 = "すると後ろから一人の女性が現れた。その女性はまさしく"　+ N + "だった。";
                    string outp9 = "";
                    await OutputMessage33(ka10);

                    await Task.Delay(waitTime);
                    async Task OutputMessage33(string a1)
                    {
                        foreach (char c in a1)
                        {
                            outp9 += c.ToString();
                            textBox1.Text = outp9;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                
            }
             if(count == 9 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
                string ka11 = "あまりの衝撃に二人はしばらく固まった状態だったが"　+ nko + "が事情を話すと二人は場所を移した。";
                string outp10 = "";
                await OutputMessage33(ka11);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp10 += c.ToString();
                        textBox1.Text = outp10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 10 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                pictureBox1.Image = Properties.Resources.DSC_0012_compressor;
                string ka12 = "つまりあなたはタイムマシンで過去から来たってこと？";
                string outp11 = "";
                await OutputMessage33(ka12);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp11 += c.ToString();
                        textBox1.Text = outp11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 flx = new Form10(9);
                DialogResult dr = flx.ShowDialog();
                if(dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    string ka13 = "信じられない.....";
                    string outp12 = "";
                    await OutputMessage34(ka13);

                    await Task.Delay(waitTime);
                    async Task OutputMessage34(string a1)
                    {
                        foreach (char c in a1)
                        {
                            outp12 += c.ToString();
                            textBox1.Text = outp12;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                
            }
            if (count == 11 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
                string ka14 = "衝撃の告白に10年後の彼女はしばらく茫然としていたが、状況を飲み込んだ彼女は徐に語り出";
                string outp13 = "";
                await OutputMessage33(ka14);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp13 += c.ToString();
                        textBox1.Text = outp13;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 12 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                string ka15 = "あの後日本は...";
                string outp14 = "";
                await OutputMessage33(ka15);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp14 += c.ToString();
                        textBox1.Text = outp14;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 13 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.iStock_120aa_thumb_720xauto_191362;
                pictureBox2.Hide();
                textBox2.Text = "(説明)";
                string ka16 = "彼女の口から出た事実は衝撃的なものだった。";
                string outp15 = "";
                await OutputMessage33(ka16);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp15 += c.ToString();
                        textBox1.Text = outp15;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 14 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
                string ka17 = "世界中を猛威に振るうコロナウイルスは勢いを衰えるどころか次々と変異種が生まれ感染が悪化。今も亡くなる人が後を絶たないという";
                string outp10 = "";
                await OutputMessage33(ka17);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp10 += c.ToString();
                        textBox1.Text = outp10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 15 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                pictureBox2.Show();
                pictureBox1.Image = Properties.Resources.DSC_0012_compressor;
                pictureBox2.Image = Properties.Resources.o0308058114313475205;

                string ka18 = "これが私の息子の写真。３歳だけどもう仕事で半年以上会っていない。こんな状況がいつまでつづくのかしら？　もし私が在宅勤務のできる仕事をしていたら...";
                string outp11 = "";
                await OutputMessage33(ka18);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp11 += c.ToString();
                        textBox1.Text = outp11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 15 && Form5.point == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                pictureBox2.Show();
                pictureBox1.Image = Properties.Resources.DSC_0012_compressor;
                pictureBox2.Image = Properties.Resources.Rbd105a46d8193a4635037cfc9a5fe51f;

                string ka18 = "今の話を聞いて私になりたいと思った？";
                string outp11 = "";
                await OutputMessage33(ka18);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        outp11 += c.ToString();
                        textBox1.Text = outp11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 flx = new Form10(10);
                DialogResult dr = flx.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    string ka14 = "絶対あなたは後悔するわ。家族にも会えないのよ！！。プログラマーなら在宅勤務もできるし、裕福に暮らせる。だからお願い未来を変えて！"
                        ;
                    string outp12 = "";
                    await OutputMessage34(ka14);

                    await Task.Delay(waitTime);
                    async Task OutputMessage34(string a1)
                    {
                        foreach (char c in a1)
                        {
                            outp12 += c.ToString();
                            textBox1.Text = outp12;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    
                }
              
                if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    string ka13 = "そうよね。だからお願い！！プログラマーになって、看護師と違って仕事で子供と離れ離れになることもないし。過去に戻って未来を変えて";
                    string outp12 = "";
                    await OutputMessage34(ka13);

                    await Task.Delay(waitTime);
                    async Task OutputMessage34(string a1)
                    {
                        foreach (char c in a1)
                        {
                            outp12 += c.ToString();
                            textBox1.Text = outp12;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                Form8 fj = new Form8();
                fj.Show();
            }

            if(count == 1 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
                string kek = nko + "がタイムスリップした先は誰かの豪邸だった。";
                string pout1 = "";
                await OutputMessage33(kek);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout1 += c.ToString();
                        textBox1.Text = pout1;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 2 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
                string kek2 =  "天井にはシャンデリアがあり、そばには暖炉もある。初めて目にする物ばかりで圧倒されていると彼女は一つの写真を発見する";
                string pout2 = "";
                await OutputMessage33(kek2);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout2 += c.ToString();
                        textBox1.Text = pout2;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 3 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //textBox2.Text = "女性の声";
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._86_1;
                string kek3 = "それは１組の夫婦の写真であり、イケメン俳優のS似の男性の隣にはウェディングドレスを来た自分がいた。";
                string pout3 = "";
                await OutputMessage33(kek3);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout3 += c.ToString();
                        textBox1.Text = pout3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "女性の声";
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._86_1;
                string kek4 = "誰？";
                string pout4 = "";
                await OutputMessage33(kek4);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout4 += c.ToString();
                        textBox1.Text = pout4;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 5 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.no_translate_detected_23_2147505543;
                string kek5 = "そこにいたのは"　+ N + "だった。";
                string pout5 = "";
                await OutputMessage33(kek5);

                await Task.Delay(waitTime);
                async Task OutputMessage33(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout5 += c.ToString();
                        textBox1.Text = pout5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 6 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.no_translate_detected_23_2147505543;
                string kek6 = "未来の" + N + "は妊娠していて、首にはシャネルのネックレスをしている。";
                string pout6 = "";
                await OutputMessage39(kek6);

                await Task.Delay(waitTime);
                async Task OutputMessage39(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout6 += c.ToString();
                        textBox1.Text = pout6;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 fo = new Form10(11);
                DialogResult dr = fo.ShowDialog();
                if(dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.no_translate_detected_23_2147505543;
                    string kek5 = "過去から？";
                    string pout5 = "";
                    await OutputMessage35(kek5);

                    await Task.Delay(waitTime);
                    async Task OutputMessage35(string a1)
                    {
                        foreach (char c in a1)
                        {
                            pout5 += c.ToString();
                            textBox1.Text = pout5;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 7 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                pictureBox2.Show();
               // pictureBox2.Image = Properties.Resources._86_1;
                string kek4 =　nko + "は事実を話した。タイムスリップしてここに来たことを";
                string pout7 = "";
                await OutputMessage333(kek4);

                await Task.Delay(waitTime);
                async Task OutputMessage333(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout7 += c.ToString();
                        textBox1.Text = pout7;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._86_1;
                string kek6 = "最初は信じてくれなかったが実際にタイムマシーンを見せたり、彼女たちしか知らないエピソードを話していくうちに信じるようになった。";
                string pout8 = "";
                await OutputMessage339(kek6);

                await Task.Delay(waitTime);
                async Task OutputMessage339(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout8 += c.ToString();
                        textBox1.Text = pout8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            
            if (count == 9 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                pictureBox2.Show();
               // pictureBox2.Image = Properties.Resources._86_1;
                string kek111 = "信じられないわ。過去からタイムスリップして来たなんて...";
                string pout666 = "";
                await OutputMessage321(kek111);

                await Task.Delay(waitTime);
                async Task OutputMessage321(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout666 += c.ToString();
                        textBox1.Text = pout666;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

                Form10 fv = new Form10(12);
                DialogResult dr = fv.ShowDialog();
                if(dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    //textBox2.Text = "（説明）";
                    pictureBox2.Show();
                    // pictureBox2.Image = Properties.Resources._86_1;
                    string kek6 = "妊娠しているの私。男の子。まだ３か月だけど";
                    string pout9 = "";
                    await OutputMessage366(kek6);

                    await Task.Delay(waitTime);
                    async Task OutputMessage366(string a1)
                    {
                        foreach (char c in a1)
                        {
                            pout9 += c.ToString();
                            textBox1.Text = pout9;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }

            }
            if (count == 10 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._86_1;
                string kek6 = "そういうと彼女は１０年後の自分について徐に語り出した。";
                string pout8 = "";
                await OutputMessage44(kek6);

                await Task.Delay(waitTime);
                async Task OutputMessage44(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout8 += c.ToString();
                        textBox1.Text = pout8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 11 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._86_1;
                string kek6 = "彼女は知人のつてで年収１億のIT企業の社長と結婚したことやそのおかげで玉の輿になり何不自由なく暮らせていることまで";
                string pout8 = "";
                await OutputMessage45(kek6);

                await Task.Delay(waitTime);
                async Task OutputMessage45(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout8 += c.ToString();
                        textBox1.Text = pout8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = N;
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._86_1;
                string kek10 = "お金持ちと結婚して幸せだわ。しかも顔は私のタイプのイケメンだし";
                string pout10 = "";
                await OutputMessage89(kek10);

                await Task.Delay(waitTime);
                async Task OutputMessage89(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout10 += c.ToString();
                        textBox1.Text = pout10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form5.point == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._86_1;
                string kek11 = "どう？　この話を聞いて私のような人生を送ろうと思った？";
                string pout11 = "";
                await OutputMessage772(kek11);

                await Task.Delay(waitTime);
                async Task OutputMessage772(string a1)
                {
                    foreach (char c in a1)
                    {
                        pout11 += c.ToString();
                        textBox1.Text = pout11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form10 fl = new Form10(13);
                DialogResult dr = fl.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.no_translate_detected_23_2147505543;
                    string kek12 = "そう思ってくれて嬉しいわ。取り敢えず数年後〇○社に入社して、そこでのパーティーで私は今の夫と出会ったの。IT系で倍率は高いけど頑張って";
                    string pout12 = "";
                    await OutputMessage35(kek12);

                    await Task.Delay(waitTime);
                    async Task OutputMessage35(string a1)
                    {
                        foreach (char c in a1)
                        {
                            pout12 += c.ToString();
                            textBox1.Text = pout12;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = N;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.no_translate_detected_23_2147505543;
                    string kek13 = "違う人生を歩みたいならそれはそれでいいかもしれないわね。だって最終的に決めるのはあなただもの。未来はあなた次第で変わる。頑張って！！";
                    string pout12 = "";
                    await OutputMessage35(kek13);

                    await Task.Delay(waitTime);
                    async Task OutputMessage35(string a1)
                    {
                        foreach (char c in a1)
                        {
                            pout12 += c.ToString();
                            textBox1.Text = pout12;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                Form8 fx = new Form8();
                fx.Show();
            }
            
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            button2.Hide();
            sl++;
            if(Form5.point == 1 && sl == 1)
            {
                pictureBox1.Image = Properties.Resources.Rf831f0dc8b672ca58980a1b371b5bc9b;
                pictureBox2.Image = Properties.Resources.Rd7cdd4ae69ee501525c44b828b865b77;
                textBox2.Text =  N;
            }

            if(Form5.point == 2 && sl == 1)
            {
                pictureBox1.Image = Properties.Resources.top_photo;
                pictureBox2.Hide();
                textBox2.Text =  N;
            }

            if(Form5.point == 3 && sl == 1)
            {
                pictureBox1.Image = Properties.Resources.images;
                pictureBox2.Hide();

            }

            if(Form5.point == 4 && sl == 1)
            {
                pictureBox1.Image = Properties.Resources.Rb4ca1dfaf16089a397db73f9e910bf9e;
                pictureBox2.Hide();
            }

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            if(Time == 240)
            {
                button2.Show();
            }
        }
    }
}
