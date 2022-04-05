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
    public partial class Suppression_programme : Form
    {
        public Suppression_programme()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //vider tous les champs
            txt_code.Text = "";
            txt_domaine.Text = "";
            txt_nomProgramme.Text = "";
            txt_nombreHeures.Text = "";
            txt_code.Focus();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            //declarer le variables
            string code_programme = txt_code.Text;
            bool validation = false;

            //vérifier si le code n'est pas saisie
            if (txt_code.Text == "")
                MessageBox.Show("Veuillez entrer un code svp!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //rechercher les information du programme
            for (int i = 0; i < GlobalVariables.Programmes.Count; i++)
            {
                if (code_programme.ToUpper().Equals(GlobalVariables.Programmes[i].Code.ToUpper()))
                { 
                    validation = true;
                    txt_code.Text = GlobalVariables.Programmes[i].Code;
                    txt_domaine.Text = GlobalVariables.Programmes[i].Domaine;
                    txt_nomProgramme.Text = GlobalVariables.Programmes[i].NomProgramme;
                    txt_nombreHeures.Text = GlobalVariables.Programmes[i].NbrHeures.ToString();
                    txt_code.Focus();
                }//end if
            }//end for

            //si le code du programme n'existe pas
            if (!validation && txt_code.Text != "")
                MessageBox.Show("Code du programme n'existe pas!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //declarer les variables
            bool validation = false;
            bool verification_prog_etud = false;

            //vérifier si le code n'est pas saisie
            if (txt_code.Text == "")
                MessageBox.Show("Veuillez entrer un code svp!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //vérifier si un étudiant appartenant à ce programme
            for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
            {
                if (txt_code.Text.ToUpper().Equals(GlobalVariables.Etudiants[i].CodePrograme.ToUpper()))
                {
                    MessageBox.Show("Il y a un étudiant(s) appartient à ce cours. La suppression est impossible!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    verification_prog_etud = true;
                    break;
                }//end if
            }//end for

            //effacer le programme et vider tous les champs(si le code du programme existe)
            if (!verification_prog_etud)
            {
                for (int i = 0; i < GlobalVariables.Programmes.Count; i++)
                {
                    if (txt_code.Text.ToUpper().Equals(GlobalVariables.Programmes[i].Code.ToUpper()))
                    {
                        GlobalVariables.Programmes.RemoveAt(i);
                        MessageBox.Show("Le programme a été supprimé avec succès.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        validation = true;
                        txt_code.Text = "";
                        txt_domaine.Text = "";
                        txt_nomProgramme.Text = "";
                        txt_nombreHeures.Text = "";
                        txt_code.Focus();

                        GlobalVariables.nbrProgrammes--;

                    }//end if
                }//end for
                 
                //si le code du programme n'existe pas
                if (!validation && txt_code.Text != "")
                    MessageBox.Show("Code du programme n'existe pas!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if
        }

        private void Suppression_programme_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_code;
        }
    }
}
