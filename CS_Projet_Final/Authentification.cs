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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_connextion_Click(object sender, EventArgs e)
        {
            //declarer les variables
            string nom = txt_nom.Text;
            string motPasse = txt_motPasse.Text;
            bool verification = false;

            List<string> noms = new List<string> {"x","mlazar", "ricker","fahmi"};
            List<string> motPasses = new List<string>() {"x", "1234", "R123", "Amine" };

            //vérifier si le nom et mot de passe sont correctes
            for (int i = 0; i < noms.Count; i++)
            {
                if (nom.Equals(noms[i]) && motPasse.Equals(motPasses[i]))
                {
                    MessageBox.Show("Bienvenu " + noms[i], "Connexion réussi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    verification = true;
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }//end if
            }//end for

            if (!verification)
            {
                MessageBox.Show("Connexion échoué", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nom.Text = "";
                txt_motPasse.Text = "";
                txt_nom.Focus();
            }//end if
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_nom;
        }
    }
}
