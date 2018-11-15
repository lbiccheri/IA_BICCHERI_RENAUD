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

namespace Partie1
{
    public partial class formQuestion : Form
    {
        int compt = 0;
        int repJuste = 0;
        public formQuestion()
        {
            InitializeComponent();
            // numéro de la question
            //Random rand = new Random();
            //int numeroQuestion = rand.Next(10);
            int numeroQuestion = 0;
            // Lecture du fichier XML
            XmlDocument questionnaire = new XmlDocument();
            questionnaire.Load("../../Data.xml");

            // Selectionne la question
            XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

            this.AffichageQuestion(numeroQuestion, question);         
            
            lbNbQuestion.Text = compt + "/20";                        
        }               
        private void btQuestionSuivante_Click(object sender, EventArgs e)
        {
            int numeroQuestion = 1;
            // numéro de la question
            //Random rand = new Random();
            //int numeroQuestion = rand.Next(20);
            if (compt < 20)
            {
                compt++;
                lbNbQuestion.Text = compt + "/20";                
                // Lecture du fichier XML
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // Selectionne la question
                XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

                this.ResultatJuste(numeroQuestion, question);
                
                //Initialise les RB                
                foreach (RadioButton rb in gbReponse.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                this.AffichageQuestion(numeroQuestion, question);                                               
            }
            else
            {                                
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // Selectionne la question
                XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];
                this.ResultatJuste(numeroQuestion, question);
                
                lbNbQuestion.Text = "20/20";
                MessageBox.Show("Bravo vous venez de faire " + repJuste + " réponses justes! ");
                this.Close();                               
            }             
            
        }
        private void ResultatJuste(int numQuestion, XmlNode question)
        {            
            //// Donne la réponse de la question
            XmlNode reponseBonne = question.SelectSingleNode("reponseBonne");
            string rep = reponseBonne.InnerText;

            foreach (RadioButton RB in gbReponse.Controls.OfType<RadioButton>())
            {
                if (RB.Checked == true && RB.Text == rep)
                    repJuste++;
            }
        }
        private void AffichageQuestion (int numQuestion, XmlNode question)
        {
            // Donne le titre de la question
            XmlNode titreQuestion = question.SelectSingleNode("titre");
            lbQuestion.Text = titreQuestion.InnerText;

            //// Donne les propositions à la question

            XmlNode titreReponse = question.SelectSingleNode("A");
            rbRep1.Text = titreReponse.InnerText;

            XmlNode titreReponse2 = question.SelectSingleNode("B");
            rbRep2.Text = titreReponse2.InnerText;

            XmlNode titreReponse3 = question.SelectSingleNode("C");
            rbRep3.Text = titreReponse3.InnerText;
        }
    }
}
