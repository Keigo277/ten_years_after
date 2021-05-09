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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            ShowAnswer();
        }

        public void ShowAnswer()
        {
            if(Form4.des == 1)
            {
                label2.Text = "幽霊"; 
                textBox1.Text = "\n\n\n・年収:０円\r\n・地位：貧乏人\r\n・結婚の有無：していない\r\n・趣味：ギャンブルとお酒\r\n・あなたへのメッセージ：\r\n１０年後のあなたは亡くなって生前頃を後悔しています。プログラミングの勉強を放棄し、違う仕事に就いたためかホームレスになり餓死しました。こうなりたくなければ楽ばかり求めず毎日努力しましょう。";
                pictureBox1.Image = Properties.Resources._69804569a151d7e1940996244f8d49c9_t;
            }
            if (Form4.des == 2)
            {
                label2.Text = "テロリスト"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:？円\r\n・地位：反逆者\r\n・結婚の有無：バツイチ（妻と子死別）\r\n・趣味：生きていくので精一杯\r\n・あなたへのメッセージ：\r\n１０年後のあなたは国の運命に翻弄され、妻と子供を病で失ってしまいます。その多いな原因はお金が無かったからです。もしものことを考え貯金はしときましょう。そうすれば家族を失うことはなかったはずです。";
                pictureBox1.Image = Properties.Resources.war_terrorist;
            }
            if (Form4.des == 3)
            {
                label2.Text = "逆玉"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:？円\r\n・地位：勝ち組\r\n・結婚の有無：している。\r\n・趣味：ゴルフと海外旅行\r\n・あなたへのメッセージ：\r\nこの幸せ者め。";
                pictureBox1.Image = Properties.Resources.wedding_syukufuku;
            }
            if (Form4.des == 4)
            {
                label2.Text = "宝くじに当たった人"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:１０億円\r\n・地位：大富豪\r\n・結婚の有無：していない\r\n・趣味：ギャンブルや女遊び\r\n・あなたへのメッセージ：\r\nおめでとうございます。１０年後のあなたは勝ち組です。ただし少しお金遣いが荒いようです。破産する可能性もあるので貯金しておきましょう。";
                pictureBox1.Image = Properties.Resources.money_okanemochi;
            }
            if (Form4.des == 5)
            {
                label2.Text = "無職"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:０円\r\n・地位：貧乏人\r\n・結婚の有無：していない\r\n・趣味：ギャンブルとお酒\r\n・あなたへのメッセージ：\r\n１０年後のあなたは会社からリストラされて定食にもついていません。その上のがギャンブルにはまり、借金生活です。今の私みたいになってほしくないので浪費癖を改めましょう。";
                pictureBox1.Image = Properties.Resources._69804569a151d7e1940996244f8d49c9_t;
            }
            if (Form5.point == 1)
            {
                label2.Text = "無職(独り身）"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:8万円\r\n・地位：貧乏人\r\n・結婚の有無：していない\r\n・趣味：お酒と一人カラオケ\r\n・あなたへのメッセージ：\r\n１０年後のあなたは結婚してもわがままが強すぎるせいで夫に愛想を尽かされ離婚を繰り返してしまいます。もう少し話を聞く耳を持ちましょう。それと出費はほどほどに";
                pictureBox1.Image = Properties.Resources.neet_woman2;
            }
            if (Form5.point == 2)
            {
                label2.Text = "パパ活女子"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:３００万～８００万円\r\n・地位：不良少女\r\n・結婚の有無：していない\r\n・趣味：エステやホスト、ブランド物集め\r\n・あなたへのメッセージ：\r\nもっとご自身の身体を大事にしてください。パパ活で稼げるのは若いうちだけ、将来のことを考えて真面目にコツコツ頑張りましょう";
                pictureBox1.Image = Properties.Resources.money_fuyouhin_woman_auction;
            }
            if (Form5.point == 3)
            {
                label2.Text = "看護婦"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:300万円\r\n・地位：一般市民\r\n・結婚の有無：していたが離婚（子供いる）\r\n・趣味：子供と遊ぶこと\r\n・あなたへのメッセージ：\r\n１０年後のあなたは頑張りすぎです。仕事でプライベートの時間を犠牲にしているためか少し鬱になっている。もっと肩の力を抜いて自分に正直になってみましょう。";
                pictureBox1.Image = Properties.Resources.nurse_cap;
            }
            if (Form5.point == 4)
            {
                label2.Text = "玉の輿"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:億越え（何もしなくても）\r\n・地位：勝ち組\r\n・結婚の有無：している\r\n・趣味：料理やショッピング\r\n・あなたへのメッセージ：\r\n何も言うことありません。この調子でバラ色の人生を送ってください。";
                pictureBox1.Image = Properties.Resources.wedding_syukufuku;
            }
            if (Form4.des == 10)
            {
                label2.Text = "無職"; // 亡霊　　　女　亡霊
                textBox1.Text = "\n\n\n・年収:０円\r\n・地位：貧乏人\r\n・結婚の有無：していない\r\n・趣味：ギャンブルとお酒\r\n・あなたへのメッセージ：\r\n１０年後のあなたは会社からリストラされて定食にもついていません。その上のがギャンブルにはまり、借金生活です。今の私みたいになってほしくないので浪費癖を改めましょう。";
                pictureBox1.Image = Properties.Resources._69804569a151d7e1940996244f8d49c9_t;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
