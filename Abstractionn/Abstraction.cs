using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // Şirket çalışanları için abstract sınıf
    public abstract class SirketCalisani
    {
        // Ad ve Soyad özellikleri
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Title özelliği, her çalışan türü için geçerli
        public abstract string Unvan { get; }

        // Constructor
        protected SirketCalisani(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        // Görev metodunu soyut hale getiriyoruz
        public abstract void Gorev();
    }

    // Yazılım Geliştirici sınıfı
    public class YazilimGelistirici : SirketCalisani
    {
        public override string Unvan => "Yazılım Geliştirici";

        public YazilimGelistirici(string ad, string soyad)
            : base(ad, soyad)
        {
        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} {Unvan} olarak çalışıyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    public class ProjeYoneticisi : SirketCalisani
    {
        public override string Unvan => "Proje Yöneticisi";

        public ProjeYoneticisi(string ad, string soyad)
            : base(ad, soyad)
        {
        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} {Unvan} olarak çalışıyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    public class SatisTemsilcisi : SirketCalisani
    {
        public override string Unvan => "Satış Temsilcisi";

        public SatisTemsilcisi(string ad, string soyad)
            : base(ad, soyad)
        {
        }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} {Unvan} olarak çalışıyorum.");
        }
    }
}
