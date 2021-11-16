using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int caso = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Image = Traffic_Light.Properties.Resources.Off;
            pb2.Image = Traffic_Light.Properties.Resources.DeOff;
            pb3.Image = Traffic_Light.Properties.Resources.AbOff;
            pb4.Image = Traffic_Light.Properties.Resources.Off;
            On.Enabled = true;
            Off.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (caso)
            {
                case 0:
                    pb1.Image = Traffic_Light.Properties.Resources._2b2de_verde;
                    pb3.Image = Traffic_Light.Properties.Resources.Ab2b2de_verde;
                    timer1.Interval = 5000;
                    caso = 1;
                    break;
                case 1:
                    pb1.Image = Traffic_Light.Properties.Resources._23f47_amarillo;
                    pb3.Image = Traffic_Light.Properties.Resources.Ab23f47_amarillo;
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2:
                    pb1.Image = Traffic_Light.Properties.Resources._908d3_rojo;
                    pb3.Image = Traffic_Light.Properties.Resources.Ab908d3_rojo;
                    timer1.Interval = 5000;
                    caso = 0;
                    break;
            }
        }

        private void On_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Off.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (Stop.Text == "STOP")
            {
                timer1.Enabled = false;
                Stop.Text = "CONTINUE";
            }
            else if (Stop.Text == "CONTINUE")
            {
                timer1.Enabled = true;
                Stop.Text = "STOP";
            }
        }

        private void Off_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Off.Enabled = false;
            Stop.Enabled = false;
            On.Enabled = true;
            pb1.Image = pb1.Image = Traffic_Light.Properties.Resources.Off;
            pb2.Image = pb1.Image = Traffic_Light.Properties.Resources.DeOff;
            pb3.Image = pb1.Image = Traffic_Light.Properties.Resources.AbOff;
            pb4.Image = pb1.Image = Traffic_Light.Properties.Resources.Off;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 0:
                    pb2.Image = Traffic_Light.Properties.Resources.De2b2de_verde;
                    pb4.Image = Traffic_Light.Properties.Resources.Iz2b2de_verde;
                    timer1.Interval = 5000;
                    caso = 1;
                    break;
                case 1:
                    pb1.Image = Traffic_Light.Properties.Resources.De23f47_amarillo;
                    pb3.Image = Traffic_Light.Properties.Resources.Iz23f47_amarillo;
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2:
                    pb1.Image = Traffic_Light.Properties.Resources.De908d3_rojo;
                    pb3.Image = Traffic_Light.Properties.Resources.Iz908d3_rojo;
                    timer1.Interval = 5000;
                    caso = 0;
                    break;
            }
        }
    }
}
