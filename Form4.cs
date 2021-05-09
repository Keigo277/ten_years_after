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
    public partial class Form4 : Form
    {
        static public int des;
        static public int score = 0;
        int question = 1;
        int judge;
        int gil;
        int total = 10;

        public Form4()
        {
            InitializeComponent();
            Qshow(question);
            total = 10;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonTag = Convert.ToInt32(btn.Tag);
            if (buttonTag == judge)
            {
                score++;
            }

            if (question == total)
            {

                this.Visible = false;
                Judgement(score);
            }

            question++;
            Qshow(question);
        }

           public void Judgement(int dista)
        {
            if(score >= 0 && score <=2)
            {
                des = 1;
            }
            if (score >= 3 && score <= 4)
            {
                des = 2;
            }
            if (score >= 5 && score <= 7)
            {
                des = 3;
            }
            if (score >= 8 && score <= 10)
            {
                des = 4;
            }
            //if (score >= 9 && score <= 10)
            //{
            //    des = 5;
            //}
            //if (score >= 11 && score <= 15)
            //{
            //    des = 6;
            //}
            //if (score >= 16 && score <= 17)
            //{
            //    des = 7;
            //}
            //if (score == 18)
            //{
            //    des = 8;
            //}
            //if (score == 19)
            //{
            //    des = 9;
            //}
            //if (score == 20)
            //{
            //    des = 20;
            //}
        }
        private void Qshow(int num)
        {
            switch (num)
            {
                case 1:
                    label1.Text = "Q1.あなたの家族構成は？";
                    button1.Text = "A.一人っ子";
                    button2.Text = "B.弟か妹がいる";
                    button3.Text = "C.兄または姉がいる";
                    button4.Text = "D.両方共いる";
                    judge = 4;
                    pictureBox2.Image = Properties.Resources.img_424673_5037906_1;

                    break;
                case 2:
                    label1.Text = "Q２.結婚していますか？";
                    button1.Text = "A.独身";
                    button2.Text = "B.相手がいて近々する予定である";
                    button3.Text = "C.している";
                    button4.Text = "D.もうすでにしていて、子供がいる。";
                    judge = 4;
                    pictureBox2.Image = Properties.Resources._00_36;
                    break;
                case 3:
                    label1.Text = "Q3.１０年後のビジョンはありますか？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    judge = 4;
                    pictureBox2.Image = Properties.Resources.dee320b2f7211625b33ab7794adede66_t;
                    break;
                case 4:
                    label1.Text = "Q4この写真はを見てどう思う？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    judge = 4;
                    break;
                case 5:
                    label1.Text = "Q5この絵はある画家が描いた絵です。彼はこの絵で巨万の富を得ました。あなたがもしそのアーティストなら題名は何にする？？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    judge = 4;
                    pictureBox2.Image = Properties.Resources.banksy2_super_169;
                    break;
                case 6:
                    label1.Text = "Q6あなたは将来の仕事のためにオンラインで英語を学んでいます。次の写真の中でどの先生を選ぶ？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    pictureBox2.Image = Properties.Resources.creative_call_center_avatar_beispiel_23_2147939059;
                    judge = 4;
                    break;
                case 7:
                    label1.Text = "Q7次の計算式を解け";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    judge = 4;
                    break;
                case 8:
                    label1.Text = "Q８次のセリフの空欄に言葉を入れるとしたらどれ？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    pictureBox2.Image = Properties.Resources.que_10220262450;
                    judge = 4;
                    break;
                case 9:
                    label1.Text = "Q９あなたがサンタさんを信じていたのは何歳まででしたか？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    pictureBox2.Image = Properties.Resources.sannta2_e1540239811842;
                    judge = 4;
                    break;
                case 10:
                    label1.Text = "Q１０あなたがサッカーをするならどこのポジションが良い？";
                    button1.Text = "A.ない";
                    button2.Text = "B.いまのままでいい";
                    button3.Text = "C.ある";
                    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                    pictureBox2.Image = Properties.Resources._20130603_honda_mtk;
                    judge = 4;
                    break;
                //case 11:
                //    label1.Text = "Q１１このキャラクターの気持ちになって以下のセリフを選択してください？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources.エース名言;
                //    judge = 4;
                //    break;
                //case 12:
                //    label1.Text = "Q１２何か面白いことを言ってください";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //   pictureBox2.Image = Properties.Resources.E99DA2E799BDE38184EFBC8FE6A5BDE38197E38184;
                //    judge = 4;
                //    break;
                //case 13:
                //    label1.Text = "Q13あなたはうっそうと茂った森の中を歩いています。しばらく進むと視界が少し開けたようです。その先に合ったものは？？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources.path_mac_wallpaper_scenic_landscapes_sun_lovely_seasons_tracks_colored_sunlight_nature_tablet_fresh_bright_sunbeams_trail_peace_leaves_spring_trees_forest;
                //    judge = 4;
                //    break;
                //case 14:
                //    label1.Text = "Q１５あなたはが好きな歴史上の人物は次の中の誰ですか？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources.unnamed;
                //    judge = 4;
                //    break;
                //case 15:
                //    label1.Text = "Q１６心理テスト終了まであと少しです今の気分は？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources._66ee0e9304c075cbf9518ea1e62cdd517d0f1628f123efc5b76a927d1f467bd1b19cef3077895481940018d6e8f87e40e89cfd3aaa7b06051663c87995e608af;
                //    judge = 4;
                //    break;
                //case 16:
                //    label1.Text = "Q１７次の問題に答えなさい";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    judge = 4;
                //    break;
                //case 17:
                //    label1.Text = "Q１８あなたはこの訓練を修了したら何になりたいですか？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources._314454641;
                //    judge = 4;
                //    break;
                //case 18:
                //    label1.Text = "Q１９あなたは今エンジニアという仕事についてどういう印象ですか？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources.thumbnail_column_37;
                //    judge = 4;
                //    break;
                //case 19:
                //    label1.Text = "Q１９あなたがもしお金持ちになったら何になりたい？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources._328_main;
                //    judge = 4;
                //    break;
                //case 20:
                //    label1.Text = "Q２０生まれ変わったら何になりたい？";
                //    button1.Text = "A.ない";
                //    button2.Text = "B.いまのままでいい";
                //    button3.Text = "C.ある";
                //    button4.Text = "D.１０年後だけではなく、老後までのプランがある。";
                //    pictureBox2.Image = Properties.Resources.self_image1;
                //    judge = 4;
                //    break;

            }


        }

        
    }
}
