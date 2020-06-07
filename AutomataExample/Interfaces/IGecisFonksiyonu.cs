namespace AutomataExample
{
    public interface IGecisFonksiyonu
    {
        IDurum GirisDurumu { get; } //Giris Durumu

        IDurum CikisDurumu { get; } //Cikis Durumu

        char GirisSembolu { get; } //Giris Sembolu
    }
}
