using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M2 {
    class MLST1 {
        public void Fase1() {
            char[] nombre = { 'I', 'a', 'g', 'o' };

            foreach (char c in nombre) {
                Console.Write(c + " ");
            }
        }
        
        public void Fase2() {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            char[] nombre = { 'I', 'a', 'g', 'o' };
            List<char> nombreList = nombre.ToList();
            
            foreach (char c in nombre) {
                Console.WriteLine(c);
               
                if (vocales.Contains(c)) {
                    Console.WriteLine("VOCAL");
                }

                if (char.IsDigit(c)) {
                    Console.WriteLine("Los nombres no contienen números!!");
                }
            }
        }

        public void Fase3() {
            Dictionary<char, int> map = new Dictionary<char, int>();

            char[] nombre = { 'I', 'a', 'g', 'o', 'o', 'o' };
            List<char> nombreList = nombre.ToList();

            foreach (char c in nombre) {
                if (map.ContainsKey(c)) {
                    map[c] += 1;
                } else {
                    map.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> kp in map) {
                Console.WriteLine("{0} => {1}", kp.Key, kp.Value);
            }
        }

        public void Fase4() {
            char[] nombre = { 'I', 'a', 'g', 'o' };
            char[] apellido = { 'G', 'o', 'n', 'z', 'á', 'l', 'e', 'z' };

            List<char> nombreList = nombre.ToList();            
            List<char> apellidoList = apellido.ToList();

            List<char> nombreApellido = new List<char>();
            
            foreach (char c in nombre) {
                nombreApellido.Add(c);
            }

            nombreApellido.Add(' ');

            foreach (char c in apellido) {
                nombreApellido.Add(c);
            }

            foreach (char c in nombreApellido) {
                Console.Write("{0}", c);
            }
        }
    }
}
