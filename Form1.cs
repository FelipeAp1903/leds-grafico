using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leds_Interface
{
    public partial class Form1 : Form
    {
        
        private Leds l;
        public Form1()
        {
            InitializeComponent();
            l = new Leds(0);
            atualizaInterface();
            picligado1.Image = ledsligado.Images[0];
            picligado2.Image = ledsligado.Images[0];
            picligado3.Image = ledsligado.Images[0];
            picligado4.Image = ledsligado.Images[0];
            picligado5.Image = ledsligado.Images[0];
            picligado5.Image = ledsligado.Images[0];
            picligado6.Image = ledsligado.Images[0];
            picligado7.Image = ledsligado.Images[0];
            picligado8.Image = ledsligado.Images[0];
            //botoes do leds(interface)
            picLed1.Image = botaoLeds.Images[0];
            picLed2.Image = botaoLeds.Images[0];
            picLed3.Image = botaoLeds.Images[0];
            picLed4.Image = botaoLeds.Images[0];
            picLed5.Image = botaoLeds.Images[0];
            picLed6.Image = botaoLeds.Images[0];
            picLed7.Image = botaoLeds.Images[0];
            picLed8.Image = botaoLeds.Images[0];

        }
        private void atualizaInterface()
        {

            label1.Text = l.getEstado().ToString();
            label2.Text = Convert.ToString(l.getEstado(), 2);
            btnLed1.Text = (l.getEstado(1) ? "OFF" : "ON");
            btnLed2.Text = (l.getEstado(2) ? "OFF" : "ON");
            btnLed3.Text = (l.getEstado(3) ? "OFF" : "ON");
            btnLed4.Text = (l.getEstado(4) ? "OFF" : "ON");
            btnLed5.Text = (l.getEstado(5) ? "OFF" : "ON");
            btnLed6.Text = (l.getEstado(6) ? "OFF" : "ON");
            btnLed7.Text = (l.getEstado(7) ? "OFF" : "ON");
            btnLed8.Text = (l.getEstado(8) ? "OFF" : "ON");


        }
        private void btnLed1_Click(object sender, EventArgs e)
        {
          

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (l.getEstado(2))
                l.apagar(2);
            else
                l.acender(2);
            atualizaInterface();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (l.getEstado(3))
                l.apagar(3);
            else
                l.acender(3);
            atualizaInterface();
        }

        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (l.getEstado(4))
                l.apagar(4);
            else
                l.acender(4);
            atualizaInterface();
        }

        private void btnLed5_Click(object sender, EventArgs e)
        {
            if (l.getEstado(5))
                l.apagar(5);
            else
                l.acender(5);
            atualizaInterface();
        }

        private void btnLed6_Click(object sender, EventArgs e)
        {
            if (l.getEstado(6))
                l.apagar(6);
            else
                l.acender(6);
            atualizaInterface();
        }

        private void btnLed7_Click(object sender, EventArgs e)
        {
            if (l.getEstado(7))
                l.apagar(7);
            else
                l.acender(7);
            atualizaInterface();
        }

        private void btnLed8_Click(object sender, EventArgs e)
        {
            if (l.getEstado(8))
                l.apagar(8);
            else
                l.acender(8);
            atualizaInterface();
        }

        private void picLed1_Click(object sender, EventArgs e)
        {
            if (l.getEstado(1))
            {
                l.apagar(1);
                picLed1.Image = botaoLeds.Images[0];
                picligado1.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(1);
                picLed1.Image = botaoLeds.Images[1];
                picligado1.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picled2_Click(object sender, EventArgs e)
        {
            if (l.getEstado(2))
            {
                l.apagar(2);
                picLed2.Image = botaoLeds.Images[0];
              
                picligado2.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(2);
                picLed2.Image = botaoLeds.Images[1];
                picligado2.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed3_Click(object sender, EventArgs e)
        {
            if (l.getEstado(3))
            {
                l.apagar(3);
                picLed3.Image = botaoLeds.Images[0];
                picligado3.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(3);
                picLed3.Image = botaoLeds.Images[1];
                picligado3.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed4_Click(object sender, EventArgs e)
        {
            if (l.getEstado(4))
            {
                l.apagar(4);
                picLed4.Image = botaoLeds.Images[0];
                picligado4.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(4);
                picLed4.Image = botaoLeds.Images[1];
                picligado4.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed5_Click(object sender, EventArgs e)
        {
            if (l.getEstado(5))
            {
                l.apagar(5);
                picLed5.Image = botaoLeds.Images[0];
                picligado5.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(5);
                picLed5.Image = botaoLeds.Images[1];
                picligado5.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed6_Click(object sender, EventArgs e)
        {
            if (l.getEstado(6))
            {
                l.apagar(6);
                picLed6.Image = botaoLeds.Images[0];
                picligado6.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(6);
                picLed6.Image = botaoLeds.Images[1];
                picligado6.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed7_Click(object sender, EventArgs e)
        {
            if (l.getEstado(7))
            {
                l.apagar(7);
                picLed7.Image = botaoLeds.Images[0];
                picligado7.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(7);
                picLed7.Image = botaoLeds.Images[1];
                picligado7.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

        private void picLed8_Click(object sender, EventArgs e)
        {
            if (l.getEstado(8))
            {
                l.apagar(8);
                picLed8.Image = botaoLeds.Images[0];
                picligado8.Image = ledsligado.Images[0];
            }

            else
            {
                l.acender(8);
                picLed8.Image = botaoLeds.Images[1];
                picligado8.Image = ledsligado.Images[1];
            }

            atualizaInterface();
        }

    }
}
