using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Trabalho_1_PSI_Mod_10;

namespace Trabalho_PSI1_MOD_10___Classes_Herancas_e_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int escolha = 0;
        voltar:
            Console.WriteLine("Escolha um dos animais abaixo para mostrar suas informações: ");

            Console.WriteLine("1 - Falcão-Peregrino");
            Console.WriteLine("2 - Chita");
            Console.WriteLine("3 - Marlin Negro");

            Console.WriteLine("\n Digite um número (de 1 a 3):");
            escolha = Convert.ToInt32(Console.ReadLine());


           
           
            if (escolha == 1)
            {
                Falcao FalcaoPeregrino = new Falcao();
                Console.Write("Velocidade:"); FalcaoPeregrino.velocidade();
                Console.Write("Habitat:"); FalcaoPeregrino.habitat();
                Console.Write("Raça:"); FalcaoPeregrino.raca();
                Console.Write("Tamanho:"); FalcaoPeregrino.tamanho();

            }
            else if (escolha == 2)
            {
                Chita ChitaGato = new Chita();
                Console.Write("Velocidade:"); ChitaGato.velocidade();
                Console.Write("Habitat:"); ChitaGato.habitat();
                Console.Write("Raça:"); ChitaGato.raca();
                Console.Write("Tamanho:"); ChitaGato.tamanho();
            }
            else if (escolha == 3)
            {
                Marlin MarlinNegro = new Marlin();
                Console.Write("Velocidade:"); MarlinNegro.velocidade();
                Console.Write("Habitat:"); MarlinNegro.habitat();
                Console.Write("Raça:"); MarlinNegro.raca();
                Console.Write("Tamanho:"); MarlinNegro.tamanho();
            }
            else
            {
                Console.ReadLine();
                Console.WriteLine("[!] Número inválido [!]");
                Console.WriteLine("\n preciona qualquer tecla para continuar\n");
                goto voltar;
                Console.Clear();

            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("precione [ENTER] para escolher outro animal");
            Console.ReadLine();
      
            Console.Clear();
            
            goto voltar;
            


        }
    }
}