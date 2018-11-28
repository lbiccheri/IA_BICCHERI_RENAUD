using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie2
{
    public class Node : GenericNode
    {
        public int numero;

        public Node(Node N) : base(N)
        {
            numero = N.numero;
        }

        public Node(int numero) : base()
        {
            this.numero = numero;
        }

        public Node() : this(0) { }

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            Node N2bis = (Node)N2;

            return numero == N2bis.numero;
        }

        public override double GetArcCost(GenericNode N2)
        {
            Node N2bis = (Node)N2;
            return FormUser.matrice[numero, N2bis.numero];
        }

        public override bool EndState()
        {
            return (numero == FormUser.numFinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < FormUser.nbnodes; i++)
            {
                if (FormUser.matrice[numero, i] != -1)
                {
                    Node newnode2 = new Node();
                    newnode2.numero = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }


        public override double CalculeHCost()
        {
            return (0);
        }

        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}
