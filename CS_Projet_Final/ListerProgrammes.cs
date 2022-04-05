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
    public partial class ListerProgrammes : Form
    {
        public ListerProgrammes()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ListerProgrammes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalVariables.Programmes.Count; i++)
            {
                grd_listeProgrammes.Rows.Add(GlobalVariables.Programmes[i].Code, GlobalVariables.Programmes[i].Domaine, GlobalVariables.Programmes[i].NomProgramme, GlobalVariables.Programmes[i].NbrHeures);
            }
        }

        private void grd_listeProgrammes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
