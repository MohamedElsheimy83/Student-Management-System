using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Projet_Final
{
    public static class GlobalVariables
    {
        //declarer les variables globales pour être accessible partout dans le programme

        public static int nbrEtudiants = 0;
        public static int nbrProgrammes = 0;
        static List<Programme> programmes = new List<Programme>();
        static List<Etudiant> etudiants = new List<Etudiant>();
        
        // setters et getters
        internal static List<Programme> Programmes { get => programmes; set => programmes = value; }
        internal static List<Etudiant> Etudiants { get => etudiants; set => etudiants = value; }
    }
}
