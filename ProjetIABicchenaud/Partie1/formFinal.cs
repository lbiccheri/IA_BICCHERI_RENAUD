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
    public partial class formFinal : Form
    {
        public formFinal()
        {
            InitializeComponent();
            lbFelicitation.Text = "Félicitations vous venez de finir ce test!";
            lbScore.Text = "Vous venez de faire " + " fautes";
        }
    }
}
