using System;
using System.Collections.Generic;

namespace AutomataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Durumlar oluşturuluyor ve ekleniyor...
            List<IDurum> durumlar = new List<IDurum>();
            
            IDurum aDurumu = new DigerDurum("A");    
            IDurum bDurumu = new BitisDurum("B");
            IDurum cDurumu = new DigerDurum("C");
            IDurum dDurumu = new BitisDurum("D");
            IDurum eDurumu = new DigerDurum("E");

            durumlar.Add(aDurumu);
            durumlar.Add(bDurumu);
            durumlar.Add(cDurumu);
            durumlar.Add(dDurumu);
            durumlar.Add(eDurumu);

            //Alfabe belirleniyor...
            List<char> alfabe = new List<char> {'a', 'b'};

            //Geçiş fonksiyonları belirleniyor...

            //new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "Q0"), durumlar.Find(x => x.DurumAdi == "Q1"), 'A'); Q0 durumundan Q1 durumuna A harfi ile geçebilirsin.

            var gecisFonksiyonlari = new List<GecisFonksiyonu>
            {
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "A"), durumlar.Find(x => x.DurumAdi == "B"),
                    'a'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "A"), durumlar.Find(x => x.DurumAdi == "C"),
                    'b'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "B"), durumlar.Find(x => x.DurumAdi == "B"),
                    'a'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "B"), durumlar.Find(x => x.DurumAdi == "D"),
                    'b'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "C"), durumlar.Find(x => x.DurumAdi == "E"),
                    'a'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "C"), durumlar.Find(x => x.DurumAdi == "C"),
                    'b'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "D"), durumlar.Find(x => x.DurumAdi == "E"),
                    'a'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "D"), durumlar.Find(x => x.DurumAdi == "C"),
                    'b'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "E"), durumlar.Find(x => x.DurumAdi == "E"),
                    'a'),
                new GecisFonksiyonu(durumlar.Find(x => x.DurumAdi == "E"), durumlar.Find(x => x.DurumAdi == "D"),
                    'b')
            };
            
            //DFA oluşturuluyor...

            DeterministicFiniteAutomata dfa = new DeterministicFiniteAutomata(durumlar, alfabe, aDurumu, gecisFonksiyonlari);

            Console.WriteLine("Lütfen bir girdi giriniz:");
            string girdi = Console.ReadLine().ToLower();
            Console.WriteLine(dfa.GirdiUyumunuKontrolEt(girdi) ? "Bu girdi uyumludur": "Bu girdi uyumsuzdur");
            Console.Read();
        }
    }
}
