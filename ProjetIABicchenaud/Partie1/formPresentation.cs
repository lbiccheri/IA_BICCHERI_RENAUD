using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1
{
	public partial class formPresentation : Form
	{
		public formPresentation()
		{
			InitializeComponent();
		}

        private void btContinuer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            formQuestion fq = new formQuestion();            
            fq.Show();
            fq.Activate();
            //this.Close();
        }
    }
}
