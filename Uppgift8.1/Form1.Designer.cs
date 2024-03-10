namespace Uppgift
{
    partial class Form1
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
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSpelet.SuspendLayout();
            this.gbxSpeldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(6, 50);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(100, 20);
            this.lblStörstaTalet.TabIndex = 0;
            this.lblStörstaTalet.Text = "Största talet ";
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(610, 125);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(110, 43);
            this.btnStartaSpelet.TabIndex = 1;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(610, 174);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(110, 33);
            this.btnSpelaIgen.TabIndex = 2;
            this.btnSpelaIgen.Text = "Spela igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.btnSpelaIgen_Click);
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(6, 101);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(84, 20);
            this.lblDator.TabIndex = 3;
            this.lblDator.Text = "datorns tal";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(6, 149);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(94, 20);
            this.lblGissa.TabIndex = 4;
            this.lblGissa.Text = "Gissa ett tal";
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(127, 101);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsTal.TabIndex = 5;
            this.lblDatornsTal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(127, 143);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(100, 26);
            this.tbxGissa.TabIndex = 6;
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(251, 113);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(88, 44);
            this.btnGissa.TabIndex = 7;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(598, 279);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(134, 93);
            this.tbxMinaResultat.TabIndex = 8;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(598, 235);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(100, 20);
            this.lblMinaResultat.TabIndex = 9;
            this.lblMinaResultat.Text = "Mina resultat";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(115, 181);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(126, 34);
            this.lblResultat.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Uppgift.Properties.Resources.gissa_mitt_tal;
            this.pictureBox1.Location = new System.Drawing.Point(64, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 60);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblStörstaTalet);
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Enabled = false;
            this.gbxSpelet.Location = new System.Drawing.Point(83, 210);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(345, 228);
            this.gbxSpelet.TabIndex = 12;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "spelet";
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(83, 98);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(345, 93);
            this.gbxSpeldata.TabIndex = 13;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.ItemHeight = 20;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(101, 27);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(112, 44);
            this.lbxStörstaTalet.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMinaResultat);
            this.Controls.Add(this.tbxMinaResultat);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.gbxSpeldata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStörstaTalet;
        private System.Windows.Forms.Button btnStartaSpelet;
        private System.Windows.Forms.Button btnSpelaIgen;
        private System.Windows.Forms.Label lblDator;
        private System.Windows.Forms.Label lblGissa;
        private System.Windows.Forms.Label lblDatornsTal;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Label lblMinaResultat;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxSpelet;
        private System.Windows.Forms.GroupBox gbxSpeldata;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
    }
}

