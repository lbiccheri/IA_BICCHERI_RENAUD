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


		public FormUser()
		{
			InitializeComponent();
		}

		private void BInit1_Click(object sender, EventArgs e)
		{
			TBNoeuInit.Text = "0";
			TBNoeuFin.Text = "6";
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
			DGVOuvFerm.Rows.Add();
		}

		private void BAjoutEtape_Click(object sender, EventArgs e)
		{
			List<GenericNode> LOuvUser = new List<GenericNode>();
			List<GenericNode> LFerUser = new List<GenericNode>();
			int etape = DGVOuvFerm.Rows.Count;
			string strLOuvUser = DGVOuvFerm.Rows[etape - 1].Cells[0].Value.ToString();
			string strLFerUser = DGVOuvFerm.Rows[etape - 1].Cells[1].Value.ToString();

			label1.Text = strLFerUser;
			label2.Text = strLOuvUser;
			//for (int i = 0; i < strLFerUser.Length; i++)
			//{

			//}
			DGVOuvFerm.Rows.Add();
		}
	}
}
