using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWords
{
    public partial class MainForm : Form
    {
        private int i = 49,points = 480;
        private const int max = 330;
        private Random random;
    Datal list = new Datal();
        // public var WordLocation = label1.Location;
        public MainForm()
        {
            InitializeComponent();
            
            list.SetData();
            random = new Random();
            
        }

        public void StartP()
        {
            //button1.Text =list.dictre.Comparer;random.Next(5)
            progressBar1.Minimum = 49;
            progressBar1.Maximum = max;
            label1.Text = $"[{points}] слово";
            label1.Location = new System.Drawing.Point(160, i++);
            if (label1.Location.Y < 100)
            {
                points--;
            }
            else if (points <= 0)
            {
                points = 0;
            }
            else
            {
                points -= 2;
            }



            progressBar1.Value = label1.Location.Y + 1;
            if (i == max)
            {

                timer1.Stop();
                label1.Enabled = false;
                label1.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Move(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            StartP();

        }
    }
}
