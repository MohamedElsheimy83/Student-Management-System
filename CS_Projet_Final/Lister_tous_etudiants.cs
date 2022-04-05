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
    public partial class Lister_tous_etudiants : Form
    {
        public Lister_tous_etudiants()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Lister_etudiants lister_Etudiants = new Lister_etudiants();
            lister_Etudiants.Show();
            this.Hide();
        }

        private void Lister_tous_etudiants_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalVariables.Etudiants.Count; i++)
            {
                grd_listeEtudiants.Rows.Add(GlobalVariables.Etudiants[i].Code, GlobalVariables.Etudiants[i].Nom, GlobalVariables.Etudiants[i].Prenom, GlobalVariables.Etudiants[i].Date_naissance, GlobalVariables.Etudiants[i].Courriel, GlobalVariables.Etudiants[i].CodePrograme);
            }
        }
    }
}
