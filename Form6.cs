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
    public partial class Form6 : Form
    {
        int cl = 0;
        static int sen;
        int Time;
        int count;
        string N = Form1.Name1;
        string FN = "10年後の" + Form1.Name1;
        string a = "まさか本当に現れるとは...";
        string aif1x1 = "すごいな博士の言うとおりだ！！本当にタイムマシンが存在していたなんて!!";
        string a1_2 = "彼は急に泣き出した。滝のようにあふれ出し、嗚咽を漏らす姿に";
        string a1_3 = "はかける言葉さえ思いつかない。";
        string aif2x1 = "ありがとう";
        string a2_2 = "しかしその手はすり抜けた。たしかに彼は触れたはずのなのに１０年後の自分に手を触れたはずなのに...";
        string a2_3 = "その光景に";
        string a2_4 = "は驚きを隠せなかった";
        string a2_5 = "びっくりさせちゃってごめん。実は俺、もうこの世にはいないんだ";
        string a2_6 = "死んだのだよ俺。食べる物がなくて";
        string a2_7 = "彼はそう言うと";
        string a2_8 = "は事の詳細を話し始めた。１０年後の日本は借金大国になり、街には失業者が溢れ治安が悪化。日本人が外国に出稼ぎに行く時代になる。物価は上昇し、ニンジンですら買えなくなる時代になる。";
        string a2_9 = "餓死する国民続出。１０年後の";
        string a2_10 = "もその一人だった。";
        string a2_11 = "天国だよ。君がいるのは";
        string a2_12 = "どうだった。この話を聞いて未来の俺になりたいと思った？";
        string a3_1 = "そうだよね。なりたくないよね。じゃあこの最悪な結末の回避の仕方を教えよう。";
        string a3_2 = "実を言うと君はプログラミングの勉強が嫌になり、違う仕事に就くようになる。だけどAIで仕事を取られリストラする。";
        string a3_3 = "プログラマーは未来でも需要のある職業だ。俺からのアドバイスは以上。さようなら";

        string b1 = "まさか本当に来るとは。";
        string bf1 = "おっ俺！？";
        string b2_1 = "そのまさかさ。";
        string b2_2 = "ここにいるのが未来の自分さ";
        string bf2 = "は目を疑った。目の前の自分の目つきは今より鋭くなっていた。さらに髪は金髪で手には何やら怪しいものを持っていたからだ。";

        string bf22 = "(指を指し）それは？";
        string bf2_2 = "見なかったフリをする";
        string b3_1 = "銃だよ";
        string bf3 = "エッ！！";
        string b4 = "仕方なかったんだ日本を変えるためには";
        string b4_2 = "彼はそう言うとことの事情を話始めた。テロリストになった経緯を";
        string b4_3 = "未来の日本はコロナウイルスを機に景気が悪化。さらに東京オリンピックにより国の借金は増し、リーマンショック以上の失業者を生み出した。";
        string b4_4 = "そして菅政権の後にできた新しい内閣が発生した国字永世保険法により、日本はアメリカのように保険のない国へと変貌したのだった。";
        string b4_5 = "コロナ下で病院にもまともにいけないためか国民の怒りは勃発。テロによる事件が多発するようになる。";
        string b4_6 = "も例外ではなかった。";
        string b4_7 = "そして俺はさっき人を殺してきた...";
        string b5 = "エッ？";
        string b5_1 = "いたぞ！あいつだーーーっ！！";
        string b5_2 = "やばい見つかった。頼む過去に戻ってこの運命を変えてくれ";
        string b2in1 = "何だ？　さっきから怯えた顔をしているが怖いのか？";
        public Form6()
        {
            InitializeComponent();
            button1.Hide();
            axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\bgm_maoudamashii_cyber34.mp3");


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            if (Time == 240)
            {
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            button1.Hide();

            cl++;
            if (cl == 1 && Form4.des == 1)
            {

                button1.Hide();
                pictureBox2.Image = Properties.Resources.OIP__2_;
                pictureBox1.Image = Properties.Resources.svpuvja49s8p52807za3cbw1r6il;
                textBox2.Text = "１０年後の" + Form1.Name1;
            }
            if (cl == 1 && Form4.des == 2)
            {
                pictureBox2.Image = Properties.Resources.image_processing20200411_18936_1455ssa;
                pictureBox1.Image = Properties.Resources.l_00010116IMG2;
                textBox2.Text = "１０年後の" + Form1.Name1;
                button1.Hide();
            }
            if (cl == 1 && Form4.des == 3)
            {
                pictureBox2.Hide();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                textBox2.Text = "１０年後の" + Form1.Name1;
                button1.Hide();
            }
            if(cl == 1 && Form4.des == 4)
            {
                pictureBox2.Hide();
                pictureBox1.Image = Properties.Resources.TypicalImageS;
                button1.Hide();
            }

        }

        public void button2_Click(object sender, EventArgs e)
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
            if (count == 1 && Form4.des == 1)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(a);
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
                Form3 fm = new Form3(4);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output2 = "";
                    await OutputMessage2(aif1x1);
                    await Task.Delay(waitTime);
                    sen = 1;
                    async Task OutputMessage2(string a1)
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
                if (dr == DialogResult.No)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string No1 = "そう。そのまさかだよ！。ここにいるのが１０年後の君だ。";
                    string output2 = "";
                    await OutputMessage2(No1);
                    await Task.Delay(waitTime);
                    sen = 2;
                    async Task OutputMessage2(string a1)
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
                if (dr == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output2 = "";
                    string OK1 = "・・・そうか。そんなに俺変わり果ててしまったか...。すまないさよなら";
                    await OutputMessage2(OK1);
                    textBox2.Text = "(悲しそうな顔で)";
                    sen = 3;
                    await Task.Delay(waitTime);
                    sen = 1;
                    async Task OutputMessage2(string a1)
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
                    MessageBox.Show("ゲームオーバーです。あなたは彼を悲しませてしまったため自分の未来を知ることができませんでした。");
                    this.Close();
                }
            }


            if (Form4.des == 1 && count == 2)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                string output3 = "";
                textBox2.Text = "説明";
                N = Form1.Name1;
                await OutputMessage2(a1_2);
                await OutputMessage2(N);
                await OutputMessage2(a1_3);

                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
                Form3 fm = new Form3(5);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    pictureBox2.Image = Properties.Resources.kaisha_20170501164539_thumb_autox380_111361;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    string output4 = "";
                    textBox2.Text = "１０年後の" + Form1.Name1;
                    await OutputMessage3(aif2x1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage3(string a1)
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
            }
            if (Form4.des == 1 && count == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources.handkerchief;
                textBox2.Text = "説明";
                string output5 = "";
                await OutputMessage2(a2_2);
                await OutputMessage2(a2_3);
                await OutputMessage2(N);
                await OutputMessage2(a2_4);
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
            if (Form4.des == 1 && count == 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

                string output6 = "";
                textBox2.Text = "１０年後の" + N;
                pictureBox2.Image = Properties.Resources.handkerchief;
                await OutputMessage2(a2_5);
                await OutputMessage2(a2_6);
                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
            if (Form4.des == 1 && count == 5)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources._5c63a07a3b000033046b3d24;
                textBox2.Text = "１０年後の" + N;
                string output6 = "";
                string nF = N;
                await OutputMessage2(a2_7);
                await OutputMessage2(a2_8);
                await OutputMessage2(a2_9);
                await OutputMessage2(nF);
                await OutputMessage2(a2_10);
                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
            if (Form4.des == 1 && count == 6)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox2.Image = Properties.Resources.OIP__2_;
                string output7 = "";
                await OutputMessage2(a2_11);
                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
            if (Form4.des == 1 && count == 7)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

                string output8 = "";
                string com = "・・・・・";
                textBox2.Text = N;
                await OutputMessage2(com);
                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
            }
            if (Form4.des == 1 && count == 8)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

                string output9 = "";
                textBox2.Text = N;
                string com2 = "天国！！";
                await OutputMessage2(com2);
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
            if (Form4.des == 1 && count == 9)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();

                string output10 = "";
                await OutputMessage2(a2_12);
                await Task.Delay(waitTime);
                async Task OutputMessage2(string a1)
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
                Form3 fm = new Form3(6);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    string output11 = "";
                    await OutputMessage11(a2_12);
                    await Task.Delay(waitTime);
                    async Task OutputMessage11(string a1)
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
                    Form8 fm2 = new Form8();
                    fm2.Show();
                    this.Visible = false;
                }
                if (dr == DialogResult.No || dr == DialogResult.Cancel || dr == DialogResult.OK)
                {

                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    string output11 = "";
                    await OutputMessage11(a3_1);
                    await OutputMessage11(a3_2);
                    await OutputMessage11(a3_3);

                    await Task.Delay(waitTime);
                    async Task OutputMessage11(string a1)
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
                    Form8 fm2 = new Form8();
                    fm2.Show();
                    this.Visible = false;
                }
            }

            if (count == 1 && Form4.des == 2)
            {
                string putout = "";
                textBox2.Text = "１０年後の" + N;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b1);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout += c.ToString();
                        textBox1.Text = putout;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fm = new Form3(7);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putout2 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await OutputMessage2(b2_1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putout2 += c.ToString();
                            textBox1.Text = putout2;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 2 && Form4.des == 2)
            {
                string putout3 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                await OutputMessage8(N);
                await OutputMessage8(bf2);
                await Task.Delay(waitTime);
                async Task OutputMessage8(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout3 += c.ToString();
                        textBox1.Text = putout3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fm = new Form3(8);
                DialogResult dr = fm.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putout4 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = "１０年後の" + N;
                    await OutputMessage9(b3_1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage9(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putout4 += c.ToString();
                            textBox1.Text = putout4;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                if (dr == DialogResult.No)
                {
                    sen = 1;
                    string putout4 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await OutputMessage9(b2in1);
                    await Task.Delay(waitTime);
                    async Task OutputMessage9(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putout4 += c.ToString();
                            textBox1.Text = putout4;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                    Form3 fn1 = new Form3(9);
                    DialogResult dr2 = fn1.ShowDialog();
                    if (dr2 == DialogResult.Yes)
                    {
                        string putout5 = "";
                        string x1 = "見てバレバレだぞ。俺が本物の銃を持っているからだろ？";
                        //string x = "そう、未来のお前は....";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        await OutputMessage10(x1);
                        await Task.Delay(waitTime);
                        async Task OutputMessage10(string a1)
                        {
                            foreach (char c in a1)
                            {
                                putout5 += c.ToString();
                                textBox1.Text = putout5;
                                if ("" != c.ToString())
                                {
                                    await Task.Delay(chartime);
                                }
                            }
                        }
                        //MessageBox.Show("ゲームオーバー！！\r\nプレイヤーはあまりの恐怖に逃げてしまい、未来の自分を知ることが出来ませんでした");
                        Form3 fl = new Form3(10);
                        DialogResult dr3 = fl.ShowDialog();
                        if (dr3 == DialogResult.Yes)
                        {
                            string putout6 = "";
                            string x2 = "仕方ない。１０年後のお前は何やっているのか詳しく話そう。１０年後お前は・・・";
                            //string x = "そう、未来のお前は....";
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                            await OutputMessage11(x2);
                            await Task.Delay(waitTime);
                            async Task OutputMessage11(string a1)
                            {
                                foreach (char c in a1)
                                {
                                    putout6 += c.ToString();
                                    textBox1.Text = putout6;
                                    if ("" != c.ToString())
                                    {
                                        await Task.Delay(chartime);
                                    }
                                }
                            }
                            MessageBox.Show("ゲームオーバー！！\r\n彼の話を聞いたプレイヤーはあまりの怖さに逃げてしまいました。");
                        }

                    }
                    if (dr2 == DialogResult.No)
                    {
                        string putout5 = "";
                        string x1 = "銃だよ。実は俺はさっき";
                        //string x = "そう、未来のお前は....";
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        await OutputMessage10(x1);
                        await Task.Delay(waitTime);
                        async Task OutputMessage10(string a1)
                        {
                            foreach (char c in a1)
                            {
                                putout5 += c.ToString();
                                textBox1.Text = putout5;
                                if ("" != c.ToString())
                                {
                                    await Task.Delay(chartime);
                                }
                            }
                        }
                        MessageBox.Show("ゲームオーバー！！\r\n真相を聞かされたプレイヤーは怖くなって逃げてしまいました。");
                    }
                }
            }
            if (count == 3 && Form4.des == 2)
            {
                string putout5 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox1.Text = N;
                await OutputMessage1(bf3);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout5 += c.ToString();
                        textBox1.Text = putout5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }


            }
            if (count == 4 && Form4.des == 2)
            {
                string putout6 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "10年後の" + N;
                await OutputMessage1(b4);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout6 += c.ToString();
                        textBox1.Text = putout6;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form4.des == 2)
            {
                string putout7 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b4_2);
                textBox2.Text = "(説明)";
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout7 += c.ToString();
                        textBox1.Text = putout7;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 5 && Form4.des == 2)
            {
                string putout8 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b4_3);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout8 += c.ToString();
                        textBox1.Text = putout8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 6 && Form4.des == 2)
            {
                string putout9 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b4_4);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout9 += c.ToString();
                        textBox1.Text = putout9;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 7 && Form4.des == 2)
            {
                string putout10 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b4_5);
                await OutputMessage1(N);
                await OutputMessage1(b4_6);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout10 += c.ToString();
                        textBox1.Text = putout10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form4.des == 2)
            {
                string putout11 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "１０年後の" + N;
                await OutputMessage1(b4_7);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout11 += c.ToString();
                        textBox1.Text = putout11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 9 && Form4.des == 2)
            {
                string putout12 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b5);
                textBox2.Text = N;
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout12 += c.ToString();
                        textBox1.Text = putout12;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 10 && Form4.des == 2)
            {
                string putout13 = "";
                axWindowsMediaPlayer1.URL = Path.GetFullPath(@"..\..\oto\大勢の人が走る.mp3");
                pictureBox2.Image = Properties.Resources.maxresdefault;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "警備員たち";
                await OutputMessage1(b5_1);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout13 += c.ToString();
                        textBox1.Text = putout13;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 11 && Form4.des == 2)
            {
                string putout14 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await OutputMessage1(b5_2);
                await Task.Delay(waitTime);
                async Task OutputMessage1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putout14 += c.ToString();
                        textBox1.Text = putout14;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form8 fn = new Form8();
                fn.Show();
            }

            if (count == 1 && Form4.des == 3)
            {
                string putput01 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Hide();
                string tam1 = N + "がタイムスリップした先は誰かの家の中だった。";
                await Message1(tam1);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput01 += c.ToString();
                        textBox1.Text = putput01;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 2 && Form4.des == 3)
            {
                string putput02 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                textBox2.Text = "(説明）";
                pictureBox2.Hide();
                string tam2 = "突然見ず知らずの人の家にテレポートし、一瞬困惑するが１枚の写真を見てその正体が判明する";
                await Message1(tam2);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput02 += c.ToString();
                        textBox1.Text = putput02;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 3 && Form4.des == 3)
            {
                string putput03 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._521aac2d6afe39d3c91647b11c1be265c4c2e07a;
                string tam3 = "そこにはなんと自分が写っていたのだ。未来の家族なのだろうか？　そこには女優の広瀬すずに似た女性と子供の姿が写っていた。";
                await Message1(tam3);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput03 += c.ToString();
                        textBox1.Text = putput03;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form4.des == 3)
            {
                string putput04 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                textBox2.Text = "女性の声";
                pictureBox2.Image = Properties.Resources._521aac2d6afe39d3c91647b11c1be265c4c2e07a;
                string tam4 = "おかえりなさいアナタ";
                await Message1(tam4);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput04 += c.ToString();
                        textBox1.Text = putput04;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

            }
            if (count == 5 && Form4.des == 3)
            {
                string putput05 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._46801e428c19d40a50cb510160b915cec51203f6e76cf5eeb0a1913d184772200ae72248ecf424483796e1616364a126067464d75f6ce66aaa9acdf2f9da9169;
                string tam5 = "振り向くと広瀬すず似の女性がいた。あまりにも似ている美人の女性を前に" + "は言葉を失っていた。";
                await Message1(tam5);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput05 += c.ToString();
                        textBox1.Text = putput05;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 6 && Form4.des == 3)
            {
                string putput06 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "謎の女性";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources._521aac2d6afe39d3c91647b11c1be265c4c2e07a;
                string tam6 = "（微笑みながら）どうしたの？　そんな怖い顔して？";
                await Message1(tam6);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput06 += c.ToString();
                        textBox1.Text = putput06;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 7 && Form4.des == 3)
            {
                string putput07 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "男の声";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam7 = "ただいまー";
                await Message1(tam7);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput07 += c.ToString();
                        textBox1.Text = putput07;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form4.des == 3)
            {
                string putput08 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "子供";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.istockphoto_1161993846_612x612;
                string tam8 = "ただいまママ";
                await Message1(tam8);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput08 += c.ToString();
                        textBox1.Text = putput08;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

            }
            if (count == 9 && Form4.des == 3)
            {
                string putput10 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam6 = "お客さんか？　すず";
                await Message1(tam6);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput10 += c.ToString();
                        textBox1.Text = putput10;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 10 && Form4.des == 3)
            {
                string putput11 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam7 = N + "が後ろを振り向くと場が凍り付いた。";
                await Message1(tam7);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput11 += c.ToString();
                        textBox1.Text = putput11;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 11 && Form4.des == 3)
            {
                string putput12 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "子供";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.istockphoto_1161993846_612x612;
                string tam8 = "パパが二人いる！！";
                await Message1(tam8);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput12 += c.ToString();
                        textBox1.Text = putput12;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 12 && Form4.des == 3)
            {
                string putput13 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "広瀬すず";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._46801e428c19d40a50cb510160b915cec51203f6e76cf5eeb0a1913d184772200ae72248ecf424483796e1616364a126067464d75f6ce66aaa9acdf2f9da9169;
                string tam9 = "噓でしょ.....";
                await Message1(tam9);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput13 += c.ToString();
                        textBox1.Text = putput13;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 13 && Form4.des == 3)
            {
                string putput14 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Hide();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam10 = N + "が事の事情を話すと彼は唖然としながらも納得してくれた。";
                await Message1(tam10);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput14 += c.ToString();
                        textBox1.Text = putput14;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 14 && Form4.des == 3)
            {
                string putput15 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam11 = "つまり君は１０年前からタイムスリップしてきたということか？";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput15 += c.ToString();
                        textBox1.Text = putput15;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

                Form3 fd = new Form3(11);
                DialogResult dr = fd.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putput16 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                    string tam6 = "信じられないな...";
                    await Message2(tam6);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putput16 += c.ToString();
                            textBox1.Text = putput16;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 15 && Form4.des == 3)
            {
                string putput17 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam11 = "そう言うと１０年後の彼は広瀬すずと結婚した経緯を語り出した。";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput17 += c.ToString();
                        textBox1.Text = putput17;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

            }
            if (count == 16 && Form4.des == 3)
            {
                string putput18 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();

                pictureBox1.Image = Properties.Resources.shutterstock_263905937;
                pictureBox2.Hide();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam12 = "仕事の出張でたまたま彼女の地元である静岡に転勤していた彼はケガをしていた一人の女性を助けることとなる。";
                await Message1(tam12);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput18 += c.ToString();
                        textBox1.Text = putput18;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 17 && Form4.des == 3)
            {
                string putput19 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();

                pictureBox1.Image = Properties.Resources.shutterstock_263905937;
                pictureBox2.Hide();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam11 = "その女性が偶然広瀬すずの母だと知り、その女性と親交を深めることとなる。";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput19 += c.ToString();
                        textBox1.Text = putput19;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 18 && Form4.des == 3)
            {
                string putput19 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Hide();
                pictureBox1.Image = Properties.Resources.shinzoku_tomesode_images;
                string tam11 = "そしてその女性が彼を気に入り、すずを紹介し、めでたく結婚したということだった。";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput19 += c.ToString();
                        textBox1.Text = putput19;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 19 && Form4.des == 3)
            {
                string putput19 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam11 = "つまり俺は逆玉したってことさ！　ハハハハハッ！";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput19 += c.ToString();
                        textBox1.Text = putput19;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 20 && Form4.des == 3)
            {
                string putput20 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                pictureBox1.Image = Properties.Resources.IMGP8400_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string tam11 = "どうだ？お前も羨ましいと思ったか？";
                await Message1(tam11);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putput20 += c.ToString();
                        textBox1.Text = putput20;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }

                Form3 flx = new Form3(11);
                DialogResult dr = flx.ShowDialog();
                if (dr == DialogResult.Yes)
                {

                    string putput19 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                    string tam12 = "まあ焦るな。ただ一つ忠告なもっと思いやりを持て。そうすれば人との縁が広がる";
                    await Message2(tam12);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putput19 += c.ToString();
                            textBox1.Text = putput19;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }


                }
                
                if (dr == DialogResult.No)
                {

                    string putput19 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    pictureBox2.Show();
                    pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                    string tam12 = "へっ、すねたか。じゃあもっといい女捕まえろよ";
                    await Message2(tam12);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putput19 += c.ToString();
                            textBox1.Text = putput19;
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
           if(count == 1 && Form4.des == 4)
            {
                string putke1 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
               // pictureBox1.Image = Properties.Resources.IMGP8400_1;
               // pictureBox2.Show();
               // pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string ftext01 = N + "がタイムスリップすると街はまるでSFの世界のようになっていた。";
                await Message1(ftext01);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke1 += c.ToString();
                        textBox1.Text = putke1;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 2 && Form4.des == 4)
            {
                string putke2 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string ftext02 =  "急に見知らぬ場所にテレポートして戸惑う"　+ N + "。すると1枚の新聞が彼の足元に落ちる";
                await Message1(ftext02);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke2 += c.ToString();
                        textBox1.Text = putke2;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 3 && Form4.des == 4)
            {
                string putke3 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                 pictureBox1.Image = Properties.Resources.roto_1;
                pictureBox2.Show();
                pictureBox2.Image = Properties.Resources._061e8129d08c3eb883c7b717df50c3f2;
                string ftext03 = "そこには10億円が当たったという記事に"　+ N + "の名前と写真があった。";
                await Message1(ftext03);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke3 += c.ToString();
                        textBox1.Text = putke3;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 4 && Form4.des == 4)
            {
                string putke4 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                // pictureBox2.Image = Properties.Resources.pngtree_professional_manager_png_image_30907;
                string ftext04 = "思わぬ出来事に"　+ N + "は唖然としてしまう。そんな中突然一台の高級車が彼の目の前に停まった。";
                await Message1(ftext04);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke4 += c.ToString();
                        textBox1.Text = putke4;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 5 && Form4.des == 4)
            {
                string putke2 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox1.Image = Properties.Resources.shutterstock_758655235_min;
                 pictureBox2.Show();
                 pictureBox2.Image = Properties.Resources._00;
                //string ftext02 = "急に見知らぬ場所にテレポートして戸惑う" + N + "。すると1枚の新聞が彼の足元に落ちる";
                //await Message1(ftext02);

                //await Task.Delay(waitTime);
                //async Task Message1(string a1)
                //{
                //    foreach (char c in a1)
                //    {
                //        putke2 += c.ToString();
                //        textBox1.Text = putke2;
                //        if ("" != c.ToString())
                //        {
                //            await Task.Delay(chartime);
                //        }
                //    }
                //}
            }
            if (count == 6 && Form4.des == 4)
            {
                string putke2 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "（説明）";
                pictureBox1.Image = Properties.Resources.shutterstock_758655235_min;
                // pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.aa4f703e0b5c9773aab8890c7629a693;
                //string ftext02 = "急に見知らぬ場所にテレポートして戸惑う" + N + "。すると1枚の新聞が彼の足元に落ちる";
                //await Message1(ftext02);

                //await Task.Delay(waitTime);
                //async Task Message1(string a1)
                //{
                //    foreach (char c in a1)
                //    {
                //        putke2 += c.ToString();
                //        textBox1.Text = putke2;
                //        if ("" != c.ToString())
                //        {
                //            await Task.Delay(chartime);
                //        }
                //    }
                //}
            }
            if (count == 7 && Form4.des == 4)
            {
                string putke5 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
                 pictureBox1.Image = Properties.Resources.shutterstock_758655235_min;
                // pictureBox2.Show();
                 pictureBox2.Image = Properties.Resources.watermark;
                string ftext05 = "君、俺にそっくりだね！";
                await Message1(ftext05);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke5 += c.ToString();
                        textBox1.Text = putke5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 8 && Form4.des == 4)
            {
                string putke5 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明）";
                //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                //// pictureBox2.Show();
                //pictureBox2.Image = Properties.Resources.watermark;
                string ftext05 = "車から降りてきた男は金ピカのロレックスの時計に高そうなスーツを着た男性でその顔はまさしく自分とそっくりだった。";
                await Message1(ftext05);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke5 += c.ToString();
                        textBox1.Text = putke5;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fx = new Form3(12);
                DialogResult dr = fx.ShowDialog();
                if(dr == DialogResult.Yes)
                {
                    string putke6 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = "(説明）";
                    //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    //// pictureBox2.Show();
                    //pictureBox2.Image = Properties.Resources.watermark;
                    string ftext06 = "奇遇だね。それ俺だよ!!";
                    await Message2(ftext06);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putke6 += c.ToString();
                            textBox1.Text = putke6;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 9 && Form4.des == 4)
            {
                string putke7 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = "(説明)";
               // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.watermark;
                string ftext07 = N + "は驚いた。まさか本当に１０年後の自分に会えるとは...";
                await Message1(ftext07);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke7 += c.ToString();
                        textBox1.Text = putke7;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
            }
            if (count == 10 && Form4.des == 4)
            {
                string putke8 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
               // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.watermark;
                string ftext08 = "なんだか君を見ていると昔の自分を思い出すんだけど、名前は何て言うの？";
                await Message1(ftext08);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke8 += c.ToString();
                        textBox1.Text = putke8;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fx = new Form3(13);
                DialogResult dr = fx.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putke6 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = "(説明）";
                    //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    //// pictureBox2.Show();
                    //pictureBox2.Image = Properties.Resources.watermark;
                    string ftext06 = "すると最初は納得してくれなかったが実際にタイムマシーンを見せたり、個人情報を言い当てていくうちに彼は信じるようになった。";
                    await Message2(ftext06);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putke6 += c.ToString();
                            textBox1.Text = putke6;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 11 && Form4.des == 4)
            {
                string putke7 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                textBox2.Text = FN;
               // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.watermark;
                string ftext07 =  "どうりて顔が似ているわけだ。すごいなタイムマシーンって！！";
                await Message1(ftext07);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke7 += c.ToString();
                        textBox1.Text = putke7;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fx = new Form3(14);
                DialogResult dr = fx.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putke6 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    //// pictureBox2.Show();
                    //pictureBox2.Image = Properties.Resources.watermark;
                    string ftext06 = "仕事はしてない。だって１０億円手にしたんだからね。今は白金の方に家を建てて、愛人１０人と楽しく暮らしているよ。";
                    await Message2(ftext06);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putke6 += c.ToString();
                            textBox1.Text = putke6;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
            }
            if (count == 12 && Form4.des == 4)
            {
                string putke9 = "";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
               // pictureBox1.Image = Properties.Resources.IMGP8400_1;
                // pictureBox2.Show();
                pictureBox2.Image = Properties.Resources.watermark;
                string ftext09 = "どうだい？俺のような人生を送りたいと思った？";
                await Message1(ftext09);

                await Task.Delay(waitTime);
                async Task Message1(string a1)
                {
                    foreach (char c in a1)
                    {
                        putke9 += c.ToString();
                        textBox1.Text = putke9;
                        if ("" != c.ToString())
                        {
                            await Task.Delay(chartime);
                        }
                    }
                }
                Form3 fx = new Form3(15);
                DialogResult dr = fx.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    string putke6 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    //// pictureBox2.Show();
                    //pictureBox2.Image = Properties.Resources.watermark;
                    string ftext06 = "わかった。じゃあ特別に宝くじの番号を教えるよ。ロト６の番号は１＊＊＊＊＊だ。";
                    await Message2(ftext06);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putke6 += c.ToString();
                            textBox1.Text = putke6;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                if (dr == DialogResult.No)
                {
                    string putke6 = "";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    textBox2.Text = FN;
                    //pictureBox1.Image = Properties.Resources.IMGP8400_1;
                    //// pictureBox2.Show();
                    //pictureBox2.Image = Properties.Resources.watermark;
                    string ftext06 = "それは残念だね。せっかく当選した番号を教えようと思ってたのに。";
                    await Message2(ftext06);

                    await Task.Delay(waitTime);
                    async Task Message2(string a1)
                    {
                        foreach (char c in a1)
                        {
                            putke6 += c.ToString();
                            textBox1.Text = putke6;
                            if ("" != c.ToString())
                            {
                                await Task.Delay(chartime);
                            }
                        }
                    }
                }
                Form8 fm = new Form8();
                fm.Show();
            }
            

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
