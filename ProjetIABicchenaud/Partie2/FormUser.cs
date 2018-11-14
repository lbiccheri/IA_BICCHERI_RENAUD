using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie2
{
    public partial class FormUser : Form
    {
        static public double[,] matrice;
        static public int nbnodes;
        static public int numinitial;
        static public int numfinal;
        static public SearchTree arbreSol;
        static public List<GenericNode> solution;
        static private bool ajoutEtapePossible = false;

        public FormUser()
        {
            InitializeComponent();
        }

        private void BInit1_Click(object sender, EventArgs e)
        {
            TBNoeuInit.Text = "0";
            TBNoeuFin.Text = "6";
            numinitial = int.Parse(TBNoeuInit.Text);
            numfinal = int.Parse(TBNoeuFin.Text);
            nbnodes = 7;
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3; matrice[1, 0] = 3;
            matrice[0, 2] = 5; matrice[2, 0] = 5;
            matrice[0, 3] = 7; matrice[3, 0] = 7;
            matrice[1, 4] = 8; matrice[4, 1] = 8;
            matrice[2, 4] = 3; matrice[4, 2] = 3;
            matrice[4, 5] = 7; matrice[5, 4] = 7;
            matrice[5, 6] = 4; matrice[6, 5] = 4;

            for (int i = 0; i < nbnodes; i++)
            {
                for (int j = 0; j < nbnodes; j++)
                {
                    if (matrice[i, j] != -1 && i < j)
                    {
                        LBArcs.Items.Add(Convert.ToString(i)
                            + "--->" + Convert.ToString(j)
                            + "   : " + Convert.ToString(matrice[i, j]));
                    }
                }
            }
            arbreSol = new SearchTree();
            Node N0 = new Node(int.Parse(TBNoeuInit.Text));

            solution = arbreSol.RechercheSolutionAEtoile(N0);
            if (solution == null)
                LBSol.Items.Add("Solution vide");
            else
                foreach (Node N in solution)
                    LBSol.Items.Add(N.numero.ToString());
            DGVOuvFerm.Rows.Add();
        }

        private void BAjoutEtape_Click(object sender, EventArgs e)
        {
            List<GenericNode> LOuvUser = new List<GenericNode>();
            List<GenericNode> LFerUser = new List<GenericNode>();
            int etape = DGVOuvFerm.Rows.Count - 1;
            object dataCellFermes = DGVOuvFerm.Rows[etape].Cells[0].Value;
            object dataCellOuverts = DGVOuvFerm.Rows[etape].Cells[1].Value;
            string strLFerUser = (dataCellFermes == null ? "" : dataCellFermes.ToString());
            string strLOuvUser = (dataCellOuverts == null ? "" : dataCellOuverts.ToString());

            LFerUser = LNoeudsStrToList(strLFerUser);
            LOuvUser = LNoeudsStrToList(strLOuvUser);

            List<GenericNode> VraieLFer = arbreSol.EtapesFermes[etape];
            List<GenericNode> VraieLOuv = arbreSol.EtapesOuverts[etape];
            

            ajoutEtapePossible = (VerifListIdentique(LFerUser, VraieLFer) && VerifListIdentique(LOuvUser, VraieLOuv));

            if (ajoutEtapePossible) { label1.Text = "BONNE REPONSE !"; }
            else { label1.Text = "ERREUR !"; }
            DGVOuvFerm.Rows.Add();
        }

        private List<GenericNode> LNoeudsStrToList(string strList)
        {
            List<GenericNode> listeNoeuds = new List<GenericNode>();
            if (strList == "") { return listeNoeuds; }
            int i = 0;
            while (i < strList.Length)
            {
                string strNumNode = "";
                while (i < strList.Length && strList[i] != ',')
                {
                    strNumNode += strList[i];
                    i++;
                }
                int numNode = int.Parse(strNumNode);
                Node N = new Node(numNode);
                listeNoeuds.Add(N);
                i++; //on passe la virgule
            }
            return listeNoeuds;
        }

        private bool VerifListIdentique(List<GenericNode> listToCompare, List<GenericNode> vraieList)
        {
            bool identique = true;
            int nbNoeud = vraieList.Count;
            if (listToCompare.Count != nbNoeud)
                identique = false;
            else
            {
                for (int i = 0; i < nbNoeud; i++)
                {
                    Node NTest = (Node)listToCompare[i];
                    Node NVrai = (Node)vraieList[i];
                    if (NTest.numero != NVrai.numero)
                        identique = false;
                }
            }
            return identique;
        }
    }
}
