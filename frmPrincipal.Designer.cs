
namespace Jogo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblContadorAcertos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempoTotal = new System.Windows.Forms.Label();
            this.lblContadorErros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.tmrPosicao = new System.Windows.Forms.Timer(this.components);
            this.btnFundo = new System.Windows.Forms.Button();
            this.btnBolinha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.BackColor = System.Drawing.Color.Gold;
            this.pnlRegistros.Controls.Add(this.lblNome);
            this.pnlRegistros.Controls.Add(this.lblContadorAcertos);
            this.pnlRegistros.Controls.Add(this.label1);
            this.pnlRegistros.Controls.Add(this.label2);
            this.pnlRegistros.Controls.Add(this.lblTempoTotal);
            this.pnlRegistros.Controls.Add(this.lblContadorErros);
            this.pnlRegistros.Controls.Add(this.label3);
            this.pnlRegistros.Location = new System.Drawing.Point(789, 122);
            this.pnlRegistros.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(342, 392);
            this.pnlRegistros.TabIndex = 1;
            this.pnlRegistros.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistros_Paint);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(44, 25);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(250, 46);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome Usuário";
            // 
            // lblContadorAcertos
            // 
            this.lblContadorAcertos.AutoSize = true;
            this.lblContadorAcertos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContadorAcertos.Location = new System.Drawing.Point(175, 95);
            this.lblContadorAcertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContadorAcertos.Name = "lblContadorAcertos";
            this.lblContadorAcertos.Size = new System.Drawing.Size(32, 37);
            this.lblContadorAcertos.TabIndex = 1;
            this.lblContadorAcertos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACERTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "ERROS";
            // 
            // lblTempoTotal
            // 
            this.lblTempoTotal.AutoSize = true;
            this.lblTempoTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTempoTotal.Location = new System.Drawing.Point(175, 209);
            this.lblTempoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempoTotal.Name = "lblTempoTotal";
            this.lblTempoTotal.Size = new System.Drawing.Size(119, 37);
            this.lblTempoTotal.TabIndex = 6;
            this.lblTempoTotal.Text = "00:00:00";
            this.lblTempoTotal.Click += new System.EventHandler(this.lblTempoTotal_Click);
            // 
            // lblContadorErros
            // 
            this.lblContadorErros.AutoSize = true;
            this.lblContadorErros.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContadorErros.Location = new System.Drawing.Point(175, 148);
            this.lblContadorErros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContadorErros.Name = "lblContadorErros";
            this.lblContadorErros.Size = new System.Drawing.Size(32, 37);
            this.lblContadorErros.TabIndex = 3;
            this.lblContadorErros.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "TEMPO";
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJogar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnJogar.Location = new System.Drawing.Point(789, 529);
            this.btnJogar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(158, 70);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncerrar.Location = new System.Drawing.Point(973, 529);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(158, 70);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "ENCERRAR";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmrPosicao
            // 
            this.tmrPosicao.Interval = 2000;
            this.tmrPosicao.Tick += new System.EventHandler(this.tmrPosicao_Tick);
            // 
            // btnFundo
            // 
            this.btnFundo.Location = new System.Drawing.Point(11, 122);
            this.btnFundo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFundo.Name = "btnFundo";
            this.btnFundo.Size = new System.Drawing.Size(749, 477);
            this.btnFundo.TabIndex = 0;
            this.btnFundo.UseVisualStyleBackColor = true;
            this.btnFundo.Click += new System.EventHandler(this.btnFundo_Click);
            // 
            // btnBolinha
            // 
            this.btnBolinha.BackColor = System.Drawing.Color.Transparent;
            this.btnBolinha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBolinha.BackgroundImage")));
            this.btnBolinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBolinha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBolinha.Location = new System.Drawing.Point(360, 245);
            this.btnBolinha.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBolinha.Name = "btnBolinha";
            this.btnBolinha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBolinha.Size = new System.Drawing.Size(135, 100);
            this.btnBolinha.TabIndex = 0;
            this.btnBolinha.UseVisualStyleBackColor = false;
            this.btnBolinha.Click += new System.EventHandler(this.btnBolinha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 39F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(117, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 70);
            this.label4.TabIndex = 4;
            this.label4.Text = "JOGO DO REFLEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(687, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Objetivo: clicar o máximo de vezes em cima do macaco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(687, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Regras: Se você errar 5 vezes você perde automaticamente.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(687, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(454, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "A cada acerto no macaco, ele irá se mover aleatoriamente dentro da área";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(687, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "O macaco a cada 2 segundos muda de lugar aleatoriamente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(687, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(476, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "A cada 5 acertos, o tempo irá dividir pela metade e começar a ir mais rápido ";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1161, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBolinha);
            this.Controls.Add(this.btnFundo);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pnlRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do MACACO";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Timer tmrPosicao;
        private System.Windows.Forms.Label lblContadorAcertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContadorErros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTempoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFundo;
        private System.Windows.Forms.Button btnBolinha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}