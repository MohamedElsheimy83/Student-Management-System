using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Projet_Final
{
    class Programme
    {
        //définir les champs de la classe
        private string code;
        private string domaine;
        private string nomProgramme;
        private double nbrHeures;

        //définir les setters et getters
        public string Code { get => code; set => code = value; }
        public string Domaine { get => domaine; set => domaine = value; }
        public string NomProgramme { get => nomProgramme; set => nomProgramme = value; }
        public double NbrHeures { get => nbrHeures; set => nbrHeures = value; }
        
        //définir le constructeur par defaut
        public Programme() { }

        //définir le constructeur avec tous les champs de la classe
        public Programme(string p_code, string p_domaine, string p_nomProgramme, double p_nbrHeures){
            this.code = p_code;
            this.domaine = p_domaine;
            this.nomProgramme = p_nomProgramme;
            this.nbrHeures = p_nbrHeures;
}
    }
}
