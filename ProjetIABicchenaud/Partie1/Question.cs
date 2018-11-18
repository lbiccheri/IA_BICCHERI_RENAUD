using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Partie1
{
    public class Question
    {        
        public string titre { get; set; }

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string reponseBonne { get; set; }
        
        public Question (string titre, string reponse1, string reponse2, string reponse3, string reponseBonne)
        {            
            this.titre = titre;
            this.A = reponse1;
            this.B = reponse2;
            this.C = reponse3;
            this.reponseBonne = reponseBonne;
        }
        public void AjouterQuestion ()
        {
            List <Question> questions = new List<Question>();
            //Ajoute la question que l'on souhaite avec les bonnes données dans notre fichier xml
            questions.Add(this); 

            StreamWriter writer = new StreamWriter("../../Data.xml");
            new XmlSerializer(typeof(List<Question>)).Serialize(writer, questions);
            writer.Close();
        }
    }
}
