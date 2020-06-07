using System.Collections.Generic;

namespace AutomataExample
{
    public interface IAutomata
    {
        List<IDurum> Durumlar { get; } //Durumlar
        List <char> Alfabe { get; } //Kabul Edilen Alfabe
        IDurum BaslangicDurumu { get; } //Başlangıç Durumumuz
        List <IDurum> BitisDurumlari { get; } //Bitiş Durumlarımız
        List<GecisFonksiyonu> GecisFonksiyonlari { get; } //Geçiş Fonksiyonlarımız
    }
}
