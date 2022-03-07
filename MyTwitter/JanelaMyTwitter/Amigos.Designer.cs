namespace MyTwitter.JanelaMyTwitter
{
    partial class Amigos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textAmigo = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextSeguidos = new System.Windows.Forms.Label();
            this.TextSeguidores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amigos";
            // 
            // textAmigo
            // 
            this.textAmigo.Location = new System.Drawing.Point(209, 86);
            this.textAmigo.Name = "textAmigo";
            this.textAmigo.Size = new System.Drawing.Size(222, 20);
            this.textAmigo.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Location = new System.Drawing.Point(285, 112);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdcionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 9F);
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seguidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 9F);
            this.label3.Location = new System.Drawing.Point(561, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seguidores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Code", 8.75F);
            this.label4.Location = new System.Drawing.Point(206, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seguir alguem";
            // 
            // TextSeguidos
            // 
            this.TextSeguidos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextSeguidos.Location = new System.Drawing.Point(12, 117);
            this.TextSeguidos.Name = "TextSeguidos";
            this.TextSeguidos.Size = new System.Drawing.Size(165, 374);
            this.TextSeguidos.TabIndex = 10;
            // 
            // TextSeguidores
            // 
            this.TextSeguidores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextSeguidores.Location = new System.Drawing.Point(473, 117);
            this.TextSeguidores.Name = "TextSeguidores";
            this.TextSeguidores.Size = new System.Drawing.Size(165, 374);
            this.TextSeguidores.TabIndex = 11;
            // 
            // Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.TextSeguidores);
            this.Controls.Add(this.TextSeguidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textAmigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Amigos";
            this.Text = "Amigos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAmigo;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TextSeguidos;
        private System.Windows.Forms.Label TextSeguidores;
    }
}