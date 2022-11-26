using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace winform8
{


    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        int locationNum = 0;
        int score = 0;
       // int misses = 0;
        bool isHit = false;
        int time = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void moveMole()
        {
            isHit = false;
            Mole.Enabled = true;
            Mole.Image = Properties.Resources.민머리두지_진품_진품;
            Mole.BackColor = System.Drawing.Color.Transparent;
            locationNum = rnd.Next(1, 9);
            switch (locationNum)
            {
                case 1:
                    Mole.Left = 42;
                    Mole.Top = 80;
                    break;
                case 2:
                    Mole.Left = 242;
                    Mole.Top = 80;
                    break;
                case 3:
                    Mole.Left = 438;
                    Mole.Top = 80;
                    break;
                case 4:
                    Mole.Left = 143;
                    Mole.Top = 204;
                    break;
                case 5:
                    Mole.Left = 338;
                    Mole.Top = 204;
                    break;
                case 6:
                    Mole.Left = 41;
                    Mole.Top = 330;
                    break;
                case 7:
                    Mole.Left = 240;
                    Mole.Top = 330;
                    break;
                case 8:
                    Mole.Left = 437;
                    Mole.Top = 330;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            Mole.Image = Properties.Resources.찐두지_진품;
            isHit = true;
            Mole.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            D_score.Text = "점수: " + score;
           // lblMiss.Text = "Miss: " + misses;

            if (isHit == false)
            {
                score--;
            }

            if (score > 15)
            {
                timer1.Stop();
                timer2.Stop();
                Mole.Enabled = false;
                MessageBox.Show("You Win");
            }
            moveMole();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            time -= 1;
            if (time == -1) { 
            timer1.Stop();
            timer2.Stop();
            Mole.Enabled = false;
            DialogResult dr=MessageBox.Show("Time over","", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    StreamWriter writer;
                    writer = File.AppendText("test1.txt");         //Text File이 저장될 위치(파일명) 
                                                                   //파일 이름만 지정하면 컴파일된 폴더내 해당 파일 이름으로 저장됨
                    writer.WriteLine("점수  " + score);

                    writer.Close();

                    // StreamWriter writer_;
                    //String strFilePath = "C:\\test.txt";
                    // writer_ = File.CreateText(strFilePath);
                    // writer_.Write(D_score.Text = "점수: " + score);
                    // writer_.Close();
                    Form3 _Form3 = new Form3();
                    _Form3.Show();
                }
            }
            else
            tim.Text = "남은 시간 : " + (time % 100);
        }

       

        
    }
}
