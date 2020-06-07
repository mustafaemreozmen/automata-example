namespace AutomataExample
{
    public class GecisFonksiyonu: IGecisFonksiyonu
    {
        public IDurum GirisDurumu { get; }
        public IDurum CikisDurumu { get; }
        public char GirisSembolu { get; }

        public GecisFonksiyonu(IDurum girisDurumu, IDurum cikisDurumu, char girisSembolu) //Gecis fonksiyonunu olusturan kurucu metod.
        {
            GirisDurumu = girisDurumu;
            CikisDurumu = cikisDurumu;
            GirisSembolu = girisSembolu;
        }
    }
}
