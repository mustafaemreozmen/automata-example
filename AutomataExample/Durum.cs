namespace AutomataExample
{
    public class Durum: IDurum
    {
        public string DurumAdi { get; }
        public bool BitisDurumuMu { get; }     

        public Durum(bool bitisDurumuMu, string durumAdi):this(durumAdi)
        {
            BitisDurumuMu = bitisDurumuMu;
        }

        public Durum(string durumAdi)
        {
            DurumAdi = durumAdi;
        }
    }
}
