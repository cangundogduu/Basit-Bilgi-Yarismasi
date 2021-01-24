using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlıs = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text= yanlıs.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıs++;
                lblyanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblSoruno.Text = soruno.ToString();
            btnSonraki.Text = "Sonraki";
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            if (soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1932";
                btnB.Text = "1943";
                btnC.Text = "1923";
                btnD.Text = "1956";
                label4.Text = "1923";
                
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiyede UEFA Kupasını Kazanan Tek Türk Takımı Hangisidir ?";
                btnA.Text = "Trabzonspor";
                btnB.Text = "Galatasaray";
                btnC.Text = "Fenerbahçe";
                btnD.Text = "Beşiktaş";
                label4.Text = "Galatasaray";

            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Sivas İlimiz Hangi Bölgemizde Yer Almaktadır ?";
                btnA.Text = "İç Anadolu";
                btnB.Text = "Karadeniz";
                btnC.Text = "Doğu Anadolu";
                btnD.Text = "Ege";
                label4.Text = "İç Anadolu";
                btnSonraki.Text = "Sonuçları Görüntüle";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                lblSoruno.Text = "Sonuçlar";
                MessageBox.Show("Sınav Sonucu"+"\n"+"Doğru :" + dogru+ "\n" + "Yanlış :" + yanlıs);
              
            }

            
        }
    }
}
