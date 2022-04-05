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
    public partial class Lister_etudiants : Form
    {
        public Lister_etudiants()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_codeEtudiant.Text = GlobalVariables.Etudiants[0].Code;
            txt_nomEtudiant.Text = GlobalVariables.Etudiants[0].Nom;
            txt_prenomEtudiant.Text = GlobalVariables.Etudiants[0].Prenom;
            txt_dateNaissance.Text = GlobalVariables.Etudiants[0].Date_naissance;
            txt_courriel.Text = GlobalVariables.Etudiants[0].Courriel;
            txt_codeEtudiant.Text = GlobalVariables.Etudiants[0].Code;
            txt_codeProgramme.Text = GlobalVariables.Etudiants[0].CodePrograme;

        }

        private void btn_premier_Click(object sender, EventArgs e)
        {
            //obtenir les données du premier étudiant
            txt_codeEtudiant.Text = GlobalVariables.Etudiants[0].Code;
            txt_nomEtudiant.Text = GlobalVariables.Etudiants[0].Nom;
            txt_prenomEtudiant.Text = GlobalVariables.Etudiants[0].Prenom;
            txt_dateNaissance.Text = GlobalVariables.Etudiants[0].Date_naissance;
            txt_courriel.Text = GlobalVariables.Etudiants[0].Courriel;
            txt_codeEtudiant.Text = GlobalVariables.Etudiants[0].Code;
            txt_codeProgramme.Text = GlobalVariables.Etudiants[0].CodePrograme;
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            //obtenir les données d'étudiant précédent
            if (txt_codeEtudiant.Text!="" && txt_codeEtudiant.Text != GlobalVariables.Etudiants[0].Code)
                for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
                {
                    if (txt_codeEtudiant.Text.Equals(GlobalVariables.Etudiants[i].Code))
                        {
                        txt_codeEtudiant.Text = GlobalVariables.Etudiants[i-1].Code;
                        txt_nomEtudiant.Text = GlobalVariables.Etudiants[i - 1].Nom;
                        txt_prenomEtudiant.Text = GlobalVariables.Etudiants[i - 1].Prenom;
                        txt_dateNaissance.Text = GlobalVariables.Etudiants[i - 1].Date_naissance;
                        txt_courriel.Text = GlobalVariables.Etudiants[i - 1].Courriel;
                        txt_codeEtudiant.Text = GlobalVariables.Etudiants[i - 1].Code;
                        txt_codeProgramme.Text = GlobalVariables.Etudiants[i - 1].CodePrograme;
      
                        break;
                    }//end if

                }//end for
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            //obtenir les données d'étudiant suivant
            if (txt_codeEtudiant.Text != "" && txt_codeEtudiant.Text != GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count-1].Code)
                for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
                {
                    if (txt_codeEtudiant.Text.Equals(GlobalVariables.Etudiants[i].Code))
                    {
                        txt_codeEtudiant.Text = GlobalVariables.Etudiants[i + 1].Code;
                        txt_nomEtudiant.Text = GlobalVariables.Etudiants[i + 1].Nom;
                        txt_prenomEtudiant.Text = GlobalVariables.Etudiants[i + 1].Prenom;
                        txt_dateNaissance.Text = GlobalVariables.Etudiants[i + 1].Date_naissance;
                        txt_courriel.Text = GlobalVariables.Etudiants[i + 1].Courriel;
                        txt_codeEtudiant.Text = GlobalVariables.Etudiants[i + 1].Code;
                        txt_codeProgramme.Text = GlobalVariables.Etudiants[i + 1].CodePrograme;

                        break;
                    }//end if

                }//end for
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            //obtenir les données de la dernier étudiant 
            txt_codeEtudiant.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Code;
                        txt_nomEtudiant.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Nom;
                        txt_prenomEtudiant.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Prenom;
                        txt_dateNaissance.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Date_naissance;
                        txt_courriel.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Courriel;
                        txt_codeEtudiant.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].Code;
                        txt_codeProgramme.Text = GlobalVariables.Etudiants[GlobalVariables.Etudiants.Count - 1].CodePrograme;

        }

        private void Lister_etudiants_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_codeEtudiant;
        }

        private void btn_listerEtudiants_Click(object sender, EventArgs e)
        {
            Lister_tous_etudiants lister_Tous_Etudiants = new Lister_tous_etudiants();
            lister_Tous_Etudiants.Show();
            this.Hide();
        }
    }
}
