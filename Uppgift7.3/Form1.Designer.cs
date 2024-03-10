namespace Uppgift7._3
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(321, 211);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(106, 20);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Antal Prickar: ";
            // 
            // tbxPoints
            // 
            this.tbxPoints.Location = new System.Drawing.Point(446, 211);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(100, 26);
            this.tbxPoints.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(336, 294);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(176, 39);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Kasta tärning";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.lblPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.Button btnRun;
    }
}

