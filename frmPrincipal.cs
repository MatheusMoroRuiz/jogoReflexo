using FizzWare.NBuilder.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jogo
{
    public partial class frmPrincipal : Form
    {
        public int contadoracertos=0, contadorerros=0, codigoCliente;
        public string email="matheus@gmail.com";
        public DateTime jogar, parar;
        public TimeSpan tempototal;
        public int recorde;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parar = DateTime.Now;
            tempototal = parar - jogar;
            lblTempoTotal.Text = Convert.ToString(tempototal);

            if(contadoracertos > recorde)
            {
                recorde = contadoracertos;
            }

            btnJogar.Enabled = true;
            btnBolinha.Enabled = false;
            btnEncerrar.Enabled = false;
            tmrPosicao.Enabled = false;

            clsJogo jogo = new clsJogo();
            jogo.email = email;

            MessageBox.Show("Parabéns, você acertou " + contadoracertos + " vezes o macaco e ENCERROU a partida!", "Encerrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            contadoracertos = 0;
            contadorerros = 0;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblNome.Text = email;
        }

        private void btnBolinha_Click(object sender, EventArgs e)
        {
            int X, Y;
            clsJogo posi = new clsJogo();
            X = posi.RandomizarX();
            Y = posi.RandomizarY();

            btnBolinha.Location = new Point(X, Y);

            contadoracertos++;
            lblContadorAcertos.Text = contadoracertos.ToString();

            if (contadoracertos % 4 == 0)
            {
                tmrPosicao.Interval = (tmrPosicao.Interval / 2);
            }
        }

        private void btnFundo_Click(object sender, EventArgs e)
        {

            contadorerros++;
            lblContadorErros.Text = contadorerros.ToString();


            if (contadorerros % 10 == 0)
            {
                MessageBox.Show("Você errou 10 vezes e PERDEU!", "Encerrar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                parar = DateTime.Now;
                tempototal = parar - jogar;
                lblTempoTotal.Text = Convert.ToString(tempototal);

                btnFundo.Enabled = false;
                btnJogar.Enabled = true;
                btnBolinha.Enabled = false;
                btnEncerrar.Enabled = false;
                tmrPosicao.Enabled = false;

                clsJogo jogo = new clsJogo();
                jogo.email = email;

                contadoracertos = 0;
                contadorerros = 0;

            }
        }

        private void lblTempoTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblRecorde_Click(object sender, EventArgs e)
        {
   
        }

        private void pnlRegistros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrPosicao_Tick(object sender, EventArgs e)
        {
            int X, Y;
            clsJogo posi = new clsJogo();
            X = posi.RandomizarX();
            Y = posi.RandomizarY();

            btnBolinha.Location = new Point(X, Y);
        }

        private void pnlBolinha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            jogar = DateTime.Now;

            btnFundo.Enabled = true;
            btnJogar.Enabled = false;
            btnBolinha.Enabled = true;
            btnEncerrar.Enabled = true;
            tmrPosicao.Interval = 2000;
            tmrPosicao.Enabled = true;
            lblContadorAcertos.Text = "0";
            lblContadorErros.Text = "0";
        }
    }
}
