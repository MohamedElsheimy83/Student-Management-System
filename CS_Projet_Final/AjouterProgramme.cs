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
    public partial class AjouterProgramme : Form
    {
        public AjouterProgramme()
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

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //declarer les variables
            string code, domaine, nomProgramme;
            double nbrHeures;
            bool verification_double = false;
            bool program_exist = false;
            
            //condition pour vérifier si un des champs est vide
            bool condition_vide = txt_code.Text == "" || txt_domaine.Text == "" || txt_nomProgramme.Text == "" || txt_nombreHeures.Text == "";

            //condition pour vérifier si tous les champs sont remplis
            bool condition_complete = txt_code.Text != "" && txt_domaine.Text != "" && txt_nomProgramme.Text != "" && txt_nombreHeures.Text != "";

            code = txt_code.Text;
            domaine = txt_domaine.Text;
            nomProgramme = txt_nomProgramme.Text;

            if (condition_vide)
            {
                MessageBox.Show("Veuillez compléter tous les champs s'il vous plaît!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if

            verification_double = double.TryParse(txt_nombreHeures.Text, out nbrHeures);

            if (!verification_double && condition_complete)
            {
                MessageBox.Show("Entrée invalide! le nombre d'heures est incorrect!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombreHeures.Focus();
            }//end if

            //verifier si le nombre d'heures n'est pas égal à zéro
            if (nbrHeures == 0 && verification_double && condition_complete)
            {
                MessageBox.Show("Entrée invalide! le nombre d'heures ne peut pas être zéro!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nombreHeures.Focus();
                condition_complete = false;
            }//end if

            //verifier si le code de programme existe dans la liste de programmes
            for (int i = 0; i < GlobalVariables.Programmes.Count; i++)
            {
                if (code.ToUpper().Equals(GlobalVariables.Programmes[i].Code.ToUpper())&& condition_complete)
                {
                    MessageBox.Show("Le code du programme existe déjà!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_code.Focus();
                    program_exist = true;
                }//end if
            }//end for

            //ajouter le programme dans la liste de programmes et vider tous les champs
            if (verification_double && condition_complete && !program_exist)
            {
                Programme programme = new Programme(code, domaine, nomProgramme, nbrHeures);
            
                GlobalVariables.Programmes.Add(programme);
                MessageBox.Show("Le programme a été ajouté à la liste des programmes.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_code.Text = "";
                txt_domaine.Text = "";
                txt_nomProgramme.Text = "";
                txt_nombreHeures.Text = "";
                txt_code.Focus();

                GlobalVariables.nbrProgrammes++;

            }//end if
           
        }

        private void AjouterProgramme_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_code;
        }
    }
}
