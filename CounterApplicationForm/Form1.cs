using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CounterApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Counter Contatore = new Counter(100);
        int max = 100;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Counter Contatore = new Counter(max);
        }

        private void START_Click(object sender, EventArgs e)
        {
            if (Contatore.getValue() == max)
            {
                this.timer1.Enabled = false;
            }
            else
            {
                timer1_Tick(sender, e);
            }
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

            Contatore.inc();

            label1.Text = Convert.ToString(Contatore.getValue());

            if(Contatore.getValue() > max)
            {
                label3.Visible = true;
                label3.Location = new Point(314, 217);
                label3.ForeColor = Color.White;
                label3.Text = "      CO COME MAI            CO COME MAI     LA CHAMPIONS LEAGUE TU NON LA VINCI MAI";
                
                label4.Location = new Point(217, 145);
                label4.ForeColor = Color.White;
                label4.TextAlign = ContentAlignment.MiddleCenter;
                label4.Text = "COUNTER ERROR";

                this.timer1.Enabled = false;
            }
            else if(Contatore.getValue() != 100)
            {
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contatore.reset();
            label1.Text = Convert.ToString(Contatore.getValue());

            label3.Visible = false;


            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 44);

            this.timer1.Enabled = false;
        }
    }
}
