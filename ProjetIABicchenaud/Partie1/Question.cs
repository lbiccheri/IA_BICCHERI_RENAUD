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

        public string reponseAtt { get; set; }

        public string reponseAutre1 { get; set; }

        public string reponseAutre2 { get; set; }
        
        public Question (string titre, string reponseatt, string reponseautre1, string reponseautre2)
        {            
            this.titre = titre;
            this.reponseAutre1 = reponseautre1;
            this.reponseAutre2 = reponseautre2;
            this.reponseAtt = reponseatt;        
        }
    }
}
