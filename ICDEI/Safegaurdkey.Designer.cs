namespace ICDEI
{
    partial class Safegaurdkey
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
            this.tex = new System.Windows.Forms.TextBox();
            this.succ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tex
            // 
            this.tex.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex.ForeColor = System.Drawing.Color.Aqua;
            this.tex.Location = new System.Drawing.Point(12, 27);
            this.tex.Multiline = true;
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(550, 321);
            this.tex.TabIndex = 0;
            // 
            // succ
            // 
            this.succ.BackColor = System.Drawing.Color.Black;
            this.succ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.succ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.succ.ForeColor = System.Drawing.Color.Fuchsia;
            this.succ.Location = new System.Drawing.Point(93, 380);
            this.succ.Name = "succ";
            this.succ.Size = new System.Drawing.Size(378, 33);
            this.succ.TabIndex = 1;
            this.succ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Safegaurdkey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(574, 517);
            this.Controls.Add(this.succ);
            this.Controls.Add(this.tex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Safegaurdkey";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Safegaurdkey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.TextBox succ;
    }
}