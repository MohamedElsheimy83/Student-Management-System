namespace CS_Projet_Final
{
    partial class Ajouter_etudiant
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codeEtudiant = new System.Windows.Forms.TextBox();
            this.txt_nomEtudiant = new System.Windows.Forms.TextBox();
            this.txt_prenomEtudiant = new System.Windows.Forms.TextBox();
            this.dtp_dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txt_courriel = new System.Windows.Forms.TextBox();
            this.comboBox_code = new System.Windows.Forms.ComboBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS_Projet_Final.Properties.Resources.ajouterEtudiant;
            this.pictureBox1.Location = new System.Drawing.Point(650, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'un étudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code de l\'étudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom de l\'étudiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom de l\'étudiant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Courriel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Code du programme iscrit";
            // 
            // txt_codeEtudiant
            // 
            this.txt_codeEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codeEtudiant.Location = new System.Drawing.Point(325, 105);
            this.txt_codeEtudiant.Multiline = true;
            this.txt_codeEtudiant.Name = "txt_codeEtudiant";
            this.txt_codeEtudiant.ReadOnly = true;
            this.txt_codeEtudiant.Size = new System.Drawing.Size(172, 30);
            this.txt_codeEtudiant.TabIndex = 8;
            this.txt_codeEtudiant.TextChanged += new System.EventHandler(this.txt_codeEtudiant_TextChanged);
            // 
            // txt_nomEtudiant
            // 
            this.txt_nomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomEtudiant.Location = new System.Drawing.Point(325, 145);
            this.txt_nomEtudiant.Multiline = true;
            this.txt_nomEtudiant.Name = "txt_nomEtudiant";
            this.txt_nomEtudiant.Size = new System.Drawing.Size(279, 30);
            this.txt_nomEtudiant.TabIndex = 9;
            // 
            // txt_prenomEtudiant
            // 
            this.txt_prenomEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenomEtudiant.Location = new System.Drawing.Point(325, 185);
            this.txt_prenomEtudiant.Multiline = true;
            this.txt_prenomEtudiant.Name = "txt_prenomEtudiant";
            this.txt_prenomEtudiant.Size = new System.Drawing.Size(279, 30);
            this.txt_prenomEtudiant.TabIndex = 10;
            // 
            // dtp_dateNaissance
            // 
            this.dtp_dateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateNaissance.Location = new System.Drawing.Point(325, 225);
            this.dtp_dateNaissance.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtp_dateNaissance.Name = "dtp_dateNaissance";
            this.dtp_dateNaissance.Size = new System.Drawing.Size(335, 27);
            this.dtp_dateNaissance.TabIndex = 11;
            // 
            // txt_courriel
            // 
            this.txt_courriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_courriel.Location = new System.Drawing.Point(325, 265);
            this.txt_courriel.Multiline = true;
            this.txt_courriel.Name = "txt_courriel";
            this.txt_courriel.Size = new System.Drawing.Size(330, 30);
            this.txt_courriel.TabIndex = 12;
            // 
            // comboBox_code
            // 
            this.comboBox_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_code.FormattingEnabled = true;
            this.comboBox_code.IntegralHeight = false;
            this.comboBox_code.ItemHeight = 20;
            this.comboBox_code.Location = new System.Drawing.Point(325, 305);
            this.comboBox_code.Name = "comboBox_code";
            this.comboBox_code.Size = new System.Drawing.Size(172, 28);
            this.comboBox_code.TabIndex = 13;
            this.comboBox_code.SelectedIndexChanged += new System.EventHandler(this.comboBox_code_SelectedIndexChanged);
            // 
            // btn_annuler
            // 
            this.btn_annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(209, 372);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(121, 37);
            this.btn_annuler.TabIndex = 14;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.Location = new System.Drawing.Point(336, 372);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(121, 37);
            this.btn_ajouter.TabIndex = 15;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.Location = new System.Drawing.Point(463, 372);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(121, 37);
            this.btn_retour.TabIndex = 16;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // Ajouter_etudiant
            // 
            this.AcceptButton = this.btn_ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_annuler;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.comboBox_code);
            this.Controls.Add(this.txt_courriel);
            this.Controls.Add(this.dtp_dateNaissance);
            this.Controls.Add(this.txt_prenomEtudiant);
            this.Controls.Add(this.txt_nomEtudiant);
            this.Controls.Add(this.txt_codeEtudiant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Ajouter_etudiant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscriptions Collège - Ajouter étudiant";
            this.Load += new System.EventHandler(this.Ajouter_etudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codeEtudiant;
        private System.Windows.Forms.TextBox txt_nomEtudiant;
        private System.Windows.Forms.TextBox txt_prenomEtudiant;
        private System.Windows.Forms.DateTimePicker dtp_dateNaissance;
        private System.Windows.Forms.TextBox txt_courriel;
        private System.Windows.Forms.ComboBox comboBox_code;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retour;
    }
}