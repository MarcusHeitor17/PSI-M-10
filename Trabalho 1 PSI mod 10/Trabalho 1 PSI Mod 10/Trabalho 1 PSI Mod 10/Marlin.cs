using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_PSI_Mod_10
{
    internal class Marlin : Animal
    {
        public void velocidade()
        {
            Console.WriteLine("\nNada á 130 km por hora.\n");
        }
        public void habitat()
        {
            Console.WriteLine("\nOceano índico e Pacífico.\n");
        }
        public void raca()
        {
            Console.WriteLine("\nPeixe Espada ou Espadim.\n");
        }
        public void tamanho()
        {
            Console.WriteLine("\nPode chegar até  7 métros de comprimento.\n");
        }
    }
}
