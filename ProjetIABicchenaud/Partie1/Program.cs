using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1
{
	static class Program
	{
		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            //Si l'on veut ajouter une question il suffit de : 
            //Question q1 = new Question("Le projet est en combien de parties?", "1", "2", "3", "2");
            //q1.AjouterQuestion();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new formPresentation());
            
		}
	}
}
