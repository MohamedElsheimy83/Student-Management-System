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
    public partial class Ajouter_etudiant : Form
    {
        public Ajouter_etudiant()
        {
            InitializeComponent();
        }

        private void Ajouter_etudiant_Load(object sender, EventArgs e)
        {

            //remplir le combo Box
            if (GlobalVariables.nbrProgrammes > 0)
                for (int i = 0; i < GlobalVariables.Programmes.Count; i++)
                {
                    comboBox_code.Items.Add(GlobalVariables.Programmes[i].Code);
                }
            this.ActiveControl = txt_nomEtudiant;
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //vider tous les champs
            txt_nomEtudiant.Text = "";
            txt_prenomEtudiant.Text = "";
            dtp_dateNaissance.ResetText();
            txt_courriel.Text = "";
            comboBox_code.ResetText();
            txt_nomEtudiant.Focus();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //declarer les variables
            string code, nom, prenom, date_naissance, courriel, code_programme;
            bool verification_dateNaissance=true;
            bool verification_etudiantExiste = true;

            //condition pour vérifier si un des champs est vide
            bool condition_vide = txt_nomEtudiant.Text == "" || txt_prenomEtudiant.Text == "" || txt_courriel.Text == "" || comboBox_code.Text == "";

            //condition pour vérifier si tous les champs sont remplis
            bool condition_complete = txt_nomEtudiant.Text != "" && txt_prenomEtudiant.Text != "" && txt_courriel.Text != "" && comboBox_code.Text != "";

            nom = txt_nomEtudiant.Text;
            prenom = txt_prenomEtudiant.Text;
            date_naissance = dtp_dateNaissance.Text;
            courriel = txt_courriel.Text;
            code_programme = comboBox_code.Text;

            if (condition_vide)
            {
                MessageBox.Show("Veuillez compléter tous les champs s'il vous plaît", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//end if


            //vérifier si la date du naissance est inférieure à 18 ou supérieur à 100
            if ( (((DateTime.Now.Year-dtp_dateNaissance.Value.Year) <18) || ((DateTime.Now.Year - dtp_dateNaissance.Value.Year) > 100)) && condition_complete)
            {
                MessageBox.Show("Les personnes de moins de 18 ans ou de plus de 100 ans ne sont pas admissibles à ce cours!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                verification_dateNaissance = false;
                dtp_dateNaissance.Focus();
            }//end if

            //vérifier si la longueur du nom est inférieure à 3 caractères
            if (nom.Length<3 && prenom.Length < 3 && condition_complete)
            {
                MessageBox.Show("Les noms et prénoms sont courts (3 lettres minimum)!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nomEtudiant.Focus();
            }//end if

            //vérifier si la longueur du prénom est inférieure à 3 caractères
            if (nom.Length < 3 && prenom.Length >= 3 && condition_complete)
            {
                MessageBox.Show("Le nom est court (3 lettres minimum)!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_prenomEtudiant.Focus();
            }//end if

            //vérifier si la longueur du nom et prénom est inférieure à 3 caractères
            if (prenom.Length < 3 && nom.Length >= 3 && condition_complete)
            {
                MessageBox.Show("Le prenom est court (3 lettres minimum)!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nomEtudiant.Focus();
            }//end if

            
            if (nom.Length >= 3 && prenom.Length >= 3 && condition_complete)
            {
                //générér automatiquement le code étudiant
                code = prenom.Substring(0, 1) + nom.Substring(0, 2) + dtp_dateNaissance.Value.Year;

                for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
                {
                    //vérifier si l'étudiant est déjà inscrit dans un programme
                    if (GlobalVariables.Etudiants[i].Code.ToUpper().Equals(code.ToUpper()))
                    {
                        MessageBox.Show("L'étudiant est déjà inscrit dans un programme!", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        verification_etudiantExiste = false;
                    }//end if
                }//end for

                //ajouter l'étudiant dans la liste d'étudiants et vider tous les champs
                if (verification_etudiantExiste && verification_dateNaissance)
                {
                    Etudiant etudiant = new Etudiant(code, nom, prenom, date_naissance, courriel, code_programme);

                    GlobalVariables.Etudiants.Add(etudiant);
                    MessageBox.Show("L'étudiant a été ajouté à la liste des étudiants!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_codeEtudiant.Text = "";
                    txt_nomEtudiant.Text = "";
                    txt_prenomEtudiant.Text = "";
                    txt_courriel.Text = "";
                    comboBox_code.SelectedIndex = -1;
                    dtp_dateNaissance.ResetText();
                    txt_nomEtudiant.Focus();
                    GlobalVariables.nbrEtudiants++;
                }//end if

            }//end if
        }

        private void comboBox_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            
     
        }

        private void txt_codeEtudiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
