using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Partie2
{
	public partial class FormUser : Form
	{
		static public double[,] matrice;
		static public int nbnodes;
		static public int numInitial;
		static public int numFinal;
		static public SearchTree arbreSol;
		static public List<GenericNode> solution;
		static private bool ajoutEtapePossible = false;
		static private bool dejaInit = false;

		public FormUser()
		{
			InitializeComponent();
		}

		private void BImportFichier_Click(object sender, EventArgs e)
		{
			if (dejaInit)
				;
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Text files | *.txt";
			string currentDirectory = Directory.GetCurrentDirectory();
			string initialDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\Graphes\"));
			string filePath = "";
			dlg.InitialDirectory = initialDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
				filePath = dlg.FileName;
			else
			{
				//On demande à l'utilisateur s'il veut prendre un graph basique

				filePath = initialDirectory + "graphe1.txt";
			}
			StreamReader monStreamReader = new StreamReader(filePath);

			// 1ère ligne : "nombre de noeuds du graphe
			string ligne = monStreamReader.ReadLine();
			int i = 0;
			while (ligne[i] != ':') i++;
			string strnbnoeuds = "";
			i++; // On dépasse le ":"
			while (ligne[i] == ' ') i++; // on saute les blancs éventuels
			while (i < ligne.Length)
			{
				strnbnoeuds += ligne[i];
				i++;
			}
			nbnodes = int.Parse(strnbnoeuds);


			//On crée la matrice 
			matrice = new double[nbnodes, nbnodes];
			for (i = 0; i < nbnodes; i++)
				for (int j = 0; j < nbnodes; j++)
					matrice[i, j] = -1;

			// Ensuite on a la tructure suivante : 
			//  arc :  n°noeud départ   n°noeud arrivée   valeur
			//  exemple --> 4 : 1  2 5
			ligne = monStreamReader.ReadLine();
			while (ligne != null)
			{
				i = 0;
				while (ligne[i] != ':') i++;
				i++; // on passe le :
				while (ligne[i] == ' ') i++; // on saute les blancs éventuels
				string strN1 = "";
				while (ligne[i] != ' ')
				{
					strN1 += ligne[i];
					i++;
				}
				int N1 = int.Parse(strN1);

				// On saute les blancs éventuels
				while (ligne[i] == ' ') i++;
				string strN2 = "";
				while (ligne[i] != ' ')
				{
					strN2 += ligne[i];
					i++;
				}
				int N2 = int.Parse(strN2);

				// On saute les blancs éventuels
				while (ligne[i] == ' ') i++;
				string strVal = "";
				while ((i < ligne.Length) && (ligne[i] != ' '))
				{
					strVal += ligne[i];
					i++;
				}
				double val = Convert.ToDouble(strVal);

				//On remplit la matrice
				matrice[N1, N2] = val;
				matrice[N2, N1] = val;
				LBArcs.Items.Add(Convert.ToString(N1)
				   + "--->" + Convert.ToString(N2)
				   + "   : " + Convert.ToString(matrice[N1, N2]));

				ligne = monStreamReader.ReadLine();
			}
			// Fermeture du StreamReader (obligatoire) 
			monStreamReader.Close();

			//On construit une nouvelle solution du graph et la selection des noeuds
			arbreSol = new SearchTree();
			for (i=0;i<nbnodes;i++)
			{
				CBNodeInit.Items.Add(i);
				CBNodeFin.Items.Add(i);
			}
		}

		private void BNoeuds_Click(object sender, EventArgs e)
		{
			numInitial = int.Parse(CBNodeInit.SelectedItem.ToString());
			numFinal = int.Parse(CBNodeFin.SelectedItem.ToString());
			Node N0 = new Node(numInitial);

			//On récupère la solution trouvée par l'IA
			solution = arbreSol.RechercheSolutionAEtoile(N0);
			DGVOuvFerm.Rows.Add();
		}

		private void BAjoutEtape_Click(object sender, EventArgs e)
		{


			if (ajoutEtapePossible)
				DGVOuvFerm.Rows.Add();
			else
			{
				label1.Text = "Tu dois d'abord valider !";
			}

			ajoutEtapePossible = false;
		}


		private void BVerif_Click(object sender, EventArgs e)
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
			if (ajoutEtapePossible) { label1.Text = "Tu peux ajouter une etape !"; }
			else { label1.Text = "Tu asune erreur !"; }
		}

		private List<GenericNode> LNoeudsStrToList(string strList)
		{
			List<GenericNode> listeNoeuds = new List<GenericNode>();
			if (strList == "")
				return listeNoeuds;

			string[] listStr = strList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (string strNumNode in listStr)
			{
				Console.WriteLine(strNumNode);
				int numNode = int.Parse(strNumNode);
				Node N = new Node(numNode);
				listeNoeuds.Add(N);
			}
			return listeNoeuds;
		}

		private bool VerifListIdentique(List<GenericNode> listToCompare, List<GenericNode> vraieList)
		{
			int nbNoeud = vraieList.Count;
			if (listToCompare.Count != nbNoeud)
				return false;
			else
			{
				foreach (Node nodeToCompare in listToCompare)
				{
					Console.WriteLine(nodeToCompare.GetType());
					int i = 0;
					while (i < vraieList.Count && !nodeToCompare.IsEqual(vraieList[i]))
					{
						Console.WriteLine("i = " + i);
						Console.WriteLine(nodeToCompare.IsEqual(vraieList[i]));
						i++;
					}
					if (i >= vraieList.Count)
						return false;
				}
			}
			return true;
		}
	}
}
