using System;
using System.Collections.Generic;
using TorneioDragonBall.Enums;

namespace TorneioDragonBall
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            List<Lutador> listaLutadoresCadastrados = new List<Lutador>();     


            while (listaLutadoresCadastrados.Count <= 8)
            {

                Console.WriteLine("Insira a categoria do lutador:\n1-Humano\n2-Namekuseijin\n3-Saiyajin?");
                int tipoDeLutador = 0;
                int.TryParse(Console.ReadLine(), out tipoDeLutador);

                switch (tipoDeLutador)
                {
                    //HUMANO
                    case 1:
                        {
                            var humano = new Humanos();

                            Console.WriteLine("Insira o nome do humano");
                            humano.Nome = Console.ReadLine();

                            Console.WriteLine("Insira a força do humano");
                            int forca = -1; //:(
                            int.TryParse(Console.ReadLine(), out forca);
                            humano.Forca = forca;

                            Console.WriteLine("Insira o chi do humano");
                            int chi = -1; //:(
                            int.TryParse(Console.ReadLine(), out chi);
                            humano.Chi = chi;

                            listaLutadoresCadastrados.Add(humano);
                            Console.WriteLine("Humano cadastrado com sucesso! Boa sorte\n\n");
                            break;
                        }

                    //NAMEKUSEIJIN
                    case 2:
                        {
                            var namekuseijin = new Namekuseijins();

                            Console.WriteLine("Insira o nome do namekuseijin");
                            namekuseijin.Nome = Console.ReadLine();

                            Console.WriteLine("Insira a força do namekuseijin");
                            int forca = -1; //:(
                            int.TryParse(Console.ReadLine(), out forca);
                            namekuseijin.Forca = forca;

                            Console.WriteLine("Insira o chi do namekuseijin");
                            int chi = -1; //:(
                            int.TryParse(Console.ReadLine(), out chi);
                            namekuseijin.Chi = chi;

                            listaLutadoresCadastrados.Add(namekuseijin);
                            Console.WriteLine("Namekuseijin cadastrado com sucesso! Boa sorte\n\n");
                            break;
                        }

                    //SAIYAJIN
                    case 3:
                        {
                            var saiyajin = new Saiyajins();

                            Console.WriteLine("Insira o nome do saiyajin");
                            saiyajin.Nome = Console.ReadLine();

                            Console.WriteLine("Insira a força do saiyajin");
                            int forca = -1; //:(
                            int.TryParse(Console.ReadLine(), out forca);
                            saiyajin.Forca = forca;

                            Console.WriteLine("Insira o chi do saiyajin");
                            int chi = -1; //:(
                            int.TryParse(Console.ReadLine(), out chi);
                            saiyajin.Chi = chi;

                            Console.WriteLine("Insira o nivel do saiyajin");
                            int nivel = 1; //:(
                            int.TryParse(Console.ReadLine(), out nivel);
                            saiyajin.NivelSaiyajinsEnum = (NivelSaiyajinsEnum)nivel;

                            listaLutadoresCadastrados.Add(saiyajin);
                            Console.WriteLine("Saiyajin cadastrado com sucesso! Boa sorte\n\n");
                            break;
                        }
                    default:
                        throw new Exception();
                }                
            }
            var torneio = new Torneio();
            var vencedor = torneio.ExecutarTorneio(listaLutadoresCadastrados);
            Console.WriteLine(vencedor.Nome);
            Console.ReadKey();
        }
    }
}
