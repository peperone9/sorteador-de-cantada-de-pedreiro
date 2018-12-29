using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Sistema_Pastelaria
{
    class Program
    {

        static void Main(string[] args)
        {
            //declaração
            int sorteador;
            string[] pedreiragem = new string[10];
            char repetir;
            Random cantada = new Random();
            //cantadas em vetores
            pedreiragem[0] = "Gata, você não é uma estrada com buraco mas é um pedaço de mau caminho.Sua linda!";
            pedreiragem[1] = "Gata, eu rezo 1 / 3, para achar 1 / 2 de te levar pra 1 / 4, sua linda!";
            pedreiragem[2] = "Gata, você trabalha na fiat? Porque você faz o meu stilo. Sua linda!";
            pedreiragem[3] = "Gata, pare de brincar de esconde-esconde, E vamos logo pro pega - pega.";
            pedreiragem[4] = "Gata, você não é lan-house Mas to doido pra botar uma hora!Sua linda!";
            pedreiragem[5] = "Gata, não sou Alice, Mas com você me sinto no País das Maravilhas.";
            pedreiragem[6] = "Gata, seu nome é Camila? Então vem camilamber!";
            pedreiragem[7] = "Gata, você não é piso molhado Mas eu já tô pronto, pra te passar o rodo, sua linda!";
            pedreiragem[8] = "Gata, você não é tampinha de caneta, Mas dá vontade de morder!";
            pedreiragem[9] = "Gata, quando chegar em sua casa beba bastante água Porque eu te sequei todinha, sua linda!";
            do
            {
                sorteador = cantada.Next(9);
                for (int i = 0; i < 1; i++)
                    Console.Write(pedreiragem[sorteador]);
                while (!(char.TryParse(Console.ReadLine(), out repetir) && (repetir == 's' || repetir == 'n')))
                    Console.Write(" A: ");
                Console.Clear();
            } while (repetir == 's');
        }
    }
}