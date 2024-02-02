using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_5__Bilgi_Yarışması_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlıs = 0;
        


     

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label8.Text = buttonD.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
            button5.Enabled = true;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label8.Text = buttonC.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
            button5.Enabled = true;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;


            label8.Text = buttonB.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
            button5.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click_1(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;



            label8.Text = buttonA.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlıs++;
                LblYanlıs.Text = yanlıs.ToString();
                pictureBox2.Visible = true;
            }
            button5.Enabled = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Enabled = false;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            soruNo++;
            label4.Text = soruNo.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                buttonA.Text = "1921";
                buttonB.Text = "1922";
                buttonC.Text = "1453";
                buttonD.Text = "1923";
                label7.Text = "1923";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi asal sayı değildir?";
                buttonA.Text = "2";
                buttonB.Text = "83";
                buttonC.Text = "91";
                buttonD.Text = "97";
                label7.Text = "91";
            }

            if (soruNo == 3)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisi bir element değildir?";
                buttonA.Text = "Tahta";
                buttonB.Text = "Ateş";
                buttonC.Text = "Su";
                buttonD.Text = "Toprak";
                label7.Text = "Tahta";

            }
            if (soruNo == 4)
            {

                richTextBox1.Text = "Recep ivedik film serisinin hangi filminde Recep zenci taylanı penaltılarda yaylandırmıştır";
                buttonA.Text = "1";
                buttonB.Text = "2";
                buttonC.Text = "3";
                buttonD.Text = "4";
                label7.Text = "4";

            }
            if (soruNo == 5)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisi burnu büyük olması ile bilinmez?";
                buttonA.Text = "Tolunay Ören";
                buttonB.Text = "Muslera";
                buttonC.Text = "Berke kHul";
                buttonD.Text = "Trabzonlu herhangi biri";
                label7.Text = "Muslera";

            }
            if (soruNo == 6)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisi rakı içmesi, gay bara gitmesi ve tten yemesiyle gündemdedir?";
                buttonA.Text = "Ata";
                buttonB.Text = "Peri";
                buttonC.Text = "Berke kHul";
                buttonD.Text = "Tahacan";
                label7.Text = "Peri";

            }
            if (soruNo == 7)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisi bir kaç hafta sonra uzun bir süre buralarda olmayacaktır ?";
                buttonA.Text = "Ata";
                buttonB.Text = "Peri";
                buttonC.Text = "ttendeniz";
                buttonD.Text = "Tahacan";
                label7.Text = "ttendeniz";

            }
            if (soruNo == 8)
            {

                richTextBox1.Text = "Aşağıdakilerden hangisinin egosu, boyundan büyüktür?";
                buttonA.Text = "Ata";
                buttonB.Text = "Peri";
                buttonC.Text = "ttendeniz";
                buttonD.Text = "MEteroid";
                label7.Text = "Ata";

            }
            if (soruNo == 9)
            {

                richTextBox1.Text = "TaumataWhakatangihangakoauauoTamateahaumaitawhitiurhyhuimitkhulllkakapikimaunghoronukupokaiwhenuakitanatahu dağı nerededir?";
                buttonA.Text = "Turkiye";
                buttonB.Text = "Yeni Zelanda";
                buttonC.Text = "Hiçbir yerde";
                buttonD.Text = "KUzey kIbrıs";
                label7.Text = "Hiçbir yerde";

            }
            if (soruNo==10)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doğru sayısı: " + dogru+"\nYAnlış sayısı: "+yanlıs);

            }
        }

       

        

        
    }
}
