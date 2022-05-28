namespace HonestFighterInitiative
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pcb_Logo_Spear = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo_Spear)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Logo_Spear
            // 
            this.pcb_Logo_Spear.Image = global::HonestFighterInitiative.Properties.Resources.spearlogov2_200x200;
            this.pcb_Logo_Spear.Location = new System.Drawing.Point(688, 13);
            this.pcb_Logo_Spear.Name = "pcb_Logo_Spear";
            this.pcb_Logo_Spear.Size = new System.Drawing.Size(100, 108);
            this.pcb_Logo_Spear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Logo_Spear.TabIndex = 0;
            this.pcb_Logo_Spear.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Euro Caps", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(471, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by\r\nAKUMA TEBORI and Conparator\r\nfrom\r\nTHE SPEAR NETWORK";
            // 
            // rtb_Text
            // 
            this.rtb_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtb_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Text.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Text.ForeColor = System.Drawing.Color.Orange;
            this.rtb_Text.Location = new System.Drawing.Point(12, 127);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.ReadOnly = true;
            this.rtb_Text.Size = new System.Drawing.Size(776, 397);
            this.rtb_Text.TabIndex = 2;
            this.rtb_Text.Text = resources.GetString("rtb_Text.Text");
            this.rtb_Text.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_Text_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Orange;
            this.richTextBox1.Location = new System.Drawing.Point(474, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(208, 33);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "https://elitedangerous-spear.com";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_Text_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtb_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Logo_Spear);
            this.Font = new System.Drawing.Font("Euro Caps", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honest Fighter Initiative - About";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo_Spear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Logo_Spear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

