using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Projet_Final
{
    class Etudiant
    {
        //définir les champs de la classe
        private string code;
        private string nom;
        private string prenom;
        private string date_naissance;
        private string courriel;
        private string codePrograme;

        //définir les setters et getters
        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string CodePrograme { get => codePrograme; set => codePrograme = value; }

        //définir le constructeur
        public Etudiant(string p_code, string p_nom, string p_prenom, string p_dateNaissance, string p_courriel, string p_codeProgramme)
        {
            this.code = p_code;
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.date_naissance = p_dateNaissance;
            this.courriel = p_courriel;
            this.codePrograme = p_codeProgramme;
        }
    }
}
