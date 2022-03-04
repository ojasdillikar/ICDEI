namespace ICDEI
{
    partial class main_ui
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.safe = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.sidemenup = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logop.SuspendLayout();
            this.sidemenup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 556);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ICDEI.Properties.Resources.asdf_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(133, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logop
            // 
            this.logop.Controls.Add(this.label1);
            this.logop.Dock = System.Windows.Forms.DockStyle.Top;
            this.logop.Location = new System.Drawing.Point(0, 0);
            this.logop.Name = "logop";
            this.logop.Size = new System.Drawing.Size(250, 98);
            this.logop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "   I C D E I";
            // 
            // safe
            // 
            this.safe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.safe.Dock = System.Windows.Forms.DockStyle.Top;
            this.safe.FlatAppearance.BorderSize = 0;
            this.safe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.safe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.safe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safe.ForeColor = System.Drawing.Color.Beige;
            this.safe.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.safe.IconColor = System.Drawing.Color.Chartreuse;
            this.safe.IconSize = 40;
            this.safe.Location = new System.Drawing.Point(0, 98);
            this.safe.Name = "safe";
            this.safe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.safe.Rotation = 0D;
            this.safe.Size = new System.Drawing.Size(250, 45);
            this.safe.TabIndex = 1;
            this.safe.Text = "Generate Safe Gaurd Key";
            this.safe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.safe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.safe.UseVisualStyleBackColor = true;
            this.safe.Click += new System.EventHandler(this.safe_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Beige;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.Turquoise;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(0, 143);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(250, 45);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Message             ";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Beige;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton2.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(0, 188);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(250, 45);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Help                 ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Beige;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton3.IconSize = 40;
            this.iconButton3.Location = new System.Drawing.Point(0, 511);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(250, 45);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Exit                 ";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // sidemenup
            // 
            this.sidemenup.AutoScroll = true;
            this.sidemenup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sidemenup.Controls.Add(this.iconButton3);
            this.sidemenup.Controls.Add(this.iconButton2);
            this.sidemenup.Controls.Add(this.iconButton1);
            this.sidemenup.Controls.Add(this.safe);
            this.sidemenup.Controls.Add(this.logop);
            this.sidemenup.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenup.ForeColor = System.Drawing.Color.Coral;
            this.sidemenup.Location = new System.Drawing.Point(0, 0);
            this.sidemenup.Name = "sidemenup";
            this.sidemenup.Size = new System.Drawing.Size(250, 556);
            this.sidemenup.TabIndex = 0;
            // 
            // main_ui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidemenup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(840, 556);
            this.Name = "main_ui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.main_ui_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logop.ResumeLayout(false);
            this.logop.PerformLayout();
            this.sidemenup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel logop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton safe;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel sidemenup;
    }
}