using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;               // <-- Adicionado para usar o SoundPlayer
using System.Diagnostics;         // <-- Adicionado para usar o StopWatch

namespace Timer
{
    public partial class frm_Timer : Form
    {
        private SoundPlayer Tocador;       // <-- Classe para tocar arquivo de áudio
        Stopwatch sw;                      // <-- Classe usada para contar tempo decorrido
        Int32 itempo = 0;                  // <-- Contador de tempo
        DateTime tempo2 = DateTime.Now;    // <-- Variavel para armazenar a hora


        public frm_Timer()
        {
            InitializeComponent();
            Tocador = new SoundPlayer();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();

                itempo = Convert.ToInt32(cbbTempo.Text);
                itempo = itempo * 60;
                if (cbbTempo.Text == "60") tempo2 = Convert.ToDateTime("1:00:00");
                else if (cbbTempo.Text == "120") tempo2 = Convert.ToDateTime("2:00:00");
                else tempo2 = Convert.ToDateTime(string.Format("0:{0}:00", cbbTempo.Text));
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Selecione um tempo Válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbTempo.Focus();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            sw.Stop();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            itempo--;  // <-- Para a cada segundo, subtrair 1 no contador
            string stexto = sw.Elapsed.ToString();
            //Capturar 7 posições a partir do 2º caracter
            DateTime tempo1 = Convert.ToDateTime(stexto.Substring(1, 7));
            lblTempo.Text = Convert.ToString(tempo2 - tempo1);

            if(itempo == 0)
            {
                timer1.Enabled = false;
                lblTempo.Text = "FIM!!";
                Tocador.SoundLocation = "beep-sound.wav";
                Tocador.PlayLooping();
                System.Threading.Thread.Sleep(4000);  // <-- aguardar 4 minutos
                Tocador.Stop();
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSobre FS = new frmSobre();
            FS.ShowDialog();
        }
    }
}
