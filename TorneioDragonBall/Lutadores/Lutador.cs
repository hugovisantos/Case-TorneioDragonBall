using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDragonBall
{
    public abstract class Lutador
    {
        public string Nome { get; set; }

        public int Forca { get; set; }

        public int Chi { get; set; }

        public abstract long Lutar();

        
    }
}
