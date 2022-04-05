namespace CS_Projet_Final
{
    partial class Menu
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
            this.lbl_etudiants = new System.Windows.Forms.Label();
            this.lbl_programme = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ajouterProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_suppressionProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_listerProgramme = new System.Windows.Forms.ToolStripMenuItem();
            this.ètudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ajouterEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_supprimerEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_listerEtudiant = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_etudiants
            // 
            this.lbl_etudiants.AutoSize = true;
            this.lbl_etudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etudiants.Location = new System.Drawing.Point(239, 153);
            this.lbl_etudiants.Name = "lbl_etudiants";
            this.lbl_etudiants.Size = new System.Drawing.Size(317, 25);
            this.lbl_etudiants.TabIndex = 0;
            this.lbl_etudiants.Text = "Il y a 0 étudiants inscrits au collège!";
            // 
            // lbl_programme
            // 
            this.lbl_programme.AutoSize = true;
            this.lbl_programme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_programme.Location = new System.Drawing.Point(209, 243);
            this.lbl_programme.Name = "lbl_programme";
            this.lbl_programme.Size = new System.Drawing.Size(385, 25);
            this.lbl_programme.TabIndex = 1;
            this.lbl_programme.Text = "Il y a 0 programmes disponibles au collège!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmeToolStripMenuItem,
            this.ètudiantToolStripMenuItem,
            this.menu_quitter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmeToolStripMenuItem
            // 
            this.programmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ajouterProgramme,
            this.menu_suppressionProgramme,
            this.menu_listerProgramme});
            this.programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            this.programmeToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.programmeToolStripMenuItem.Text = "Programme";
            // 
            // menu_ajouterProgramme
            // 
            this.menu_ajouterProgramme.Name = "menu_ajouterProgramme";
            this.menu_ajouterProgramme.Size = new System.Drawing.Size(243, 26);
            this.menu_ajouterProgramme.Text = "Ajouter Programme";
            this.menu_ajouterProgramme.Click += new System.EventHandler(this.menu_ajouterProgramme_Click);
            // 
            // menu_suppressionProgramme
            // 
            this.menu_suppressionProgramme.Name = "menu_suppressionProgramme";
            this.menu_suppressionProgramme.Size = new System.Drawing.Size(243, 26);
            this.menu_suppressionProgramme.Text = "Supprimer Programme";
            this.menu_suppressionProgramme.Click += new System.EventHandler(this.menu_suppressionProgramme_Click);
            // 
            // menu_listerProgramme
            // 
            this.menu_listerProgramme.Name = "menu_listerProgramme";
            this.menu_listerProgramme.Size = new System.Drawing.Size(243, 26);
            this.menu_listerProgramme.Text = "Lister Programme";
            this.menu_listerProgramme.Click += new System.EventHandler(this.menu_listerProgramme_Click);
            // 
            // ètudiantToolStripMenuItem
            // 
            this.ètudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ajouterEtudiant,
            this.menu_supprimerEtudiant,
            this.menu_listerEtudiant});
            this.ètudiantToolStripMenuItem.Name = "ètudiantToolStripMenuItem";
            this.ètudiantToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.ètudiantToolStripMenuItem.Text = "Étudiant";
            // 
            // menu_ajouterEtudiant
            // 
            this.menu_ajouterEtudiant.Name = "menu_ajouterEtudiant";
            this.menu_ajouterEtudiant.Size = new System.Drawing.Size(220, 26);
            this.menu_ajouterEtudiant.Text = "Ajouter étudiant";
            this.menu_ajouterEtudiant.Click += new System.EventHandler(this.ajouterÈtudiantToolStripMenuItem_Click);
            // 
            // menu_supprimerEtudiant
            // 
            this.menu_supprimerEtudiant.Name = "menu_supprimerEtudiant";
            this.menu_supprimerEtudiant.Size = new System.Drawing.Size(220, 26);
            this.menu_supprimerEtudiant.Text = "Supprimer étudiant";
            this.menu_supprimerEtudiant.Click += new System.EventHandler(this.menu_supprimerEtudiant_Click);
            // 
            // menu_listerEtudiant
            // 
            this.menu_listerEtudiant.Name = "menu_listerEtudiant";
            this.menu_listerEtudiant.Size = new System.Drawing.Size(220, 26);
            this.menu_listerEtudiant.Text = "Lister les étudiants";
            this.menu_listerEtudiant.Click += new System.EventHandler(this.menu_listerEtudiant_Click);
            // 
            // menu_quitter
            // 
            this.menu_quitter.Name = "menu_quitter";
            this.menu_quitter.Size = new System.Drawing.Size(69, 24);
            this.menu_quitter.Text = "Quitter";
            this.menu_quitter.Click += new System.EventHandler(this.menu_quitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_programme);
            this.Controls.Add(this.lbl_etudiants);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription Collège";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_etudiants;
        private System.Windows.Forms.Label lbl_programme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_ajouterProgramme;
        private System.Windows.Forms.ToolStripMenuItem menu_suppressionProgramme;
        private System.Windows.Forms.ToolStripMenuItem menu_listerProgramme;
        private System.Windows.Forms.ToolStripMenuItem ètudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_quitter;
        private System.Windows.Forms.ToolStripMenuItem menu_ajouterEtudiant;
        private System.Windows.Forms.ToolStripMenuItem menu_supprimerEtudiant;
        private System.Windows.Forms.ToolStripMenuItem menu_listerEtudiant;
    }
}