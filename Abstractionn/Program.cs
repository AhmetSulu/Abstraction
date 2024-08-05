using Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Şirket çalışanı nesnelerini oluşturuyoruz
        SirketCalisani yazilimGelistirici = new YazilimGelistirici("Ahmet", "Sulu");
        SirketCalisani projeYoneticisi = new ProjeYoneticisi("Burak", "Ekşi");
        SirketCalisani satisTemsilcisi = new SatisTemsilcisi("Sümeyye", "Yavuzyılmaz");

        // Her çalışanın görev metodunu çağırıyoruz
        yazilimGelistirici.Gorev();
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();
    }
}