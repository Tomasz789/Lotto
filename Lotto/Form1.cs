using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        bool p1 = false;
        int x1, x2, x3, x4, x5, x6;
        int s = 0;
        int [] tab = new int[6];
        Random rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
         

            if (s == 0)
                label1.Text = tab[0].ToString();
            if (s == 1)
                label2.Text = tab[1].ToString();
            if (s == 2)
                label3.Text = tab[2].ToString();
            if (s == 3)
                label4.Text = tab[3].ToString();
            if (s == 4)
                label5.Text = tab[4].ToString();
            if (s == 5)
                label6.Text = tab[5].ToString();

            if (s >= 5)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

           
           ++s;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
            string name = saveFileDialog1.FileName;
            string[] tab2 = new string[6];
            for(int i=0; i<6; ++i)
             {
                 tab2[i] = tab[i].ToString();
             } 

            File.WriteAllLines(name, tab2);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = 0;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            timer1.Enabled = true;
            button1.Enabled = false;
            losuj_liczbe(tab);
        }

        private void losuj_liczbe(int [] tab)
        {

            tab[0] = rand.Next(49) + 6;
            for (int i=1; i<6; ++i)
            {
                do
                {
                    tab[i] = rand.Next(6, 49);
                } while (tab[i] == tab[0]);
            }

          
        }
    }
}
