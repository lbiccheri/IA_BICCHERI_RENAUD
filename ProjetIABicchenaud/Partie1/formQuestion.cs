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
            
            lbNbQuestion.Text = compt + "/20";                        
        }               
        private void btQuestionSuivante_Click(object sender, EventArgs e)
        {
            compt++;
            lbNbQuestion.Text = compt + "/20";
            
            if (compt < 21)
            {                               
                             
                // numéro de la question
                //Random rand = new Random();
                //int numeroQuestion = rand.Next(20);
                int numeroQuestion = 1;
                // Lecture du fichier XML
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // Selectionne la question
                XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

                //// Donne la réponse de la question
                XmlNode reponseBonne = question.SelectSingleNode("reponseBonne");
                string rep = reponseBonne.InnerText;

                foreach (RadioButton RB in gbReponse.Controls.OfType<RadioButton>())
                {
                    if (RB.Checked == true && RB.Text == rep)
                        repJuste++;
                }
                //Initialise les RB                
                foreach (RadioButton rb in gbReponse.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
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
            else
            {
                lbNbQuestion.Text = "20/20";
                MessageBox.Show("Bravo vous venez de faire " + repJuste + " réponses justes! ");
                this.Close();
                
            } 
            
        }
    }
}
