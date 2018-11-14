using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1
{
    public class Question
    {        
        public string titre { get; set; }

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string reponseBonne { get; set; }
        
        public Question (string titre, string reponseatt, string reponseautre1, string reponseautre2, string reponseBonne)
        {            
            this.titre = titre;
            this.A = reponseautre1;
            this.B = reponseautre2;
            this.C = reponseatt;
            this.reponseBonne = reponseBonne;
        }
    }
}
