using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENZİNLİK_DENEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        Random araba = new Random();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += araba.Next(9, 10);

            if (pictureBox1.Left > label2.Left)
            {
                timer1.Stop();
                MessageBox.Show("BENZİNLİĞİMİZE HOŞ GELDİNİZ");               
                benzin.Visible = true;
                dizel.Visible = true;
                lpg.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                txtTutar.Visible = true;
                lbllitre.Visible = true;
                txtTutaroto.Visible = true;
                lblLitreoto.Visible = true;
                btndolduroto.Visible = true;
                lpg.Enabled = true;
                benzin.Enabled = true;
                dizel.Enabled = true;
                groupBox2.Visible = true;
               

            }
          else  if (pictureBox1.Left > label2.Right)
            {
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        double litre;
        int arabasayi;
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İYİ YOLCULUKLAR DİLERİZ :)");
            if (pictureBox1.Left > label2.Left)
            {
                timer2.Start();
                arabasayi++;
            }

            if (pictureBox3.Left > label2.Left)
            {
                timer5.Start();
                arabasayi++;
            }

            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add(arabasayi + ". ARABA " + litre.ToString("0.00") + "LT YAKIT ALDI VE " + txtTutar.Text + " ÖDEDİ." + "\n");
            }
            if(radioButton2.Checked == true)
            {
                listBox1.Items.Add(arabasayi + ". ARABA " + otolt.ToString("0.00") + "LT YAKIT ALDI VE " + txtTutaroto.Text + "TL ÖDEDİ." + "\n");
            }
            sifirla();           
            benzin.Checked = false;
            lpg.Checked = false;
            dizel.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;          
            groupBox1.Visible = false;
            benzin.Enabled = false;
            dizel.Enabled = false;
            lpg.Enabled = false;
            benzin.Visible = false;
            lpg.Visible = false;
            dizel.Visible = false;
            lblLitreoto.Enabled = false;
            txtTutaroto.Enabled = false;
            btndolduroto.Enabled = false;
            groupBox2.Visible = false;
            progressBar1.Value = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += araba.Next(9, 10);

            if(pictureBox1.Left > label9.Left)
            {               
                pictureBox1.Left = label14.Left;
               
                timer2.Stop();

                pictureBox1.Visible = false;
                pictureBox3.Visible = true;

                timer4.Start();

                enabledfalse();

                benzin.Enabled = true;
                lpg.Enabled = true;
                dizel.Enabled = true;
            }
                
        }
       
       

        private void timer3_Tick(object sender, EventArgs e)
        {
            litre += 0.1;
            lbllitre.Text = litre.ToString("0.00") + " LT";

                if (benzin.Checked == true)
                {
                    txtTutar.Text = (litre * 19.31).ToString("0.00") + " TL";
                }

                if (lpg.Checked == true)
                {
                    txtTutar.Text = (litre * 11.12).ToString("0.00") + " TL";
                }

                if (dizel.Checked == true)
                {
                    txtTutar.Text = (litre * 23.61).ToString() + " TL";
                }
            button3.Enabled = true;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Start();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }

        private void benzin_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            sifirla();

            lpg.Enabled = false;
            dizel.Enabled = false;

            groupBox1.Visible = true;
        }

        private void lpg_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            sifirla();

            benzin.Enabled = false;
            dizel.Enabled = false;
            groupBox1.Visible = true;

        }

        void enabled()
        {
            if (radioButton1.Checked == true)
            {
                //txtTutar.Enabled = true;
                lbllitre.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                lbllitre.Enabled = true;
                txtTutar.Enabled = true;
                button3.Enabled = true;
            }
            if (radioButton2.Checked == true)
            {
                lblLitreoto.Enabled = true;
                txtTutaroto.Enabled = true;
                btndolduroto.Enabled = true;
                button3.Enabled = false;
            }

        }

        private void dizel_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            sifirla();

            benzin.Enabled = false;
            lpg.Enabled = false;
            groupBox1.Visible = true;
        }

        Random araba2 = new Random();
        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left += araba2.Next(10, 13);

            if(pictureBox3.Left > label2.Left)
            {
                timer4.Stop();

                MessageBox.Show("BENZİNLİĞE HOŞ GELDİNİZ!");

                enabled();
                benzin.Visible = true;
                lpg.Visible = true;
                dizel.Visible = true;
                groupBox2.Visible = true;

                
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left += araba2.Next(10, 13);

                if(pictureBox3.Left > label9.Left)
            {
                pictureBox3.Left = label14.Right;

                timer5.Stop();

                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                enabledfalse();                

                timer1.Start();
            }
        }

        void sifirla()
        {           
            litre = 0;
            otolt = 0;
            ltsayac = 0;
            txtTutaroto.Text = "";
            lbllitre.Text = "0";
            txtTutar.Text = "0";
            lblLitreoto.Text = "0";
        }
        void enabledfalse()
        {
            txtTutar.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            lbllitre.Enabled = false;
        }
        double tutar, otolt, ltsayac;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            enabled();
            radioButton2.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            enabled();
            radioButton1.Enabled = false;
            progressBar1.Visible = true;
        }

        private void txtTutaroto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//rakam giriliyor metin girilemiyor
            {
                e.Handled = true;
            }
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
        }

       

        private void btndolduroto_Click(object sender, EventArgs e)
        {
            timerTutar.Start();
        }
        
        private void timerTutar_Tick(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(txtTutaroto.Text);
            ltsayac += 0.01;
            lblLitreoto.Text = ltsayac.ToString("0.00") + "LT";
            progressBar1.Maximum = Convert.ToInt32(otolt);
            progressBar1.Value = Convert.ToInt32(ltsayac);
            progressBar1.ForeColor = Color.DarkBlue;

            if (benzin.Checked == true)
            {
                otolt = tutar / 19.31;
                
                if (ltsayac >= otolt)
                {
                    
                    timerTutar.Stop();
                    MessageBox.Show("DOLDURMA TAMAMLANDI!");
                    button3.Enabled = true;
                }
            }

            if(lpg.Checked == true)
            {
                otolt = tutar / 11.12;
                if(ltsayac >= otolt)
                {
                    timerTutar.Stop();
                    MessageBox.Show("DOLDURMA TAMAMLANDI!");
                    button3.Enabled = true;
                }
            }

            if(dizel.Checked == true)
            {
                otolt = tutar / 23.61;
                if(ltsayac >= otolt)
                {
                    timerTutar.Stop();
                    MessageBox.Show("DOLDURMA TAMAMLANDI!");
                    button3.Enabled = true;
                }
            }
            btndolduroto.Enabled = false;
            txtTutar.Enabled = false;
        }



    }
}
