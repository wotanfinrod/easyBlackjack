using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _21_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rsgl = new Random();
        int oyuncupuan;
        int pcpuan;
        int oyuncukart;
        int pckart;
        int sayac = 0;
int sayacpc = 0;
SoundPlayer kartatma = new SoundPlayer(Properties.Resources.cardPlace4);
SoundPlayer kazandin = new SoundPlayer(Properties.Resources._14488_fanfare10);
SoundPlayer kaybettin = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);

        void yenidenbasla() 
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Visible = false;
           
           
            lbloyuncu.Text = "00";
            lblpc.Text = "00";
            sayac = 0;
            oyuncupuan = 0;
            pcpuan = 0;
            sayacpc = 0;



        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            kartatma.Play();
            if (sayac == 1)
            {
                pictureBox1.Visible = true;
                pictureBox1.BringToFront();
                oyuncukart = rsgl.Next(1, 11);
                oyuncupuan += oyuncukart;
                lbloyuncu.Text = oyuncupuan.ToString();
                if (oyuncukart == 1)pictureBox1.Image = Properties.Resources.ace_of_clubs;   
                if (oyuncukart == 2) pictureBox1.Image = Properties.Resources._2_of_clubs;
                if (oyuncukart == 3) pictureBox1.Image = Properties.Resources._3_of_clubs;
                if (oyuncukart == 4) pictureBox1.Image = Properties.Resources._4_of_clubs;
                if (oyuncukart == 5) pictureBox1.Image = Properties.Resources._5_of_clubs;
                if (oyuncukart == 6) pictureBox1.Image = Properties.Resources._6_of_clubs;
                if (oyuncukart == 7) pictureBox1.Image = Properties.Resources._7_of_clubs;
                if (oyuncukart == 8) pictureBox1.Image = Properties.Resources._8_of_clubs;
                if (oyuncukart == 9) pictureBox1.Image = Properties.Resources._9_of_clubs;
                if (oyuncukart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox1.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox1.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox1.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox1.Image = Properties.Resources.king_of_clubs2;
                }
            }
            if (sayac == 2)
            {
                pictureBox2.Visible = true;
                pictureBox2.BringToFront();
                oyuncukart = rsgl.Next(1, 11);
                oyuncupuan += oyuncukart;
                lbloyuncu.Text = oyuncupuan.ToString();
                //kart seçimi
                if (oyuncukart == 1) pictureBox2.Image = Properties.Resources.ace_of_clubs;
                if (oyuncukart == 2) pictureBox2.Image = Properties.Resources._2_of_clubs;
                if (oyuncukart == 3) pictureBox2.Image = Properties.Resources._3_of_clubs;
                if (oyuncukart == 4) pictureBox2.Image = Properties.Resources._4_of_clubs;
                if (oyuncukart == 5) pictureBox2.Image = Properties.Resources._5_of_clubs;
                if (oyuncukart == 6) pictureBox2.Image = Properties.Resources._6_of_clubs;
                if (oyuncukart == 7) pictureBox2.Image = Properties.Resources._7_of_clubs;
                if (oyuncukart == 8) pictureBox2.Image = Properties.Resources._8_of_clubs;
                if (oyuncukart == 9) pictureBox2.Image = Properties.Resources._9_of_clubs;
                if (oyuncukart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox2.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox2.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox2.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox2.Image = Properties.Resources.king_of_clubs2;
                }
                //--kart seçimi
            }
            if (sayac == 3)
            {
                pictureBox3.Visible = true;
                pictureBox3.BringToFront();
                oyuncukart = rsgl.Next(1, 11);
                oyuncupuan += oyuncukart;
                lbloyuncu.Text = oyuncupuan.ToString();
                //kart seçimi
                if (oyuncukart == 1) pictureBox3.Image = Properties.Resources.ace_of_clubs;
                if (oyuncukart == 2) pictureBox3.Image = Properties.Resources._2_of_clubs;
                if (oyuncukart == 3) pictureBox3.Image = Properties.Resources._3_of_clubs;
                if (oyuncukart == 4) pictureBox3.Image = Properties.Resources._4_of_clubs;
                if (oyuncukart == 5) pictureBox3.Image = Properties.Resources._5_of_clubs;
                if (oyuncukart == 6) pictureBox3.Image = Properties.Resources._6_of_clubs;
                if (oyuncukart == 7) pictureBox3.Image = Properties.Resources._7_of_clubs;
                if (oyuncukart == 8) pictureBox3.Image = Properties.Resources._8_of_clubs;
                if (oyuncukart == 9) pictureBox3.Image = Properties.Resources._9_of_clubs;
                if (oyuncukart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox3.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox3.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox3.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox3.Image = Properties.Resources.king_of_clubs2;
                }
                //--kart seçimi

                //oyun bitirme
                if (oyuncupuan == 21) 
                {
                    kazandin.Play();
                    MessageBox.Show("Kazandınız.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;

                }
                if (oyuncupuan > 21)
                {
                    kaybettin.Play();
                    MessageBox.Show("Kaybettiniz.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
                //--oyun bitirme
            }
            if (sayac == 4)
            {
                
                pictureBox4.Visible = true;
                pictureBox4.BringToFront();
                oyuncukart = rsgl.Next(1, 11);
                oyuncupuan += oyuncukart;
                lbloyuncu.Text = oyuncupuan.ToString();
                //kart seçimi
                if (oyuncukart == 1) pictureBox4.Image = Properties.Resources.ace_of_clubs;
                if (oyuncukart == 2) pictureBox4.Image = Properties.Resources._2_of_clubs;
                if (oyuncukart == 3) pictureBox4.Image = Properties.Resources._3_of_clubs;
                if (oyuncukart == 4) pictureBox4.Image = Properties.Resources._4_of_clubs;
                if (oyuncukart == 5) pictureBox4.Image = Properties.Resources._5_of_clubs;
                if (oyuncukart == 6) pictureBox4.Image = Properties.Resources._6_of_clubs;
                if (oyuncukart == 7) pictureBox4.Image = Properties.Resources._7_of_clubs;
                if (oyuncukart == 8) pictureBox4.Image = Properties.Resources._8_of_clubs;
                if (oyuncukart == 9) pictureBox4.Image = Properties.Resources._9_of_clubs;
                if (oyuncukart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox4.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox4.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox4.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox4.Image = Properties.Resources.king_of_clubs2;
                }
                //--kart seçimi
                
                
                if (oyuncupuan == 21)
                {
                    kazandin.Play();
                    MessageBox.Show("Kazandınız.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;

                }
                if (oyuncupuan > 21)
                {
                    kaybettin.Play();
                    MessageBox.Show("Kaybettiniz.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

            }

            if (sayac == 5) 
            {
                button1.Enabled = false;
                pictureBox9.Visible = true;
                pictureBox9.BringToFront();
                oyuncukart = rsgl.Next(1, 11);
                oyuncupuan += oyuncukart;
                lbloyuncu.Text = oyuncupuan.ToString();
                //kart seçimi
                if (oyuncukart == 1) pictureBox9.Image = Properties.Resources.ace_of_clubs;
                if (oyuncukart == 2) pictureBox9.Image = Properties.Resources._2_of_clubs;
                if (oyuncukart == 3) pictureBox9.Image = Properties.Resources._3_of_clubs;
                if (oyuncukart == 4) pictureBox9.Image = Properties.Resources._4_of_clubs;
                if (oyuncukart == 5) pictureBox9.Image = Properties.Resources._5_of_clubs;
                if (oyuncukart == 6) pictureBox9.Image = Properties.Resources._6_of_clubs;
                if (oyuncukart == 7) pictureBox9.Image = Properties.Resources._7_of_clubs;
                if (oyuncukart == 8) pictureBox9.Image = Properties.Resources._8_of_clubs;
                if (oyuncukart == 9) pictureBox9.Image = Properties.Resources._9_of_clubs;
                if (oyuncukart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox9.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox9.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox9.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox9.Image = Properties.Resources.king_of_clubs2;
                }
                //--kart seçimi
                
                
                if (oyuncupuan == 21)
                {
                    kazandin.Play();
                    MessageBox.Show("Kazandınız.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;

                }
                if (oyuncupuan > 21)
                {
                    kaybettin.Play();
                    MessageBox.Show("Kaybettiniz.");
                    button3.Visible = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yenidenbasla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayacpc++;
            kartatma.Play();
            //sayaç 1
            if (sayacpc == 1) 
            {
                pckart = rsgl.Next(1, 11);
                pcpuan += pckart;
                lblpc.Text = pcpuan.ToString();
                pictureBox8.Visible = true;
                pictureBox8.BringToFront();

                //RESİM EKLEME BÖLÜMÜ
                if (pckart == 1) pictureBox8.Image = Properties.Resources.ace_of_clubs;
                if (pckart == 2) pictureBox8.Image = Properties.Resources._2_of_clubs;
                if (pckart == 3) pictureBox8.Image = Properties.Resources._3_of_clubs;
                if (pckart == 4) pictureBox8.Image = Properties.Resources._4_of_clubs;
                if (pckart == 5) pictureBox8.Image = Properties.Resources._5_of_clubs;
                if (pckart == 6) pictureBox8.Image = Properties.Resources._6_of_clubs;
                if (pckart == 7) pictureBox8.Image = Properties.Resources._7_of_clubs;
                if (pckart == 8) pictureBox8.Image = Properties.Resources._8_of_clubs;
                if (pckart == 9) pictureBox8.Image = Properties.Resources._9_of_clubs;
                if (pckart == 10)
                {
                    int x = rsgl.Next(1, 5);
                    if (x == 1) pictureBox8.Image = Properties.Resources._10_of_clubs;
                    if (x == 2) pictureBox8.Image = Properties.Resources.jack_of_clubs2;
                    if (x == 3) pictureBox8.Image = Properties.Resources.queen_of_clubs2;
                    if (x == 4) pictureBox8.Image = Properties.Resources.king_of_clubs2;
                }


                //--RESİM EKLEME BÖLÜMÜ
                
                if (pcpuan > oyuncupuan && pcpuan <= 21)
                {
                    kaybettin.Play();
                    timer1.Enabled = false;
                    MessageBox.Show("Kaybettiniz.");
                    button3.Visible = true ;
                }
                if (pcpuan > 21)
                {
                    kazandin.Play();
                    timer1.Enabled = false;
                    MessageBox.Show("Kazandınız.");
                    button3.Visible = true;
                }
            }
            //--sayaç1
            //sayaç2
                if (sayacpc == 2)
                {
                    pckart = rsgl.Next(1, 11);
                    pcpuan += pckart;
                    pictureBox7.Visible = true;
                    pictureBox7.BringToFront();
                    lblpc.Text = pcpuan.ToString();

                    //RESİM EKLEME BÖLÜMÜ
                    if (pckart == 1) pictureBox7.Image = Properties.Resources.ace_of_clubs;
                    if (pckart == 2) pictureBox7.Image = Properties.Resources._2_of_clubs;
                    if (pckart == 3) pictureBox7.Image = Properties.Resources._3_of_clubs;
                    if (pckart == 4) pictureBox7.Image = Properties.Resources._4_of_clubs;
                    if (pckart == 5) pictureBox7.Image = Properties.Resources._5_of_clubs;
                    if (pckart == 6) pictureBox7.Image = Properties.Resources._6_of_clubs;
                    if (pckart == 7) pictureBox7.Image = Properties.Resources._7_of_clubs;
                    if (pckart == 8) pictureBox7.Image = Properties.Resources._8_of_clubs;
                    if (pckart == 9) pictureBox7.Image = Properties.Resources._9_of_clubs;
                    if (pckart == 10)
                    {
                        int x = rsgl.Next(1, 5);
                        if (x == 1) pictureBox7.Image = Properties.Resources._10_of_clubs;
                        if (x == 2) pictureBox7.Image = Properties.Resources.jack_of_clubs2;
                        if (x == 3) pictureBox7.Image = Properties.Resources.queen_of_clubs2;
                        if (x == 4) pictureBox7.Image = Properties.Resources.king_of_clubs2;
                    }


                    //--RESİM EKLEME BÖLÜMÜ

                    if (pcpuan > oyuncupuan && pcpuan <= 21)
                    {
                        kaybettin.Play();
                        timer1.Enabled = false;
                        MessageBox.Show("Kaybettiniz.");
                        button3.Visible = true;
                    }
                    if (pcpuan > 21)
                    {
                        kazandin.Play();
                        timer1.Enabled = false;
                        MessageBox.Show("Kazandınız.");
                        button3.Visible = true;
                    }
                
                
                }
            //--sayaç2
            //sayaç3
                if (sayacpc == 3)
                {
                    pckart = rsgl.Next(1, 11);
                    pcpuan += pckart;
                    pictureBox6.Visible = true;
                    pictureBox6.BringToFront();

                    //RESİM EKLEME BÖLÜMÜ
                    if (pckart == 1) pictureBox6.Image = Properties.Resources.ace_of_clubs;
                    if (pckart == 2) pictureBox6.Image = Properties.Resources._2_of_clubs;
                    if (pckart == 3) pictureBox6.Image = Properties.Resources._3_of_clubs;
                    if (pckart == 4) pictureBox6.Image = Properties.Resources._4_of_clubs;
                    if (pckart == 5) pictureBox6.Image = Properties.Resources._5_of_clubs;
                    if (pckart == 6) pictureBox6.Image = Properties.Resources._6_of_clubs;
                    if (pckart == 7) pictureBox6.Image = Properties.Resources._7_of_clubs;
                    if (pckart == 8) pictureBox6.Image = Properties.Resources._8_of_clubs;
                    if (pckart == 9) pictureBox6.Image = Properties.Resources._9_of_clubs;
                    if (pckart == 10)
                    {
                        int x = rsgl.Next(1, 5);
                        if (x == 1) pictureBox6.Image = Properties.Resources._10_of_clubs;
                        if (x == 2) pictureBox6.Image = Properties.Resources.jack_of_clubs2;
                        if (x == 3) pictureBox6.Image = Properties.Resources.queen_of_clubs2;
                        if (x == 4) pictureBox6.Image = Properties.Resources.king_of_clubs2;
                    }


                    //--RESİM EKLEME BÖLÜMÜ
                    
                    lblpc.Text = pcpuan.ToString();
                    if (pcpuan > oyuncupuan && pcpuan <= 21)
                    {
                        kaybettin.Play();
                        timer1.Enabled = false;
                        MessageBox.Show("Kaybettiniz.");
                        button3.Visible = true;
                    }
                    else  if (pcpuan > 21)
                    {
                        kazandin.Play();
                        timer1.Enabled = false;
                        MessageBox.Show("Kazandınız.");
                        button3.Visible = true;
                    }
                }
            //--sayaç3 
                    //sayaç 4
                    if (sayacpc == 4)
                    {
                        pckart = rsgl.Next(1, 11);
                        pcpuan += pckart;
                        pictureBox5.Visible = true;
                        pictureBox5.BringToFront();
                        //RESİM EKLEME BÖLÜMÜ
                        if (pckart == 1) pictureBox5.Image = Properties.Resources.ace_of_clubs;
                        if (pckart == 2) pictureBox5.Image = Properties.Resources._2_of_clubs;
                        if (pckart == 3) pictureBox5.Image = Properties.Resources._3_of_clubs;
                        if (pckart == 4) pictureBox5.Image = Properties.Resources._4_of_clubs;
                        if (pckart == 5) pictureBox5.Image = Properties.Resources._5_of_clubs;
                        if (pckart == 6) pictureBox5.Image = Properties.Resources._6_of_clubs;
                        if (pckart == 7) pictureBox5.Image = Properties.Resources._7_of_clubs;
                        if (pckart == 8) pictureBox5.Image = Properties.Resources._8_of_clubs;
                        if (pckart == 9) pictureBox5.Image = Properties.Resources._9_of_clubs;
                        if (pckart == 10)
                        {
                            int x = rsgl.Next(1, 5);
                            if (x == 1) pictureBox5.Image = Properties.Resources._10_of_clubs;
                            if (x == 2) pictureBox5.Image = Properties.Resources.jack_of_clubs2;
                            if (x == 3) pictureBox5.Image = Properties.Resources.queen_of_clubs2;
                            if (x == 4) pictureBox5.Image = Properties.Resources.king_of_clubs2;
                        }


                        //--RESİM EKLEME BÖLÜMÜ
                      
                        lblpc.Text = pcpuan.ToString();
                        if (pcpuan > oyuncupuan && pcpuan <= 21)
                        {
                            kaybettin.Play();
                            timer1.Enabled = false;
                            MessageBox.Show("Kaybettiniz.");
                            button3.Visible = true;
                        }
                        else if (pcpuan > 21)
                        {
                            kazandin.Play();
                            timer1.Enabled = false;
                            MessageBox.Show("Kazandınız.");
                            button3.Visible = true;
                        }
                    }
                    //--sayaç 4.
                    //sayaç 5
                    if (sayacpc == 5)
                    {
                        pckart = rsgl.Next(1, 11);
                        pcpuan += pckart;
                        pictureBox10.Visible = true;
                        pictureBox10.BringToFront();

                        //RESİM EKLEME BÖLÜMÜ
                        if (pckart == 1) pictureBox10.Image = Properties.Resources.ace_of_clubs;
                        if (pckart == 2) pictureBox10.Image = Properties.Resources._2_of_clubs;
                        if (pckart == 3) pictureBox10.Image = Properties.Resources._3_of_clubs;
                        if (pckart == 4) pictureBox10.Image = Properties.Resources._4_of_clubs;
                        if (pckart == 5) pictureBox10.Image = Properties.Resources._5_of_clubs;
                        if (pckart == 6) pictureBox10.Image = Properties.Resources._6_of_clubs;
                        if (pckart == 7) pictureBox10.Image = Properties.Resources._7_of_clubs;
                        if (pckart == 8) pictureBox10.Image = Properties.Resources._8_of_clubs;
                        if (pckart == 9) pictureBox10.Image = Properties.Resources._9_of_clubs;
                        if (pckart == 10)
                        {
                            int x = rsgl.Next(1, 5);
                            if (x == 1) pictureBox10.Image = Properties.Resources._10_of_clubs;
                            if (x == 2) pictureBox10.Image = Properties.Resources.jack_of_clubs2;
                            if (x == 3) pictureBox10.Image = Properties.Resources.queen_of_clubs2;
                            if (x == 4) pictureBox10.Image = Properties.Resources.king_of_clubs2;
                        }


                        //--RESİM EKLEME BÖLÜMÜ
                     
                        lblpc.Text = pcpuan.ToString();
                        if (pcpuan > oyuncupuan && pcpuan <= 21)
                        {
                            kaybettin.Play();
                            timer1.Enabled = false;
                            MessageBox.Show("Kaybettiniz.");
                            button3.Visible = true;
                        }
                        else if (pcpuan > 21)
                        {
                            kazandin.Play();
                            timer1.Enabled = false;
                            MessageBox.Show("Kazandınız.");
                            button3.Visible = true;
                        }

                        else 
                        {
                            kazandin.Play();
                            timer1.Enabled = false;
                            MessageBox.Show("Kazandınız.");
                            button3.Visible = true;
                        }
                    }
                    //--sayaç 5
                }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazırlayan: Mustafa Yılmaz Çakıcı");
            MessageBox.Show("Oynadığınız İçin Teşekkürler.");
            MessageBox.Show("2015");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İnternetten Bak :)");
        }
               
            }
        }
    
