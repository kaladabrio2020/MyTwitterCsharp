namespace MyTwitter.JanelaMyTwitter
{
    partial class MyTwitterC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTimeLine = new System.Windows.Forms.Button();
            this.buttonAmigos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PainelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTwettar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PainelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.checkAtivo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonTimeLine);
            this.panel1.Controls.Add(this.buttonAmigos);
            this.panel1.Controls.Add(this.buttonTwettar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 543);
            this.panel1.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Fira Code", 10F);
            this.labelNome.ForeColor = System.Drawing.Color.Red;
            this.labelNome.Location = new System.Drawing.Point(101, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 17);
            this.labelNome.TabIndex = 7;
            this.labelNome.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(80, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "0";
            // 
            // checkAtivo
            // 
            this.checkAtivo.AutoSize = true;
            this.checkAtivo.Font = new System.Drawing.Font("Fira Code", 9F);
            this.checkAtivo.ForeColor = System.Drawing.Color.Red;
            this.checkAtivo.Location = new System.Drawing.Point(70, 113);
            this.checkAtivo.Name = "checkAtivo";
            this.checkAtivo.Size = new System.Drawing.Size(75, 19);
            this.checkAtivo.TabIndex = 6;
            this.checkAtivo.Text = "Offline";
            this.checkAtivo.UseVisualStyleBackColor = true;
            this.checkAtivo.CheckedChanged += new System.EventHandler(this.checkAtivo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(80, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Code", 7F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seguidos  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 7F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seguidores:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Fira Code", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonTimeLine
            // 
            this.buttonTimeLine.BackColor = System.Drawing.Color.Black;
            this.buttonTimeLine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonTimeLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonTimeLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonTimeLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeLine.Font = new System.Drawing.Font("Fira Code", 9F);
            this.buttonTimeLine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTimeLine.Location = new System.Drawing.Point(3, 251);
            this.buttonTimeLine.Name = "buttonTimeLine";
            this.buttonTimeLine.Size = new System.Drawing.Size(203, 42);
            this.buttonTimeLine.TabIndex = 3;
            this.buttonTimeLine.Text = "TimeLine";
            this.buttonTimeLine.UseVisualStyleBackColor = false;
            this.buttonTimeLine.Click += new System.EventHandler(this.buttonTimeLine_Click);
            // 
            // buttonAmigos
            // 
            this.buttonAmigos.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAmigos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAmigos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.buttonAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAmigos.Font = new System.Drawing.Font("Fira Code", 9F);
            this.buttonAmigos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAmigos.Location = new System.Drawing.Point(3, 192);
            this.buttonAmigos.Name = "buttonAmigos";
            this.buttonAmigos.Size = new System.Drawing.Size(203, 42);
            this.buttonAmigos.TabIndex = 2;
            this.buttonAmigos.Text = "Amigos";
            this.buttonAmigos.UseVisualStyleBackColor = true;
            this.buttonAmigos.Click += new System.EventHandler(this.buttonAmigos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fira Code", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // PainelMain
            // 
            this.PainelMain.BackColor = System.Drawing.Color.SteelBlue;
            this.PainelMain.Controls.Add(this.panel2);
            this.PainelMain.Location = new System.Drawing.Point(200, 0);
            this.PainelMain.Name = "PainelMain";
            this.PainelMain.Size = new System.Drawing.Size(668, 540);
            this.PainelMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 539);
            this.panel2.TabIndex = 1;
            // 
            // buttonTwettar
            // 
            this.buttonTwettar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonTwettar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonTwettar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonTwettar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTwettar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwettar.Font = new System.Drawing.Font("Fira Code", 9F);
            this.buttonTwettar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTwettar.Location = new System.Drawing.Point(3, 309);
            this.buttonTwettar.Name = "buttonTwettar";
            this.buttonTwettar.Size = new System.Drawing.Size(203, 42);
            this.buttonTwettar.TabIndex = 1;
            this.buttonTwettar.Text = "Tweetar";
            this.buttonTwettar.UseVisualStyleBackColor = false;
            this.buttonTwettar.Click += new System.EventHandler(this.buttonTwettar_Click);
            // 
            // MyTwitterC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(860, 538);
            this.Controls.Add(this.PainelMain);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyTwitterC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTwitterC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyTwitterC_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PainelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAmigos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTimeLine;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkAtivo;
        private System.Windows.Forms.Panel PainelMain;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTwettar;
    }
}