﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M2 {
    class Program {
        static void Main(string[] args) {
            MLST1 e1 = new MLST1();
            //e1.Fase1();
            //e1.Fase2();
            //e1.Fase3();
            //e1.Fase4();

            MLST2 e2 = new MLST2();
            //e2.Fase1(5);
            e2.Fase2(5);

            Console.ReadKey();
        }
    }
}
