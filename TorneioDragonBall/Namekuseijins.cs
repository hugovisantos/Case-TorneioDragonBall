namespace TorneioDragonBall
{
    public class Namekuseijins : Lutador
    {
        public override long Lutar()
        {
            return Forca * Chi;
        }

        public Namekuseijins AbserverOutroNamekuseijins(Namekuseijins outroNamekuseijins)
        {
            Namekuseijins novoNamekuseijins = new Namekuseijins
            {
                Forca = this.Forca + outroNamekuseijins.Forca,
                Chi = this.Chi + outroNamekuseijins.Chi * 10
            };

            return novoNamekuseijins;

        }
    }    
}

