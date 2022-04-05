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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menu_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //update nbrEtudiants et nbrProgrammes
            lbl_etudiants.Text = "Il y a "+ GlobalVariables.nbrEtudiants+" étudiants inscrits au collège!";
            lbl_programme.Text = "Il y a " + GlobalVariables.nbrProgrammes + " programmes disponibles au collège!";
        }

        private void menu_ajouterProgramme_Click(object sender, EventArgs e)
        {
            AjouterProgramme ajouterProgramme = new AjouterProgramme();
            ajouterProgramme.Show();
            this.Hide();
        }

        private void menu_listerProgramme_Click(object sender, EventArgs e)
        {
            //vérifier si la liste de programmes est vide
            if (GlobalVariables.nbrProgrammes == 0)
            {
                MessageBox.Show("La liste de Programmes est vide!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            else
            {
                //lister les programmes
                ListerProgrammes listerProgrammes = new ListerProgrammes();
                listerProgrammes.Show();
                this.Hide();
            }//end else
        }

        private void menu_suppressionProgramme_Click(object sender, EventArgs e)
        {
            //vérifier si la liste de programmes est vide
            if (GlobalVariables.nbrProgrammes == 0)
            {
                MessageBox.Show("La liste de Programmes est vide!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            else
            {
                Suppression_programme suppression_Programme = new Suppression_programme();
                suppression_Programme.Show();
                this.Hide();
            }//end else

        }

        private void ajouterÈtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vérifier si la liste de programmes est vide
            if (GlobalVariables.nbrProgrammes == 0)
            {
                MessageBox.Show("La liste de Programmes est vide, il faut qu'il y ait un programme rattaché.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            else
            {
                //ajouter l'étudiant
               Ajouter_etudiant ajouter_Etudiant = new Ajouter_etudiant();
                ajouter_Etudiant.Show();
                this.Hide();
            }//end else
        }

        private void menu_supprimerEtudiant_Click(object sender, EventArgs e)
        {
            //vérifier si la liste d'étudiants est vide
            if (GlobalVariables.nbrEtudiants == 0)
            {
                MessageBox.Show("La liste des étudiants est vide!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            else
            {
                Supprimer_etudiant supprimer_Etudiant = new Supprimer_etudiant();
                supprimer_Etudiant.Show();
                this.Hide();
            }
        }

        private void menu_listerEtudiant_Click(object sender, EventArgs e)
        {
            //vérifier si la liste d'étudiants est vide
            if (GlobalVariables.nbrEtudiants == 0)
            {
                MessageBox.Show("La liste des étudiants est vide!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            else
            {
                Lister_etudiants lister_Etudiants = new Lister_etudiants();
                lister_Etudiants.Show();
                this.Hide();
            }//end else


        }
    }
}
