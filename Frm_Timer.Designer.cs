
namespace Timer
{
    partial class frm_Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Timer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.cbbTempo = new System.Windows.Forms.ComboBox();
            this.lblTituloTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTempo);
            this.panel1.Controls.Add(this.lblLink);
            this.panel1.Controls.Add(this.btnParar);
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Controls.Add(this.lblMin);
            this.panel1.Controls.Add(this.cbbTempo);
            this.panel1.Controls.Add(this.lblTituloTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTempo.Location = new System.Drawing.Point(305, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(34, 47);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "-";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkColor = System.Drawing.Color.MidnightBlue;
            this.lblLink.Location = new System.Drawing.Point(346, 63);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(185, 13);
            this.lblLink.TabIndex = 5;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Desenvolvido por Jesher Minelli Alves";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnParar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnParar.Location = new System.Drawing.Point(164, 43);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(84, 24);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciar.Location = new System.Drawing.Point(164, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(84, 24);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMin.Location = new System.Drawing.Point(99, 43);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(55, 17);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minutos";
            // 
            // cbbTempo
            // 
            this.cbbTempo.BackColor = System.Drawing.SystemColors.Menu;
            this.cbbTempo.FormattingEnabled = true;
            this.cbbTempo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "120"});
            this.cbbTempo.Location = new System.Drawing.Point(22, 39);
            this.cbbTempo.Name = "cbbTempo";
            this.cbbTempo.Size = new System.Drawing.Size(71, 21);
            this.cbbTempo.TabIndex = 1;
            // 
            // lblTituloTemp
            // 
            this.lblTituloTemp.AutoSize = true;
            this.lblTituloTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTemp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloTemp.Location = new System.Drawing.Point(19, 19);
            this.lblTituloTemp.Name = "lblTituloTemp";
            this.lblTituloTemp.Size = new System.Drawing.Size(54, 17);
            this.lblTituloTemp.TabIndex = 0;
            this.lblTituloTemp.Text = "Tempo:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 81);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Timer";
            this.Text = "Timer Run - Jesher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.ComboBox cbbTempo;
        private System.Windows.Forms.Label lblTituloTemp;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
    }
}

