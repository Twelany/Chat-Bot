namespace Artificial_Intelligence_Chatbot
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.PictureBox();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Silver;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.Font = new System.Drawing.Font("Meiryo UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.Black;
            this.InputBox.Location = new System.Drawing.Point(12, 385);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(226, 21);
            this.InputBox.TabIndex = 1;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Font = new System.Drawing.Font("Meiryo UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.ForeColor = System.Drawing.Color.Black;
            this.OutputBox.Location = new System.Drawing.Point(12, 236);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(260, 138);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "Hi Twelany\r\nHow Can I Help You?";
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.Silver;
            this.SendBtn.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources.icons8_Sent_512px;
            this.SendBtn.Location = new System.Drawing.Point(244, 380);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(29, 30);
            this.SendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SendBtn.TabIndex = 3;
            this.SendBtn.TabStop = false;
            this.SendBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MainLogo
            // 
            this.MainLogo.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources._1;
            this.MainLogo.Location = new System.Drawing.Point(-1, -27);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(287, 543);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.MainLogo);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twelany";
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox SendBtn;
    }
}

