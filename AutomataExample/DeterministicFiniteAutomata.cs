using System;
using System.Collections.Generic;
using System.Linq;


namespace AutomataExample
{
    public class DeterministicFiniteAutomata : IAutomata
    {
        public List<IDurum> Durumlar { get; }
        public List<char> Alfabe { get; }
        public IDurum BaslangicDurumu { get; }
        public List<IDurum> BitisDurumlari { get; }
        public List<GecisFonksiyonu> GecisFonksiyonlari { get; }
        public DeterministicFiniteAutomata(List<IDurum> durumlar, List<char> alfabe, IDurum baslangicDurumu, List<GecisFonksiyonu> transitionfunctions)
        {
            Durumlar = durumlar;
            Alfabe = alfabe;
            BaslangicDurumu = baslangicDurumu;
            BitisDurumlari = durumlar.FindAll(x => x.BitisDurumuMu == true); ;
            GecisFonksiyonlari = transitionfunctions;
        }

        private bool GirdilerAlfabeyleUyumluMu(string girdi) //Girdinin alfabeye uyup uymadığını kontrol eden metod
        {
            List<char> hataliGirdiler = new List<char>();
            foreach (char sembol in girdi.Where(girdiSembolu => !this.Alfabe.Contains(girdiSembolu)))
            {
                Console.WriteLine("Girdinizdeki ({0}) sembolu kabul edilen alfabenin bir parcasi olmadigindan bu makine bu ifadeyi kabul etmemektedir.\n", sembol);
                hataliGirdiler.Add(sembol);
            }

            return hataliGirdiler.Count != 0;
        }

        public bool GirdiUyumunuKontrolEt(string girdi) //Girdinin genel kontrollerini yapan metod
        {
            var bulunulanDurum = BaslangicDurumu;

            if (GirdilerAlfabeyleUyumluMu(girdi))
            {
                return false;
            }

            foreach (char sembol in girdi.ToCharArray())
            {
                var gecisFonksiyonu = GecisFonksiyonlari.Find(x => x.GirisDurumu.DurumAdi == bulunulanDurum.DurumAdi && x.GirisSembolu == sembol);
                if (gecisFonksiyonu == null)
                {
                    Console.WriteLine("Geçiş durumu bulunamayan bir durum mevcut");
                    return false;
                }

                bulunulanDurum = gecisFonksiyonu.CikisDurumu;
            }

            return BitisDurumlari.Contains(bulunulanDurum);
        }

    }
}
