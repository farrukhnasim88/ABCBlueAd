namespace MainForm
{
    partial class ABCBlueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABCBlueForm));
            this.btnClients = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManagers = new System.Windows.Forms.Button();
            this.btnAdverts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClients.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClients.Location = new System.Drawing.Point(72, 111);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(239, 56);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABC Blue Agency Pty Ltd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManagers
            // 
            this.btnManagers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnManagers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManagers.Location = new System.Drawing.Point(72, 390);
            this.btnManagers.Name = "btnManagers";
            this.btnManagers.Size = new System.Drawing.Size(239, 55);
            this.btnManagers.TabIndex = 5;
            this.btnManagers.Text = "Managers";
            this.btnManagers.UseVisualStyleBackColor = false;
            this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
            // 
            // btnAdverts
            // 
            this.btnAdverts.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdverts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdverts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdverts.Location = new System.Drawing.Point(72, 300);
            this.btnAdverts.Name = "btnAdverts";
            this.btnAdverts.Size = new System.Drawing.Size(239, 54);
            this.btnAdverts.TabIndex = 6;
            this.btnAdverts.Text = "Advertisements";
            this.btnAdverts.UseVisualStyleBackColor = false;
            this.btnAdverts.Click += new System.EventHandler(this.btnAdverts_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReports.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReports.Location = new System.Drawing.Point(72, 477);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(239, 55);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(72, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 54);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(72, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Brands";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 506);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 100);
            this.panel1.TabIndex = 11;
            // 
            // ABCBlueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1109, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnAdverts);
            this.Controls.Add(this.btnManagers);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.panel1);
            this.Name = "ABCBlueForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagers;
        private System.Windows.Forms.Button btnAdverts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

