using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace Partie1
{
    public partial class formQuestion : Form
    {
        int compt = 1;
        int repJuste = 0;
        int numeroQuestion;
        int count;
        public formQuestion()
        {
            InitializeComponent();
            
            lbVerification.Text = "";
            pictureBoxTitre.SendToBack();

            // numéro de la question
            Random rand = new Random();
            numeroQuestion = rand.Next(4);

            // Lecture du fichier XML
            XmlDocument questionnaire = new XmlDocument();
            questionnaire.Load("../../Data.xml");            

            this.AffichageQuestion(numeroQuestion, questionnaire);         
            
            lbNbQuestion.Text = compt + "/20";                        
        }               
        private void btQuestionSuivante_Click(object sender, EventArgs e)
        {
            this.Text = "Question suivante";
            lbVerification.Text = "";

            if (compt < 20)
            {
                compt++;
                lbNbQuestion.Text = compt + "/20";
                pictureBoxTitre.SendToBack();

                // Lecture du fichier XML
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // numéro de la question, foreach permet de compter le nombre de noeux Question pour éviter de compiler lorsque l'on rajoute une question
                Random rand = new Random();
                pictureBoxTitre.Image = null;
                pictureBoxTitre.SendToBack();
                foreach (XmlNode node in questionnaire.SelectNodes("//ArrayOfQuestion"))
                {
                    count = node.SelectNodes(".//Question").Count;
                }
                numeroQuestion = rand.Next(count);

                this.AffichageQuestion(numeroQuestion, questionnaire);

                //Initialise les RB                
                foreach (RadioButton rb in gbReponse.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                                                              
            }
            else
            {                                
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // Selectionne la question
                XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];
                this.ResultatJuste(question);
                
                lbNbQuestion.Text = "20/20";
                MessageBox.Show("Bravo vous venez de faire " + repJuste + " réponses justes! ");
                this.Close();                               
            }                       

            //Fais réapparaître la vérification des questions
            btVerification.BringToFront();

        }
        private void ResultatJuste(XmlNode question)
        {            
            //// Donne la réponse de la question
            XmlNode reponseBonne = question.SelectSingleNode("reponseBonne");
            string rep = reponseBonne.InnerText;

            foreach (RadioButton RB in gbReponse.Controls.OfType<RadioButton>())
            {
                if (RB.Checked == true && RB.Text == rep)
                    repJuste++;
            }

            lbVerification.Text = "La bonne réponse est : " + rep;
        }
        private void AffichageQuestion (int numQuestion, XmlDocument questionnaire)
        {
            // Selectionne la question
            XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

            // Donne le titre de la question
            XmlNode titreQuestion = question.SelectSingleNode("titre");
            lbQuestion.Text = titreQuestion.InnerText;

            //Affiche l'image de la question
            XmlNode imageQ = question.SelectSingleNode("image");
            if (imageQ.InnerText !="")
            {
                Image image = Image.FromFile(imageQ.InnerText);
                pictureBoxTitre.Image = image;
                pictureBoxTitre.BringToFront();
            }

            //// Donne les propositions à la question

            XmlNode titreReponse = question.SelectSingleNode("A");
            rbRep1.Text = titreReponse.InnerText;

            XmlNode titreReponse2 = question.SelectSingleNode("B");
            rbRep2.Text = titreReponse2.InnerText;

            XmlNode titreReponse3 = question.SelectSingleNode("C");
            rbRep3.Text = titreReponse3.InnerText;
        }

        private void btVerification_Click(object sender, EventArgs e)
        {            
            // Lecture du fichier XML
            XmlDocument questionnaire = new XmlDocument();
            questionnaire.Load("../../Data.xml");

            // Selectionne la question
            XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

            this.ResultatJuste(question);

            btVerification.SendToBack();
        }        
    }
}
