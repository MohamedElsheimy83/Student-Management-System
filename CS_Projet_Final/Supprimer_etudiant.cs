using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Projet_Final
{
    public partial class Supprimer_etudiant : Form
    {
        public Supprimer_etudiant()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void brn_annuler_Click(object sender, EventArgs e)
        {
            //vider tous les champs
            txt_codeEtudiant.Text = "";
            txt_nomEtudiant.Text = "";
            txt_prenomEtudiant.Text = "";
            txt_dateNaissance.Text = "";
            txt_courriel.Text = "";
            txt_codeProgramme.Text = "";
            txt_codeProgramme.Focus();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            //declarer les variables
            bool validation = false;

            //vérifier si le champ code étudiant n'est pas vide
            if (txt_codeEtudiant.Text == "")
                MessageBox.Show("Veuillez entrer un code svp", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
            {
                if (txt_codeEtudiant.Text.ToUpper().Equals(GlobalVariables.Etudiants[i].Code.ToUpper()))
                {
                    //obtenir les informations d'étudiant
                    validation = true;
                    txt_codeEtudiant.Text = GlobalVariables.Etudiants[i].Code;
                    txt_nomEtudiant.Text = GlobalVariables.Etudiants[i].Nom;
                    txt_prenomEtudiant.Text = GlobalVariables.Etudiants[i].Prenom;
                    txt_dateNaissance.Text = GlobalVariables.Etudiants[i].Date_naissance;
                    txt_courriel.Text = GlobalVariables.Etudiants[i].Courriel;
                    txt_codeProgramme.Text = GlobalVariables.Etudiants[i].CodePrograme;
                    txt_codeEtudiant.Focus();
                    break;
                }//end if
            }//end for

            //si le code d'étudiant n'existe pas
            if (!validation && txt_codeEtudiant.Text != "")
            MessageBox.Show("Code d'étudiant n'existe pas dans la liste d'étudiants!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //declarer les variables
            bool validation = false;

            //vérifier si le champ code étudiant n'est pas vide
            if (txt_codeEtudiant.Text == "")
                MessageBox.Show("Veuillez entrer un code svp!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
            {
                if (txt_codeEtudiant.Text.ToUpper().Equals(GlobalVariables.Etudiants[i].Code.ToUpper()))
                {
                    //supprimer l'étudiant
                    GlobalVariables.Etudiants.RemoveAt(i);
                    MessageBox.Show("L'étudiant a été supprimé avec succès.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    validation = true;
                    txt_codeEtudiant.Text = "";
                    txt_nomEtudiant.Text = "";
                    txt_prenomEtudiant.Text = "";
                    txt_dateNaissance.Text = "";
                    txt_courriel.Text = "";
                    txt_codeProgramme.Text = "";
                    txt_codeEtudiant.Focus();

                    GlobalVariables.nbrEtudiants--;
                    break;
                }//end if
            }//end for

            //si le code n'est pas valide
            if (!validation && txt_codeEtudiant.Text != "")
                MessageBox.Show("Code d'étudiant n'existe pas dans la liste d'étudiants!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Supprimer_etudiant_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_codeEtudiant;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //vider tous les champs
            txt_codeEtudiant.Text = "";
            txt_nomEtudiant.Text = "";
            txt_prenomEtudiant.Text = "";
            txt_dateNaissance.Text = "";
            txt_courriel.Text = "";
            txt_codeProgramme.Text = "";
            txt_codeProgramme.Focus();
        }
    }
}
