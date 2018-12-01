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
		static private bool arbreBon = true;

		public FormUser()
		{
			InitializeComponent();
			label1.Text = "";
			label2.Text = "";
		}

		/// <summary>
		/// Méthode appelée par le bouton d'import de fichier : permet d'importer un graphe
		/// </summary>
		private void BImportFichier_Click(object sender, EventArgs e)
		{
			// OpenFileDialog permet de sélectionner un fichier texte localement
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Text files | *.txt";
			// On définit le chamin d'accès par défaut
			string currentDirectory = Directory.GetCurrentDirectory();
			string initialDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\Graphes\"));
			string filePath = "";
			dlg.InitialDirectory = initialDirectory;

			// Si l'utilisateur à choisit un fichier on l'ouvre
			if (dlg.ShowDialog() == DialogResult.OK)
				filePath = dlg.FileName;
			// Sinon on ouvre le fichier par défaut "graphe1.txt"
			else
				filePath = initialDirectory + "graphe1.txt";

			//On lit le fichier
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
			{
				CBNodeInit.Items.Add(i);
				CBNodeFin.Items.Add(i);
				//cbChgNode.Items.Add(i);

				for (int j = 0; j < nbnodes; j++)
					matrice[i, j] = -1;
			}

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



			// Le fichier à été entièrement lu
			// On construit une nouvelle solution du graph
			arbreSol = new SearchTree();

			// On ne peutplus importer de fichier
			BImportFichier.Enabled = false;
		}

		/// <summary>
		/// Méthode de vérification des noeuds
		/// </summary>
		private void BNoeuds_Click(object sender, EventArgs e)
		{
			tvArbre.Nodes.Clear();
			DGVOuvFerm.Rows.Clear();
			numInitial = int.Parse(CBNodeInit.SelectedItem.ToString());
			numFinal = int.Parse(CBNodeFin.SelectedItem.ToString());
			Node N0 = new Node(numInitial);

			//On récupère la solution trouvée par l'IA
			solution = arbreSol.RechercheSolutionAEtoile(N0);
			// On ajoute une ligne au tableau pour commencer la première partie (remplir les ouverts et fermés)
			DGVOuvFerm.Rows.Add();
		}

		/// <summary>
		/// Ajouter une ligne (étape) au tableau des ouverts et fermés
		/// </summary>
		private void BAjoutEtape_Click(object sender, EventArgs e)
		{
			label1.Text = "";
			// Si l'utilisateur a rempli toutes les lignes qu'il fallait, c'est qu'il a réussi
			if (arbreSol.EtapesOuverts.Count == DGVOuvFerm.Rows.Count)
			{
				label1.Text = "Vous avez réussit !";
				// On l'empêche de vérifier et d'ajouter une étape
				BAjoutEtape.Enabled = false;
				BVerifEtape.Enabled = false;

				// On affiche le TreeView mais avec des "?"
				arbreSol.GetSearchTree(tvArbre, true);
			}
			// Sinon (s'il n'a pas fini)
			else
			{
				// On rajoute une ligne
				DGVOuvFerm.Rows.Add();
				BAjoutEtape.Enabled = false;
			}
		}

		/// <summary>
		/// Vérification de l'étape
		/// </summary>
		private void BVerifEtape_Click(object sender, EventArgs e)
		{
			int etape = DGVOuvFerm.Rows.Count - 1;

			// On récupère la liste des noeuds de l'utilisateur
			List<GenericNode> LOuvUser = new List<GenericNode>();
			List<GenericNode> LFerUser = new List<GenericNode>();
			object dataCellFermes = DGVOuvFerm.Rows[etape].Cells[0].Value;
			object dataCellOuverts = DGVOuvFerm.Rows[etape].Cells[1].Value;
			string strLFerUser = (dataCellFermes == null ? "" : dataCellFermes.ToString());
			string strLOuvUser = (dataCellOuverts == null ? "" : dataCellOuverts.ToString());
			LFerUser = LNoeudsStrToList(strLFerUser);
			LOuvUser = LNoeudsStrToList(strLOuvUser);

			// On récupère les bonnes liste des ouverts et fermés (ceux de l'IA)
			List<GenericNode> VraieLFer = arbreSol.EtapesFermes[etape];
			List<GenericNode> VraieLOuv = arbreSol.EtapesOuverts[etape];

			// On les compare
			bool listesValides = (VerifListIdentique(LFerUser, VraieLFer) && VerifListIdentique(LOuvUser, VraieLOuv));
			// Si les listes sont bonnes, on peut ajouter une étape
			if (listesValides)
			{
				label1.Text = "Tu peux ajouter une etape !";
				BAjoutEtape.Enabled = true;
			}
			else
				label1.Text = "Tu as une erreur !";
		}

		/// <summary>
		/// Méthode privée qui retourne une liste de noeud (GenericNode) à partir d'une chaine de caractère.
		/// Seulement appelée pour la vérification de l'étape
		/// </summary>
		/// <param name="strList">Liste de noeuds sous forme d'une chaîne de caractères</param>
		/// <returns>La liste des noeuds (GenericNode) associés à la chaîne de caractères</returns>
		private List<GenericNode> LNoeudsStrToList(string strList)
		{
			List<GenericNode> listeNoeuds = new List<GenericNode>();

			// Si la chaîne est vide, on retourne une liste vide de noeuds
			if (strList == "")
				return listeNoeuds;

			// Sinon on split la chaîne avec les virgules et espaces en séparateurs
			string[] listStr = strList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			// Puis on ajoute les noeuds correspondant à la liste
			foreach (string strNumNode in listStr)
			{
				int numNode = int.Parse(strNumNode);
				Node N = new Node(numNode);
				listeNoeuds.Add(N);
			}

			return listeNoeuds;
		}

		/// <summary>
		/// Méthode privée qui compare deux liste de noeuds.
		/// Seulement appelée pour la vérification de l'étape
		/// </summary>
		/// <param name="listToCompare">La liste de noeuds (GenericNode) à comparer</param>
		/// <param name="vraieList">La liste qui sert de comparaison, celle à qui listToCompare doit être identique</param>
		/// <returns>true si les deux liste sont identiques, false sinon</returns>
		private bool VerifListIdentique(List<GenericNode> listToCompare, List<GenericNode> vraieList)
		{
			int nbNoeud = vraieList.Count;
			// Si les deux listes n'ont pas le même nombre de noeuds, c'est qu'elles ne sont pas identiques
			if (listToCompare.Count != nbNoeud)
				return false;

			// Sinon on compare chaque noeud, sans forcément respecter l'ordre
			else
			{
				foreach (Node nodeToCompare in listToCompare)
				{
					int i = 0;
					while (i < vraieList.Count && !nodeToCompare.IsEqual(vraieList[i]))
						i++;
					
					// Si on a comparer le noeud à tous ceux de la vraie liste sans le trouver, c'est que la liste de l'utilisateur est fausse
					if (i >= vraieList.Count)
						return false;
				}
			}

			// Au final si tout se passe bien, les deux listes sont identiques
			return true;
		}

		/// <summary>
		/// Méthode appelée lorsque l'utilisateur double-clique sur un noeud du TreeView, ici pour éditer le noeud sélectionné
		/// </summary>
		private void tvArbre_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			// On montre le noeud en cours d'édition
			label2.Text = "";
			bValiderTV.Enabled = true;
			// On récupère le noeud sélectionné
			TreeNode TN = tvArbre.SelectedNode;
			// On commence l'édition
			TN.BeginEdit();
		}

		/// <summary>
		/// Méthode de vérification de l'arbre (TreeView)
		/// </summary>
		private void bValiderTV_Click(object sender, EventArgs e)
		{
			//On récupère la solution de l'IA (la bonne)
			TreeView tvSolution = new TreeView();
			arbreBon = true;
			arbreSol.GetSearchTree(tvSolution, false);

			// On compare la solution de l'utilisateur avec celle de l'IA
			Comparer2Arbres(tvArbre, tvSolution);

			// Si les deux sont identiques, on félicite
			if (arbreBon)
				label2.Text = "Vous avez le bon arbre, BRAVO !";
			bValiderTV.Enabled = false;
		
		}

		/// <summary>
		/// Méthode privée qui compare 2 arbres (TreeView)
		/// Seulement appelée lors de la vérification de l'arbre
		/// Il n'y a aucune valeur de retour mais si les deux arbres sont différents, la valeur false est affectée au bool arbreBon
		/// </summary>
		/// <param name="TV1"></param>
		/// <param name="TV2"></param>
		private void Comparer2Arbres(TreeView TV1, TreeView TV2)
		{
			int compare = Math.Min(TV1.Nodes.Count, TV2.Nodes.Count);
			// ignore extra nodes
			// On compare les noeuds de départs (ici il n'y en a qu'un, le noeud de départ)
			for (int i = 0; i < compare; i++)
				CompareRecursiveTree(TV1.Nodes[i], TV2.Nodes[i]);
		}

		/// <summary>
		/// Méthode récursive appelée au départ par Comparer2Arbres
		/// Elle compare deux noeuds
		/// </summary>
		/// <param name="tn1"></param>
		/// <param name="tn2"></param>
		private void CompareRecursiveTree(TreeNode tn1, TreeNode tn2)
		{
			// Si les noeuds sont différents, l'arbre n'est pas bon
			if (tn1.Text != tn2.Text)
			{
				bValiderTV.Enabled = false;
				label2.Text = "Cet arbre est invalide";
				arbreBon = false;
			}
			// Sinon on compare les noeuds fils de ces noeuds de façon récursive
			else
			{
				int compare = Math.Min(tn1.Nodes.Count, tn2.Nodes.Count);
				// ignore extra nodes
				for (int i = 0; i < compare; i++)
					CompareRecursiveTree(tn1.Nodes[i], tn2.Nodes[i]);
			}
		}
	}
}
