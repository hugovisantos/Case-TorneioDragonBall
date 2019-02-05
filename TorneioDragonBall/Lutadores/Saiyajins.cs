using System;
using TorneioDragonBall.Enums;

namespace TorneioDragonBall
{
    public class Saiyajins : Lutador
    {
        
        public NivelSaiyajinsEnum NivelSaiyajinsEnum { get; set; }

        public override long Lutar() => (long)(this.Forca * Math.Pow(this.Chi, (int)this.NivelSaiyajinsEnum));
        
    }
}
