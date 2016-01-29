namespace WindowsFormsApplication1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.goDalej = new System.Windows.Forms.Button();
            this.goWstecz = new System.Windows.Forms.Button();
            this.goOdswiez = new System.Windows.Forms.Button();
            this.goZatrzymaj = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(835, 457);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.pl", System.UriKind.Absolute);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(88, 27);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(486, 20);
            this.txtAdres.TabIndex = 2;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres_KeyPress);
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.goBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.goBtn.Location = new System.Drawing.Point(591, 27);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(49, 28);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "OK";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // goDalej
            // 
            this.goDalej.Enabled = false;
            this.goDalej.Location = new System.Drawing.Point(50, 27);
            this.goDalej.Name = "goDalej";
            this.goDalej.Size = new System.Drawing.Size(32, 28);
            this.goDalej.TabIndex = 4;
            this.goDalej.Text = ">";
            this.goDalej.UseVisualStyleBackColor = true;
            this.goDalej.Click += new System.EventHandler(this.goDalej_Click);
            // 
            // goWstecz
            // 
            this.goWstecz.Enabled = false;
            this.goWstecz.Location = new System.Drawing.Point(12, 27);
            this.goWstecz.Name = "goWstecz";
            this.goWstecz.Size = new System.Drawing.Size(32, 28);
            this.goWstecz.TabIndex = 5;
            this.goWstecz.Text = "<";
            this.goWstecz.UseVisualStyleBackColor = true;
            this.goWstecz.Click += new System.EventHandler(this.goWstecz_Click);
            // 
            // goOdswiez
            // 
            this.goOdswiez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goOdswiez.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.goOdswiez.Location = new System.Drawing.Point(682, 27);
            this.goOdswiez.Name = "goOdswiez";
            this.goOdswiez.Size = new System.Drawing.Size(56, 28);
            this.goOdswiez.TabIndex = 6;
            this.goOdswiez.Text = "Odśwież";
            this.goOdswiez.UseVisualStyleBackColor = true;
            this.goOdswiez.Click += new System.EventHandler(this.goOdswiez_Click);
            // 
            // goZatrzymaj
            // 
            this.goZatrzymaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goZatrzymaj.ForeColor = System.Drawing.Color.Red;
            this.goZatrzymaj.Location = new System.Drawing.Point(744, 27);
            this.goZatrzymaj.Name = "goZatrzymaj";
            this.goZatrzymaj.Size = new System.Drawing.Size(56, 28);
            this.goZatrzymaj.TabIndex = 7;
            this.goZatrzymaj.Text = "Stop";
            this.goZatrzymaj.UseVisualStyleBackColor = true;
            this.goZatrzymaj.Click += new System.EventHandler(this.goZatrzymaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 518);
            this.Controls.Add(this.goZatrzymaj);
            this.Controls.Add(this.goOdswiez);
            this.Controls.Add(this.goWstecz);
            this.Controls.Add(this.goDalej);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Przeglądarka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button goDalej;
        private System.Windows.Forms.Button goWstecz;
        private System.Windows.Forms.Button goOdswiez;
        private System.Windows.Forms.Button goZatrzymaj;
    }
}

