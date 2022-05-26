namespace HonestFighterInitiative
{
    partial class FormOverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverlay));
            this.lbl_Line_USW = new System.Windows.Forms.Label();
            this.lbl_Line_USE = new System.Windows.Forms.Label();
            this.lbl_Line_AU = new System.Windows.Forms.Label();
            this.lbl_Line_UK = new System.Windows.Forms.Label();
            this.lbl_Line_DE = new System.Windows.Forms.Label();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.lbl_Ping_AU = new System.Windows.Forms.Label();
            this.lbl_Ping_USE = new System.Windows.Forms.Label();
            this.lbl_Ping_USW = new System.Windows.Forms.Label();
            this.lbl_Ping_UK = new System.Windows.Forms.Label();
            this.lbl_Ping_DE = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Jitter_DE = new System.Windows.Forms.Label();
            this.lbl_Jitter_UK = new System.Windows.Forms.Label();
            this.lbl_Jitter_USW = new System.Windows.Forms.Label();
            this.lbl_Jitter_USE = new System.Windows.Forms.Label();
            this.lbl_Jitter_AU = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbl_SerialNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpInfo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Line_USW
            // 
            this.lbl_Line_USW.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Line_USW.AutoSize = true;
            this.lbl_Line_USW.Location = new System.Drawing.Point(136, 33);
            this.lbl_Line_USW.Name = "lbl_Line_USW";
            this.lbl_Line_USW.Size = new System.Drawing.Size(0, 13);
            this.lbl_Line_USW.TabIndex = 22;
            this.lbl_Line_USW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Line_USW.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Line_USE
            // 
            this.lbl_Line_USE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Line_USE.AutoSize = true;
            this.lbl_Line_USE.Location = new System.Drawing.Point(136, 49);
            this.lbl_Line_USE.Name = "lbl_Line_USE";
            this.lbl_Line_USE.Size = new System.Drawing.Size(0, 13);
            this.lbl_Line_USE.TabIndex = 23;
            this.lbl_Line_USE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Line_USE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Line_AU
            // 
            this.lbl_Line_AU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Line_AU.AutoSize = true;
            this.lbl_Line_AU.Location = new System.Drawing.Point(136, 65);
            this.lbl_Line_AU.Name = "lbl_Line_AU";
            this.lbl_Line_AU.Size = new System.Drawing.Size(0, 13);
            this.lbl_Line_AU.TabIndex = 24;
            this.lbl_Line_AU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Line_AU.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Line_UK
            // 
            this.lbl_Line_UK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Line_UK.AutoSize = true;
            this.lbl_Line_UK.Location = new System.Drawing.Point(136, 17);
            this.lbl_Line_UK.Name = "lbl_Line_UK";
            this.lbl_Line_UK.Size = new System.Drawing.Size(0, 13);
            this.lbl_Line_UK.TabIndex = 21;
            this.lbl_Line_UK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Line_UK.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Line_DE
            // 
            this.lbl_Line_DE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Line_DE.AutoSize = true;
            this.lbl_Line_DE.Location = new System.Drawing.Point(136, 1);
            this.lbl_Line_DE.Name = "lbl_Line_DE";
            this.lbl_Line_DE.Size = new System.Drawing.Size(0, 13);
            this.lbl_Line_DE.TabIndex = 20;
            this.lbl_Line_DE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Line_DE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 4;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.57576F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.87878F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.54545F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlpInfo.Controls.Add(this.lbl_Clock, 0, 5);
            this.tlpInfo.Controls.Add(this.lbl_Ping_AU, 1, 4);
            this.tlpInfo.Controls.Add(this.lbl_Ping_USE, 1, 3);
            this.tlpInfo.Controls.Add(this.lbl_Ping_USW, 1, 2);
            this.tlpInfo.Controls.Add(this.lbl_Ping_UK, 1, 1);
            this.tlpInfo.Controls.Add(this.lbl_Ping_DE, 1, 0);
            this.tlpInfo.Controls.Add(this.label5, 0, 4);
            this.tlpInfo.Controls.Add(this.label4, 0, 3);
            this.tlpInfo.Controls.Add(this.label3, 0, 2);
            this.tlpInfo.Controls.Add(this.label2, 0, 1);
            this.tlpInfo.Controls.Add(this.label1, 0, 0);
            this.tlpInfo.Controls.Add(this.lbl_Jitter_DE, 2, 0);
            this.tlpInfo.Controls.Add(this.lbl_Jitter_UK, 2, 1);
            this.tlpInfo.Controls.Add(this.lbl_Jitter_USW, 2, 2);
            this.tlpInfo.Controls.Add(this.lbl_Jitter_USE, 2, 3);
            this.tlpInfo.Controls.Add(this.lbl_Jitter_AU, 2, 4);
            this.tlpInfo.Controls.Add(this.lbl_Line_DE, 3, 0);
            this.tlpInfo.Controls.Add(this.lbl_Line_UK, 3, 1);
            this.tlpInfo.Controls.Add(this.lbl_Line_USW, 3, 2);
            this.tlpInfo.Controls.Add(this.lbl_Line_USE, 3, 3);
            this.tlpInfo.Controls.Add(this.lbl_Line_AU, 3, 4);
            this.tlpInfo.Location = new System.Drawing.Point(0, 55);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 6;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfo.Size = new System.Drawing.Size(238, 100);
            this.tlpInfo.TabIndex = 0;
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.tlpInfo.SetColumnSpan(this.lbl_Clock, 2);
            this.lbl_Clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.ForeColor = System.Drawing.Color.Red;
            this.lbl_Clock.Location = new System.Drawing.Point(3, 80);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(88, 20);
            this.lbl_Clock.TabIndex = 26;
            this.lbl_Clock.Text = "Clock";
            this.lbl_Clock.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Ping_AU
            // 
            this.lbl_Ping_AU.AutoSize = true;
            this.lbl_Ping_AU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ping_AU.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Ping_AU.Location = new System.Drawing.Point(46, 64);
            this.lbl_Ping_AU.Name = "lbl_Ping_AU";
            this.lbl_Ping_AU.Size = new System.Drawing.Size(45, 16);
            this.lbl_Ping_AU.TabIndex = 14;
            this.lbl_Ping_AU.Text = "N/A";
            this.lbl_Ping_AU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Ping_AU.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Ping_USE
            // 
            this.lbl_Ping_USE.AutoSize = true;
            this.lbl_Ping_USE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ping_USE.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Ping_USE.Location = new System.Drawing.Point(46, 48);
            this.lbl_Ping_USE.Name = "lbl_Ping_USE";
            this.lbl_Ping_USE.Size = new System.Drawing.Size(45, 16);
            this.lbl_Ping_USE.TabIndex = 13;
            this.lbl_Ping_USE.Text = "N/A";
            this.lbl_Ping_USE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Ping_USE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Ping_USW
            // 
            this.lbl_Ping_USW.AutoSize = true;
            this.lbl_Ping_USW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ping_USW.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Ping_USW.Location = new System.Drawing.Point(46, 32);
            this.lbl_Ping_USW.Name = "lbl_Ping_USW";
            this.lbl_Ping_USW.Size = new System.Drawing.Size(45, 16);
            this.lbl_Ping_USW.TabIndex = 12;
            this.lbl_Ping_USW.Text = "N/A";
            this.lbl_Ping_USW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Ping_USW.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Ping_UK
            // 
            this.lbl_Ping_UK.AutoSize = true;
            this.lbl_Ping_UK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ping_UK.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Ping_UK.Location = new System.Drawing.Point(46, 16);
            this.lbl_Ping_UK.Name = "lbl_Ping_UK";
            this.lbl_Ping_UK.Size = new System.Drawing.Size(45, 16);
            this.lbl_Ping_UK.TabIndex = 11;
            this.lbl_Ping_UK.Text = "N/A";
            this.lbl_Ping_UK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Ping_UK.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Ping_DE
            // 
            this.lbl_Ping_DE.AutoSize = true;
            this.lbl_Ping_DE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ping_DE.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Ping_DE.Location = new System.Drawing.Point(46, 0);
            this.lbl_Ping_DE.Name = "lbl_Ping_DE";
            this.lbl_Ping_DE.Size = new System.Drawing.Size(45, 16);
            this.lbl_Ping_DE.TabIndex = 10;
            this.lbl_Ping_DE.Text = "N/A";
            this.lbl_Ping_DE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Ping_DE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "AU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(3, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "US-E";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "US-W";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "UK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Jitter_DE
            // 
            this.lbl_Jitter_DE.AutoSize = true;
            this.lbl_Jitter_DE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jitter_DE.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Jitter_DE.Location = new System.Drawing.Point(97, 0);
            this.lbl_Jitter_DE.Name = "lbl_Jitter_DE";
            this.lbl_Jitter_DE.Size = new System.Drawing.Size(33, 16);
            this.lbl_Jitter_DE.TabIndex = 15;
            this.lbl_Jitter_DE.Text = "N/A";
            this.lbl_Jitter_DE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Jitter_DE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Jitter_UK
            // 
            this.lbl_Jitter_UK.AutoSize = true;
            this.lbl_Jitter_UK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jitter_UK.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Jitter_UK.Location = new System.Drawing.Point(97, 16);
            this.lbl_Jitter_UK.Name = "lbl_Jitter_UK";
            this.lbl_Jitter_UK.Size = new System.Drawing.Size(33, 16);
            this.lbl_Jitter_UK.TabIndex = 16;
            this.lbl_Jitter_UK.Text = "N/A";
            this.lbl_Jitter_UK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Jitter_UK.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Jitter_USW
            // 
            this.lbl_Jitter_USW.AutoSize = true;
            this.lbl_Jitter_USW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jitter_USW.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Jitter_USW.Location = new System.Drawing.Point(97, 32);
            this.lbl_Jitter_USW.Name = "lbl_Jitter_USW";
            this.lbl_Jitter_USW.Size = new System.Drawing.Size(33, 16);
            this.lbl_Jitter_USW.TabIndex = 17;
            this.lbl_Jitter_USW.Text = "N/A";
            this.lbl_Jitter_USW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Jitter_USW.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Jitter_USE
            // 
            this.lbl_Jitter_USE.AutoSize = true;
            this.lbl_Jitter_USE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jitter_USE.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Jitter_USE.Location = new System.Drawing.Point(97, 48);
            this.lbl_Jitter_USE.Name = "lbl_Jitter_USE";
            this.lbl_Jitter_USE.Size = new System.Drawing.Size(33, 16);
            this.lbl_Jitter_USE.TabIndex = 18;
            this.lbl_Jitter_USE.Text = "N/A";
            this.lbl_Jitter_USE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Jitter_USE.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // lbl_Jitter_AU
            // 
            this.lbl_Jitter_AU.AutoSize = true;
            this.lbl_Jitter_AU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jitter_AU.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Jitter_AU.Location = new System.Drawing.Point(97, 64);
            this.lbl_Jitter_AU.Name = "lbl_Jitter_AU";
            this.lbl_Jitter_AU.Size = new System.Drawing.Size(33, 16);
            this.lbl_Jitter_AU.TabIndex = 19;
            this.lbl_Jitter_AU.Text = "N/A";
            this.lbl_Jitter_AU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Jitter_AU.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lbl_SerialNumber);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(242, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbl_SerialNumber
            // 
            this.lbl_SerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_SerialNumber.AutoSize = true;
            this.lbl_SerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SerialNumber.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_SerialNumber.Location = new System.Drawing.Point(139, 40);
            this.lbl_SerialNumber.Name = "lbl_SerialNumber";
            this.lbl_SerialNumber.Size = new System.Drawing.Size(22, 12);
            this.lbl_SerialNumber.TabIndex = 1;
            this.lbl_SerialNumber.Text = "N/A";
            this.lbl_SerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SerialNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::HonestFighterInitiative.Properties.Resources.LogoEmojiWithFont;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(242, 155);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tlpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOverlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HonestFighterInitiative";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ping_AU;
        private System.Windows.Forms.Label lbl_Ping_USE;
        private System.Windows.Forms.Label lbl_Ping_USW;
        private System.Windows.Forms.Label lbl_Ping_UK;
        private System.Windows.Forms.Label lbl_Ping_DE;
        private System.Windows.Forms.Label lbl_Jitter_DE;
        private System.Windows.Forms.Label lbl_Jitter_UK;
        private System.Windows.Forms.Label lbl_Jitter_USW;
        private System.Windows.Forms.Label lbl_Jitter_USE;
        private System.Windows.Forms.Label lbl_Jitter_AU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Line_USW;
        private System.Windows.Forms.Label lbl_Line_USE;
        private System.Windows.Forms.Label lbl_Line_AU;
        private System.Windows.Forms.Label lbl_Line_UK;
        private System.Windows.Forms.Label lbl_Line_DE;
        private System.Windows.Forms.Label lbl_SerialNumber;
        private System.Windows.Forms.Label lbl_Clock;
    }
}