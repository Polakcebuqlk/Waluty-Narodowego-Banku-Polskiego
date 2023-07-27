namespace Waluty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.WybieranieDatyPliku = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Zrodlo = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wybieraniewaluty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KursSprzText = new System.Windows.Forms.Label();
            this.KursKupText = new System.Windows.Forms.Label();
            this.PrzelicznikText = new System.Windows.Forms.Label();
            this.KodText = new System.Windows.Forms.Label();
            this.NazwaText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz datę";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // WybieranieDatyPliku
            // 
            this.WybieranieDatyPliku.Location = new System.Drawing.Point(2, 40);
            this.WybieranieDatyPliku.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.WybieranieDatyPliku.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.WybieranieDatyPliku.Name = "WybieranieDatyPliku";
            this.WybieranieDatyPliku.Size = new System.Drawing.Size(206, 20);
            this.WybieranieDatyPliku.TabIndex = 1;
            this.WybieranieDatyPliku.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(68, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wybierz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zrodlo
            // 
            this.Zrodlo.AutoSize = true;
            this.Zrodlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zrodlo.Location = new System.Drawing.Point(165, 24);
            this.Zrodlo.Name = "Zrodlo";
            this.Zrodlo.Size = new System.Drawing.Size(43, 13);
            this.Zrodlo.TabIndex = 4;
            this.Zrodlo.TabStop = true;
            this.Zrodlo.Text = "źródło";
            this.Zrodlo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Zrodlo_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem1});
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.otwórzToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem1
            // 
            this.otwórzToolStripMenuItem1.Name = "otwórzToolStripMenuItem1";
            this.otwórzToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem1.Text = "Nowy";
            this.otwórzToolStripMenuItem1.Click += new System.EventHandler(this.otwórzToolStripMenuItem1_Click);
            // 
            // wybieraniewaluty
            // 
            this.wybieraniewaluty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wybieraniewaluty.FormattingEnabled = true;
            this.wybieraniewaluty.Location = new System.Drawing.Point(2, 109);
            this.wybieraniewaluty.MaxDropDownItems = 13;
            this.wybieraniewaluty.Name = "wybieraniewaluty";
            this.wybieraniewaluty.Size = new System.Drawing.Size(206, 21);
            this.wybieraniewaluty.TabIndex = 6;
            this.wybieraniewaluty.SelectedIndexChanged += new System.EventHandler(this.wybieraniewaluty_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wybierz walutę";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KursSprzText);
            this.groupBox1.Controls.Add(this.KursKupText);
            this.groupBox1.Controls.Add(this.PrzelicznikText);
            this.groupBox1.Controls.Add(this.KodText);
            this.groupBox1.Controls.Add(this.NazwaText);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 124);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // KursSprzText
            // 
            this.KursSprzText.AutoSize = true;
            this.KursSprzText.Location = new System.Drawing.Point(7, 100);
            this.KursSprzText.Name = "KursSprzText";
            this.KursSprzText.Size = new System.Drawing.Size(84, 13);
            this.KursSprzText.TabIndex = 4;
            this.KursSprzText.Text = "Kurs sprzedaży: ";
            // 
            // KursKupText
            // 
            this.KursKupText.AutoSize = true;
            this.KursKupText.Location = new System.Drawing.Point(7, 80);
            this.KursKupText.Name = "KursKupText";
            this.KursKupText.Size = new System.Drawing.Size(67, 13);
            this.KursKupText.TabIndex = 3;
            this.KursKupText.Text = "Kurs kupna: ";
            // 
            // PrzelicznikText
            // 
            this.PrzelicznikText.AutoSize = true;
            this.PrzelicznikText.Location = new System.Drawing.Point(7, 60);
            this.PrzelicznikText.Name = "PrzelicznikText";
            this.PrzelicznikText.Size = new System.Drawing.Size(60, 13);
            this.PrzelicznikText.TabIndex = 2;
            this.PrzelicznikText.Text = "Przelicznik:";
            this.PrzelicznikText.Click += new System.EventHandler(this.label5_Click);
            // 
            // KodText
            // 
            this.KodText.AutoSize = true;
            this.KodText.Location = new System.Drawing.Point(7, 40);
            this.KodText.Name = "KodText";
            this.KodText.Size = new System.Drawing.Size(65, 13);
            this.KodText.TabIndex = 1;
            this.KodText.Text = "Kod waluty: ";
            // 
            // NazwaText
            // 
            this.NazwaText.AutoSize = true;
            this.NazwaText.Location = new System.Drawing.Point(7, 20);
            this.NazwaText.Name = "NazwaText";
            this.NazwaText.Size = new System.Drawing.Size(79, 13);
            this.NazwaText.TabIndex = 0;
            this.NazwaText.Text = "Nazwa waluty: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(210, 270);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wybieraniewaluty);
            this.Controls.Add(this.Zrodlo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WybieranieDatyPliku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waluty";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker WybieranieDatyPliku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel Zrodlo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem1;
        private System.Windows.Forms.ComboBox wybieraniewaluty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label KursKupText;
        private System.Windows.Forms.Label PrzelicznikText;
        private System.Windows.Forms.Label KodText;
        private System.Windows.Forms.Label NazwaText;
        private System.Windows.Forms.Label KursSprzText;
    }
}

