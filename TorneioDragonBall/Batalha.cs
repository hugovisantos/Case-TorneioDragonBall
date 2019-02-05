namespace TorneioDragonBall
{
    public class Batalha
    {
        
        public Lutador LutadorA { get; set; }
        public Lutador LutadorB { get; set; }

        

        public Lutador Batalhar()
        {
            if (LutadorA.Nome == "Mr. Satã" )
            {
                return LutadorA;
            }
            if (LutadorB.Nome == "Mr. Satã")
            {
                return LutadorB;
            }

            var poderDeLutaA = LutadorA.Lutar();
            var poderDeLutaB = LutadorB.Lutar();
            
            if(poderDeLutaA > poderDeLutaB)
            {
                return LutadorA;
            }
            return LutadorB;
            
        }

    }
}
