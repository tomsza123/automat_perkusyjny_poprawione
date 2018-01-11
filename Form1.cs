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
using System.Threading;
using NAudio;
using NAudio.Wave;
using NAudio.Utils;


namespace automat_perkusyjny
{
    
    public partial class Form1 : Form
    {
        
            //public Thread watek = new Thread();
            //watek.Start();
            //zmienne globalna
        static public string plik { get; set; }
        static public string plik2 { get; set; }
        static public string plik3 { get; set; }
        static public string plik4 { get; set; }
        static public string plik5 { get; set; }
        static public string plik6 { get; set; }

        static int bpm { get; set; }
        static int ms = ((60000/128)/4);
        int stop = 0;
        int ilosc_sampli = 1;

        //Thread graj;


        public Form1()
        {
            InitializeComponent();
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bpm = int.Parse(b);
            //textBox1.Text() = bpm.ToString();
            //pamietac o dodaniu mozliwosci zmiany bpm z textboxu   
            /*try
            {
                
                bpm = int.Parse(textBox1.Text);
                bpm = bpmbar.Value;

            }
            catch
            {
                textBox1.Clear();
                MessageBox.Show("Drogi muzykancie, wartość bpm (uderzeń na minutę) jest liczbą ;) ");
            }*/
        }
        public void bpmbar_Scroll(object sender, ScrollEventArgs e)
        {
            //play graj1 = new play();
            // graj1.bpm1 = bpm;
            

            bpm = bpmbar.Value;
            textBox1.Text = bpm.ToString();
        }


