using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_PSI_Mod_10
{
    internal class Falcao : Animal
    {

        public void velocidade()
        {
            Console.WriteLine("\nVoa á 390 km por hora.\n");
        }
        public void habitat()
        {
            Console.WriteLine("\nZonas montanhosas e costeiras, mas também podem ser encontradas em grandes cidades.\n");
        }
        public void raca()
        {
            Console.WriteLine("\nAve Nebri(Falcão)\n");
        }
        public void tamanho()
        {
            Console.WriteLine("\n34 - 58 cm\n");
        }
    }
}
