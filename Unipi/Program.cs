using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unipi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                TriNode A = crea(i);
                System.Console.WriteLine(" albero iniziale  " + A);
                altera(A);
                System.Console.WriteLine(" albero alterato  " + A);
                System.Console.WriteLine();
            }
        }
        private static TriNode crea(int i)
        {
            switch (i)
            {
                case 0:
                    return TriNode.n(1, TriNode.f(9), TriNode.f(6), TriNode.f(1));
                case 1:
                    return TriNode.n(9,
                            TriNode.n(8,
                                    TriNode.n(7, TriNode.f(4), TriNode.f(4), TriNode.f(9)),
                                    TriNode.f(5),
                                    TriNode.n(7, TriNode.f(6), TriNode.f(6), TriNode.f(7))),
                            TriNode.f(5),
                            TriNode.f(5));
                case 2:
                    return null;
            }
            return null;
        }
        /*
	     * Il metodo altera riceve come argomento un albero ternario di int positivi.
	     * Ogni nodo non foglia deve essere modificato, sostituendovi la somma degli
	     * elementi del sottoalbero di cui  radice compreso il precedente valore della
	     * radice. 
	     * Alla fine la radice di tutto l'albero deve contenere la somma degli elementi
	     * dell'albero di partenza. 
	     * La complessità deve essere di ordine lineare. 
	     * L'albero originario deve essere modificato	 
	     */

        public static int altera(TriNode a)
        {
            bool isFinished = false;

            while (!isFinished)
            {

                if (!IsLeaf(a))
                {

                }
            }
            return 10;
        }
        private static bool IsLeaf(TriNode tn)
        {
            return (tn.left == null) && (tn.right == null) && (tn.center == null);
        }
    }
}
