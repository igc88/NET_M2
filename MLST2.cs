using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M2 {
    class MLST2 {
        public void Fase1(int altura) {
            for (int i = 0; i < altura; i++) {
                for (int j = 1; j < i + 2; j++) {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }

        public void Fase2(int altura) {
            for (int numBlancos = 0, numAsteriscos = (altura * 2) - 1; numAsteriscos > 0; numBlancos++, numAsteriscos -= 2) {
                for (int i = 0; i < numBlancos; i++) {
                    Console.Write(" ");
                }

                for(int j=numAsteriscos;j>0;j--){
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
