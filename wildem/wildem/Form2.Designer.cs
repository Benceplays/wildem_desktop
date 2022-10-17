namespace wildem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.főoldalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibaBejelentésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hirdetésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hirdetésKözzétételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.készítésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bejelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fooldal = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.fooldal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.főoldalToolStripMenuItem,
            this.hibaBejelentésekToolStripMenuItem,
            this.hirdetésekToolStripMenuItem,
            this.bejelentkezésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // főoldalToolStripMenuItem
            // 
            this.főoldalToolStripMenuItem.Name = "főoldalToolStripMenuItem";
            this.főoldalToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.főoldalToolStripMenuItem.Text = "Főoldal";
            // 
            // hibaBejelentésekToolStripMenuItem
            // 
            this.hibaBejelentésekToolStripMenuItem.Name = "hibaBejelentésekToolStripMenuItem";
            this.hibaBejelentésekToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.hibaBejelentésekToolStripMenuItem.Text = "Hiba bejelentések";
            // 
            // hirdetésekToolStripMenuItem
            // 
            this.hirdetésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hirdetésKözzétételeToolStripMenuItem,
            this.készítésToolStripMenuItem});
            this.hirdetésekToolStripMenuItem.Name = "hirdetésekToolStripMenuItem";
            this.hirdetésekToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.hirdetésekToolStripMenuItem.Text = "Hirdetések";
            // 
            // hirdetésKözzétételeToolStripMenuItem
            // 
            this.hirdetésKözzétételeToolStripMenuItem.Name = "hirdetésKözzétételeToolStripMenuItem";
            this.hirdetésKözzétételeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hirdetésKözzétételeToolStripMenuItem.Text = "Keresés";
            // 
            // készítésToolStripMenuItem
            // 
            this.készítésToolStripMenuItem.Name = "készítésToolStripMenuItem";
            this.készítésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.készítésToolStripMenuItem.Text = "Készítés";
            // 
            // bejelentkezésToolStripMenuItem
            // 
            this.bejelentkezésToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bejelentkezésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kijelentkezésToolStripMenuItem,
            this.profilomToolStripMenuItem});
            this.bejelentkezésToolStripMenuItem.Name = "bejelentkezésToolStripMenuItem";
            this.bejelentkezésToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bejelentkezésToolStripMenuItem.Text = "Bejelentkezés";
            this.bejelentkezésToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bejelentkezésToolStripMenuItem.Click += new System.EventHandler(this.bejelentkezésToolStripMenuItem_Click);
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            this.kijelentkezésToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // profilomToolStripMenuItem
            // 
            this.profilomToolStripMenuItem.Name = "profilomToolStripMenuItem";
            this.profilomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profilomToolStripMenuItem.Text = "Profilom";
            // 
            // fooldal
            // 
            this.fooldal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fooldal.Controls.Add(this.button1);
            this.fooldal.Location = new System.Drawing.Point(12, 27);
            this.fooldal.Name = "fooldal";
            this.fooldal.Size = new System.Drawing.Size(1401, 680);
            this.fooldal.TabIndex = 1;
            this.fooldal.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 709);
            this.Controls.Add(this.fooldal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wildem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fooldal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem főoldalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibaBejelentésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hirdetésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hirdetésKözzétételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem készítésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bejelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilomToolStripMenuItem;
        private System.Windows.Forms.GroupBox fooldal;
        private System.Windows.Forms.Button button1;
    }
}