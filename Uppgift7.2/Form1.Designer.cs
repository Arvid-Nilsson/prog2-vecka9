namespace Uppgift7._2
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
            this.lblÅlder = new System.Windows.Forms.Label();
            this.tbxÅlder = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnKör = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblÅlder
            // 
            this.lblÅlder.AutoSize = true;
            this.lblÅlder.Location = new System.Drawing.Point(319, 146);
            this.lblÅlder.Name = "lblÅlder";
            this.lblÅlder.Size = new System.Drawing.Size(46, 20);
            this.lblÅlder.TabIndex = 0;
            this.lblÅlder.Text = "Ålder";
            // 
            // tbxÅlder
            // 
            this.tbxÅlder.Location = new System.Drawing.Point(391, 143);
            this.tbxÅlder.Name = "tbxÅlder";
            this.tbxÅlder.Size = new System.Drawing.Size(100, 26);
            this.tbxÅlder.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(302, 192);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(200, 62);
            this.lblResults.TabIndex = 2;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(361, 284);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(98, 39);
            this.btnKör.TabIndex = 3;
            this.btnKör.Text = "Ok";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.tbxÅlder);
            this.Controls.Add(this.lblÅlder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblÅlder;
        private System.Windows.Forms.TextBox tbxÅlder;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnKör;
    }
}

