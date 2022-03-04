namespace ICDEI
{
    partial class Message
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
            this.chatd = new System.Windows.Forms.ListBox();
            this.textpanel = new System.Windows.Forms.Panel();
            this.send = new FontAwesome.Sharp.IconButton();
            this.stext = new System.Windows.Forms.TextBox();
            this.pport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lllb = new System.Windows.Forms.Label();
            this.lsl = new System.Windows.Forms.Label();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatd
            // 
            this.chatd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chatd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatd.FormattingEnabled = true;
            this.chatd.Location = new System.Drawing.Point(7, 162);
            this.chatd.Name = "chatd";
            this.chatd.Size = new System.Drawing.Size(561, 273);
            this.chatd.TabIndex = 1;
            this.chatd.SelectedIndexChanged += new System.EventHandler(this.chatd_SelectedIndexChanged);
            // 
            // textpanel
            // 
            this.textpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(32)))));
            this.textpanel.Controls.Add(this.send);
            this.textpanel.Controls.Add(this.stext);
            this.textpanel.Location = new System.Drawing.Point(2, 480);
            this.textpanel.Name = "textpanel";
            this.textpanel.Size = new System.Drawing.Size(575, 39);
            this.textpanel.TabIndex = 2;
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.send.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.Beige;
            this.send.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.send.IconColor = System.Drawing.Color.Coral;
            this.send.IconSize = 25;
            this.send.Location = new System.Drawing.Point(439, 4);
            this.send.Name = "send";
            this.send.Rotation = 0D;
            this.send.Size = new System.Drawing.Size(126, 33);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // stext
            // 
            this.stext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stext.Location = new System.Drawing.Point(7, 7);
            this.stext.Multiline = true;
            this.stext.Name = "stext";
            this.stext.Size = new System.Drawing.Size(422, 31);
            this.stext.TabIndex = 0;
            // 
            // pport
            // 
            this.pport.Location = new System.Drawing.Point(209, 88);
            this.pport.Name = "pport";
            this.pport.Size = new System.Drawing.Size(97, 20);
            this.pport.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port :";
            // 
            // rip
            // 
            this.rip.Location = new System.Drawing.Point(53, 87);
            this.rip.Name = "rip";
            this.rip.Size = new System.Drawing.Size(97, 20);
            this.rip.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP :";
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Beige;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton1.IconColor = System.Drawing.Color.Turquoise;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(160, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(346, 45);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Message             ";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton2.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(37, 31);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lllb
            // 
            this.lllb.AutoSize = true;
            this.lllb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lllb.ForeColor = System.Drawing.Color.Beige;
            this.lllb.Location = new System.Drawing.Point(-2, 46);
            this.lllb.Name = "lllb";
            this.lllb.Size = new System.Drawing.Size(63, 19);
            this.lllb.TabIndex = 11;
            this.lllb.Text = "Your IP:";
            // 
            // lsl
            // 
            this.lsl.AutoSize = true;
            this.lsl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsl.ForeColor = System.Drawing.Color.Red;
            this.lsl.Location = new System.Drawing.Point(67, 46);
            this.lsl.Name = "lsl";
            this.lsl.Size = new System.Drawing.Size(0, 19);
            this.lsl.TabIndex = 12;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Chartreuse;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Empire;
            this.iconButton3.IconColor = System.Drawing.Color.Coral;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(425, 87);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(143, 34);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Connect";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(471, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 19);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Beige;
            this.label3.Location = new System.Drawing.Point(371, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Your Port :";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(574, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.lsl);
            this.Controls.Add(this.lllb);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpanel);
            this.Controls.Add(this.chatd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Message_Load);
            this.textpanel.ResumeLayout(false);
            this.textpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox chatd;
        private System.Windows.Forms.Panel textpanel;
        private System.Windows.Forms.TextBox stext;
        private FontAwesome.Sharp.IconButton send;
        private System.Windows.Forms.TextBox pport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rip;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lllb;
        private System.Windows.Forms.Label lsl;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}