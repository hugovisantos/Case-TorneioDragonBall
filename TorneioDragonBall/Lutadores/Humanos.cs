using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDragonBall
{
    public class Humanos : Lutador
    {

        public override long Lutar()
        {
            var poderDeLuta = Forca * Chi;
            return poderDeLuta;
        }
    }
}