        int[] tab = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] tab2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] tab3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] tab4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] tab5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] tab6 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) tab[0] = 1;
            else tab[0] = 0;
        }
        public void checkBox2_CheckedChanged_1(object sender, EventArgs e)//"checkedchange1"efekty bałaganu przy pisaniu...
        {
            if (checkBox2.Checked) tab[1] = 1;
            else tab[1] = 0;
        }
        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) tab[2] = 1;
            else tab[2] = 0;
        }
        public void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) tab[3] = 1;
            else tab[3] = 0;
        }
        public void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) tab[4] = 1;
            else tab[4] = 0;
        }
        public void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) tab[5] = 1;
            else tab[5] = 0;
        }
        public void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) tab[6] = 1;
            else tab[6] = 0;
        }
        public void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) tab[7] = 1;
            else tab[7] = 0;
        }
        public void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked) tab[8] = 1;
            else tab[8] = 0;
        }
        public void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked) tab[9] = 1;
            else tab[9] = 0;
        }
        public void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked) tab[10] = 1;
            else tab[10] = 0;
        }
        public void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked) tab[11] = 1;
            else tab[11] = 0;
        }
        public void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked) tab[12] = 1;
            else tab[12] = 0;
        }
        public void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked) tab[13] = 1;
            else tab[13] = 0;
        }
        public void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked) tab[14] = 1;
            else tab[14] = 0;
        }
        public void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked) tab[15] = 1;
            else tab[15] = 0;
        }


        public void stopbut_Click(object sender, EventArgs e)
        {
            //stop++;
            //play zatrzymaj = new play;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam1 = new otwieranie_sampli();     
            sam1.otworz();
            plik = sam1.sampel;
            button1.Text = sam1.nazwa;
            // dla testu MessageBox.Show(plik);
            
        }
        
        public void playbut_Click(object sender, EventArgs e)
        {}

        public void progressBar1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam2 = new otwieranie_sampli();
            sam2.otworz();
            plik2 = sam2.sampel;
            button2.Text = sam2.nazwa;
        }
        private void stopbut_Click_1(object sender, EventArgs e)
        {
            
            stop = 1;//ewentualnie return true

        }

       public void playbut_Click_1(object sender, EventArgs e)

       {
            //progressbar.RunWorkerAsync();
            if (stop == 1) stop--;

            
            backgroundWorker1.RunWorkerAsync();

            backgroundWorker2.RunWorkerAsync();
            
            backgroundWorker3.RunWorkerAsync();

            backgroundWorker4.RunWorkerAsync();
            
            backgroundWorker5.RunWorkerAsync();
            
            backgroundWorker6.RunWorkerAsync();         
        }

        public void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked) tab2[0] = 1;
            else tab2[0] = 0;
        }
        public void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked) tab2[1] = 1;
            else tab2[1] = 0;
        }
        public void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked) tab2[2] = 1;
            else tab2[2] = 0;
        }
        public void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked) tab2[3] = 1;
            else tab2[3] = 0;
        }
        public void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked) tab2[4] = 1;
            else tab2[4] = 0;
        }
        public void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked) tab2[5] = 1;
            else tab2[5] = 0;
        }
        public void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked) tab2[6] = 1;
            else tab2[6] = 0;
        }
        public void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked) tab2[7] = 1;
            else tab2[7] = 0;
        }
        public void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked) tab2[8] = 1;
            else tab2[8] = 0;
        }
        public void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked) tab2[9] = 1;
            else tab2[9] = 0;
        }
        public void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked) tab2[10] = 1;
            else tab2[10] = 0;
        }
        public void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked) tab2[11] = 1;
            else tab2[11] = 0;
        }
        public void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked) tab2[12] = 1;
            else tab2[12] = 0;
        }
        public void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked) tab2[13] = 1;
            else tab2[13] = 0;
        }
        public void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked) tab2[14] = 1;
            else tab2[14] = 0;
        }
        public void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked) tab2[15] = 1;
            else tab2[15] = 0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //tym bede zatrzymywal petle
        {
            
            // = bpmbar.Value;
            //int i;
            
            int ms = ((60000 / 128) / 4);
           // progressBar1.Value = graj1.progress;
            play graj1 = new play();
            //graj1.bpm1 = bpmbar.Value;
            graj1.sampel = plik;
            graj1.tab = tab;
            
            graj1.ms1 = 1;
            //graj1.glosnosc = trackBar1.Value;


            //graj1.progress = progressBar1.Value;


            while (stop != 1)
            {               
                graj1.graj();                
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            play graj2 = new play();
            graj2.sampel = plik2;
            graj2.tab = tab2;
            
            graj2.ms1 = ms ;
            //graj2.glosnosc = trackBar2.Value;
            //var progressBar1.Value = 0;
            //graj2.progress = progressBar1.Value;
            while (stop!=1)
            {
                graj2.graj();
            }
        }
        

        public void progressbar_DoWork(object sender, DoWorkEventArgs e)
        {
            //int ms = ((60000 / 128) / 4);
            
            //progressBar1.Value = 0;
           /* for (int i = 0; i <= 15; i++)
            {
                if (i <= 14)
                {

                    progressBar1.Value++;
                    Thread.Sleep(ms);
                }
                if (i == 15)
                {
                    progressBar1.Value = 0;
                    Thread.Sleep(ms);
                }
            }*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop++;
            //MessageBox.Show("Mam nadzieję, że udało Ci się dziś stworzyć jakąś ciekawą sekwencję perkusyjną :) ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam3 = new otwieranie_sampli();
            sam3.otworz();
            plik3 = sam3.sampel;
            button3.Text = sam3.nazwa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam4 = new otwieranie_sampli();
            sam4.otworz();
            plik4 = sam4.sampel;
            button4.Text = sam4.nazwa;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam5 = new otwieranie_sampli();
            sam5.otworz();
            plik5 = sam5.sampel;
            button5.Text = sam5.nazwa;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            otwieranie_sampli sam6 = new otwieranie_sampli();
            sam6.otworz();
            plik6 = sam6.sampel;
            button6.Text = sam6.nazwa;

        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            play graj3 = new play();
            graj3.sampel = plik3;
            graj3.tab = tab3;
            
            graj3.ms1 = ms * 2;
            //graj2.glosnosc = trackBar2.Value;
            //progressBar1.Value = 0;
            //graj2.progress = progressBar1.Value;
            while (stop != 1)
            {
                graj3.graj();
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            play graj4 = new play();
            graj4.sampel = plik4;
            //graj4.tab = tab4;
            graj4.tab = tab4;
            
            graj4.ms1 = ms * 3;
            //graj2.glosnosc = trackBar2.Value;
            //progressBar1.Value = 0;
            //graj2.progress = progressBar1.Value;
            while (stop != 1)
            {
                graj4.graj();
            }
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            play graj5 = new play();
            graj5.sampel = plik5;
            //graj5.tab = tab5;
            
            graj5.tab = tab5;
            
            graj5.ms1 = ms * 4;
            //graj2.glosnosc = trackBar2.Value;
            //progressBar1.Value = 0;
            //graj2.progress = progressBar1.Value;
            while (stop != 1)
            {
                graj5.graj();
            }
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            play graj6 = new play();
            graj6.sampel = plik6;
            //graj6.tab = tab6;
            
            graj6.tab = tab6;
            graj6.ms1 = ms * 5;
            //graj2.glosnosc = trackBar2.Value;
            //progressBar1.Value = 0;
            //graj2.progress = progressBar1.Value;
            while (stop != 1)
            {
                graj6.graj();
            }
        }
        

        public void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked) tab3[0] = 1;
            else tab3[0] = 0;
        }
        public void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked) tab3[1] = 1;
            else tab3[1] = 0;
        }
        public void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked) tab3[2] = 1;
            else tab3[2] = 0;
        }
        public void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked) tab3[3] = 1;
            else tab3[3] = 0;
        }
        public void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked) tab3[4] = 1;
            else tab3[4] = 0;
        }
        public void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked) tab3[5] = 1;
            else tab3[5] = 0;
        }
        public void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked) tab3[6] = 1;
            else tab3[6] = 0;
        }
        public void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked) tab3[7] = 1;
            else tab3[7] = 0;
        }
        public void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked) tab3[8] = 1;
            else tab3[8] = 0;
        }
        public void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked) tab3[9] = 1;
            else tab3[9] = 0;
        }
        public void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked) tab3[10] = 1;
            else tab3[10] = 0;
        }
        public void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked) tab3[11] = 1;
            else tab3[11] = 0;
        }
        public void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked) tab3[12] = 1;
            else tab3[12] = 0;
        }
        public void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked) tab3[13] = 1;
            else tab3[13] = 0;
        }
        public void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked) tab3[14] = 1;
            else tab3[14] = 0;
        }
        public void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked) tab3[15] = 1;
            else tab3[15] = 0;
        }

        public void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked) tab4[0] = 1;
            else tab4[0] = 0;
        }
        public void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked) tab4[1] = 1;
            else tab4[1] = 0;
        }
        public void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox51.Checked) tab4[2] = 1;
            else tab4[2] = 0;
        }
        public void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox52.Checked) tab4[3] = 1;
            else tab4[3] = 0;
        }
        public void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox53.Checked) tab4[4] = 1;
            else tab4[4] = 0;
        }
        public void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox54.Checked) tab4[5] = 1;
            else tab4[5] = 0;
        }
        public void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox55.Checked) tab4[6] = 1;
            else tab4[6] = 0;
        }
        public void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox56.Checked) tab4[7] = 1;
            else tab4[7] = 0;
        }
        public void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox57.Checked) tab4[8] = 1;
            else tab4[8] = 0;
        }
        public void checkBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox58.Checked) tab4[9] = 1;
            else tab4[9] = 0;
        }
        public void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox59.Checked) tab4[10] = 1;
            else tab4[10] = 0;
        }
        public void checkBox60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox60.Checked) tab4[11] = 1;
            else tab4[11] = 0;
        }
        public void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox61.Checked) tab4[12] = 1;
            else tab4[12] = 0;
        }
        public void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox62.Checked) tab4[13] = 1;
            else tab4[13] = 0;
        }
        public void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox63.Checked) tab4[14] = 1;
            else tab4[14] = 0;
        }
        public void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox64.Checked) tab4[15] = 1;
            else tab4[15] = 0;
        }

        public void checkBox65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox65.Checked) tab5[0] = 1;
            else tab5[0] = 0;
        }
        public void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox66.Checked) tab5[1] = 1;
            else tab5[1] = 0;
        }
        public void checkBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox67.Checked) tab5[2] = 1;
            else tab5[2] = 0;
        }
        public void checkBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox68.Checked) tab5[3] = 1;
            else tab5[3] = 0;
        }
        public void checkBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox69.Checked) tab5[5] = 1;
            else tab5[4] = 0;
        }
        public void checkBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox70.Checked) tab5[5] = 1;
            else tab5[5] = 0;
        }
        public void checkBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox71.Checked) tab5[6] = 1;
            else tab5[6] = 0;
        }        
        public void checkBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox72.Checked) tab5[7] = 1;
            else tab5[7] = 0;
        }
        public void checkBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox73.Checked) tab5[8] = 1;
            else tab5[8] = 0;
        }
        public void checkBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox74.Checked) tab5[9] = 1;
            else tab5[9] = 0;
        }
        public void checkBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox75.Checked) tab5[10] = 1;
            else tab5[10] = 0;
        }
        public void checkBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox76.Checked) tab5[11] = 1;
            else tab5[11] = 0;
        }
        public void checkBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox77.Checked) tab5[12] = 1;
            else tab5[12] = 0;
        }
        public void checkBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox78.Checked) tab5[13] = 1;
            else tab5[13] = 0;
        }
        public void checkBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox79.Checked) tab5[14] = 1;
            else tab5[14] = 0;
        }
        public void checkBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox80.Checked) tab5[15] = 1;
            else tab5[15] = 0;
        }

        public void checkBox81_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox81.Checked) tab6[0] = 1;
            else tab6[0] = 0;
        }
        public void checkBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox82.Checked) tab6[1] = 1;
            else tab6[1] = 0;
        }
        public void checkBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox83.Checked) tab6[2] = 1;
            else tab6[2] = 0;
        }
        public void checkBox84_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox84.Checked) tab6[3] = 1;
            else tab6[3] = 0;
        }
        public void checkBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox85.Checked) tab6[4] = 1;
            else tab6[4] = 0;
        }
        public void checkBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox86.Checked) tab6[5] = 1;
            else tab6[5] = 0;
        }
        public void checkBox87_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox87.Checked) tab6[6] = 1;
            else tab6[6] = 0;
        }
        public void checkBox88_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox88.Checked) tab6[7] = 1;
            else tab6[7] = 0;
        }
        public void checkBox89_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox89.Checked) tab6[8] = 1;
            else tab6[8] = 0;
        }
        public void checkBox90_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox90.Checked) tab6[9] = 1;
            else tab6[9] = 0;
        }
        public void checkBox91_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox91.Checked) tab6[10] = 1;
            else tab6[10] = 0;
        }
        public void checkBox92_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox92.Checked) tab6[11] = 1;
            else tab6[11] = 0;
        }
        public void checkBox93_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox93.Checked) tab6[12] = 1;
            else tab6[12] = 0;
        }
        public void checkBox94_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox94.Checked) tab6[13] = 1;
            else tab6[13] = 0;
        }
        public void checkBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox95.Checked) tab6[14] = 1;
            else tab6[14] = 0;
        }
        public void checkBox96_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox96.Checked) tab6[15] = 1;
            else tab6[15] = 0;
        }

        

        
    }
        
}

            


    
        

    




    


