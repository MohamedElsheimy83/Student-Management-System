namespace CS_Projet_Final
{
    partial class Lister_tous_etudiants
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
            this.btn_retour = new System.Windows.Forms.Button();
            this.grd_listeEtudiants = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grd_listeEtudiants)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_retour
            // 
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(558, 419);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(171, 39);
            this.btn_retour.TabIndex = 5;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // grd_listeEtudiants
            // 
            this.grd_listeEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_listeEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Nom,
            this.Column3,
            this.Column4,
            this.Courriel,
            this.codeProgramme});
            this.grd_listeEtudiants.Location = new System.Drawing.Point(30, 80);
            this.grd_listeEtudiants.Name = "grd_listeEtudiants";
            this.grd_listeEtudiants.ReadOnly = true;
            this.grd_listeEtudiants.RowTemplate.Height = 24;
            this.grd_listeEtudiants.Size = new System.Drawing.Size(1157, 316);
            this.grd_listeEtudiants.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste de tous les étudiants";
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 145;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date de naissance";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 170;
            // 
            // Courriel
            // 
            this.Courriel.HeaderText = "Courriel";
            this.Courriel.Name = "Courriel";
            this.Courriel.ReadOnly = true;
            this.Courriel.Width = 170;
            // 
            // codeProgramme
            // 
            this.codeProgramme.HeaderText = "Code du programme inscrit";
            this.codeProgramme.Name = "codeProgramme";
            this.codeProgramme.ReadOnly = true;
            // 
            // Lister_tous_etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 483);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.grd_listeEtudiants);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Lister_tous_etudiants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription Collège - Lister étudiants";
            this.Load += new System.EventHandler(this.Lister_tous_etudiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_listeEtudiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.DataGridView grd_listeEtudiants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Courriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeProgramme;
    }
}