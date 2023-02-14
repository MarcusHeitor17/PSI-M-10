using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_PSI_Mod_10
{
    internal class Chita : Animal
    {
        public void velocidade()
        {
            Console.WriteLine("\nCorre á 130 km por hora\n");
        }
        public void habitat()
        {
            Console.WriteLine("\nSavanas, planícies arborizadas e zonas semidesérticas.\n");
        }
        public void raca()
        {
            Console.WriteLine("\nFelino\n");
        }
        public void tamanho()
        {
            Console.WriteLine("\n1,1 – 1,5 m\n");
        }
    }
}
