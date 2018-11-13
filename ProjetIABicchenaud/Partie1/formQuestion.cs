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
        int compt = 1;
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

            XmlNode titreReponse = question.SelectSingleNode("reponseAtt");
            cb1Reponse.Text = titreReponse.InnerText;

            XmlNode titreReponse2 = question.SelectSingleNode("reponseAutre1");
            cb2Reponse.Text = titreReponse2.InnerText;

            XmlNode titreReponse3 = question.SelectSingleNode("reponseAutre2");
            cb3Reponse.Text = titreReponse3.InnerText;

            lbNbQuestion.Text = compt + "/20";
        }               
        private void btQuestionSuivante_Click(object sender, EventArgs e)
        {
            compt++;
            lbNbQuestion.Text = compt + "/20";
            if (compt < 21)
            {
                if(cb1Reponse.Checked == true || cb2Reponse.Checked == true || cb3Reponse.Checked == true)
                {
                    cb1Reponse.Checked = false;
                    cb2Reponse.Checked = false;
                    cb3Reponse.Checked = false;
                }

                // numéro de la question
                //Random rand = new Random();
                //int numeroQuestion = rand.Next(20);
                int numeroQuestion = 1;
                // Lecture du fichier XML
                XmlDocument questionnaire = new XmlDocument();
                questionnaire.Load("../../Data.xml");

                // Selectionne la question
                XmlNode question = questionnaire.GetElementsByTagName("Question")[numeroQuestion];

                // Donne le titre de la question
                XmlNode titreQuestion = question.SelectSingleNode("titre");
                lbQuestion.Text = titreQuestion.InnerText;

                //// Donne les propositions à la question

                XmlNode titreReponse = question.SelectSingleNode("reponseAtt");
                cb1Reponse.Text = titreReponse.InnerText;

                XmlNode titreReponse2 = question.SelectSingleNode("reponseAutre1");
                cb2Reponse.Text = titreReponse2.InnerText;

                XmlNode titreReponse3 = question.SelectSingleNode("reponseAutre2");
                cb3Reponse.Text = titreReponse3.InnerText;
                /*
                //// Donne la réponse de la question
                XmlNode reponse = question.SelectSingleNode("reponse");
                Console.WriteLine("\n• " + reponse.InnerText);
                */
                
                
            }
            else
            {
                formFinal ff = new formFinal();
                ff.Show();
                ff.Activate();
                this.Close();
            } 
            
        }
    }
}
