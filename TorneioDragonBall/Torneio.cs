using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDragonBall
{
    public class Torneio
    {
        public List<Batalha> Batalhas { get; set; }

        public Lutador ExecutarTorneio(List<Lutador> lutadores)
        {
            
            //Quartas de finais
            List<Lutador> vencedoresDasQuartasDeFinais = new List<Lutador>();
            List<Batalha> quartasDeFinais = new List<Batalha>();

            for (var i = 0; i < lutadores.Count; i += 2)
            {
                var batalha = new Batalha
                {
                    LutadorA = lutadores[i],
                    LutadorB = lutadores[i + 1]
                };

                quartasDeFinais.Add(batalha);
            }
            
            foreach (var batalha in quartasDeFinais)
            {
                var vencedorDaBatalha = batalha.Batalhar();
                vencedoresDasQuartasDeFinais.Add(vencedorDaBatalha);
            }


            //Semi Finais
            List<Lutador> vencedoresDasSemiFinais = new List<Lutador>();
            List<Batalha> semiFinais = new List<Batalha>();
            
            for (var i = 0; i < vencedoresDasQuartasDeFinais.Count/2; i++)
            {
                var batalha = new Batalha
                {
                    LutadorA = vencedoresDasQuartasDeFinais[i],
                    LutadorB = vencedoresDasQuartasDeFinais[i + 1]
                };

                semiFinais.Add(batalha);
            }

            foreach (var batalha in semiFinais)
            {
                var vencedorDaBatalha = batalha.Batalhar();
                vencedoresDasSemiFinais.Add(vencedorDaBatalha);
            }

            //Finais
            Lutador vencedorDoTorneio = default(Lutador);
            List<Batalha> final = new List<Batalha>();

            for (var i = 0; i < vencedoresDasSemiFinais.Count/2; i++)
            {
                var batalha = new Batalha
                {
                    LutadorA = vencedoresDasSemiFinais[i],
                    LutadorB = vencedoresDasSemiFinais[i + 1]
                };

                final.Add(batalha);
            }

            foreach (var batalha in semiFinais)
            {
                vencedorDoTorneio = batalha.Batalhar();
            }

            return vencedorDoTorneio;
        }
    }
}
