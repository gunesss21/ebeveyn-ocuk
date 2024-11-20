using System;
using System.Collections.Generic;

// Çocuk sınıfı: Çocuğun temel özelliklerini ve işlevselliğini temsil eder
public class Cocuk
{
    public string Ad { get; private set; }
    public int Yas { get; private set; }
    public Ebeveyn Ebeveyn { get; private set; }

    // Çocuk yapıcısı
    public Cocuk(string ad, int yas, Ebeveyn ebeveyn)
    {
        Ad = ad;
        Yas = yas;
        Ebeveyn = ebeveyn;
    }

    // Çocuk detaylarını yazdırma metodu
    public override string ToString()
    {
        return $"Ad: {Ad}, Yaş: {Yas}, Ebeveyn: {Ebeveyn.Ad}";
    }
}

// Ebeveyn sınıfı: Ebeveynin temel özelliklerini ve işlevselliğini temsil eder
public class Ebeveyn
{
    public string Ad { get; private set; }
    public int Yas { get; private set; }
    public List<Cocuk> Cocuklar { get; private set; }

    // Ebeveyn yapıcısı
    public Ebeveyn(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
        Cocuklar = new List<Cocuk>();
    }

    // Ebeveynin çocuk ekleme metodu
    public void CocukEkle(Cocuk cocuk)
    {
        if (cocuk != null)
        {
            Cocuklar.Add(cocuk);
        }
        else
        {
            Console.WriteLine("Geçersiz çocuk.");
        }
    }

    // Ebeveynin çocuklarını listeleme metodu
    public void CocuklariGoster()
    {
        Console.WriteLine($"Ebeveyn: {Ad}, Yaş: {Yas}");
        Console.WriteLine("Çocuklar:");
        foreach (var cocuk in Cocuklar)
        {
            Console.WriteLine($"  - {cocuk}");
        }
    }
}

// Program sınıfı: Uygulamanın ana giriş noktası
public class Program
{
    public static void Main(string[] args)
    {
        // Ebeveynler oluşturuluyor
        var ebeveyn1 = new Ebeveyn("Ahmet Yılmaz", 40);
        var ebeveyn2 = new Ebeveyn("Ayşe Yılmaz", 38);

        // Çocuklar oluşturuluyor ve ebeveynlere ekleniyor
        var cocuk1 = new Cocuk("Ali Yılmaz", 15, ebeveyn1);
        var cocuk2 = new Cocuk("Zeynep Yılmaz", 10, ebeveyn1);
        var cocuk3 = new Cocuk("Emre Yılmaz", 5, ebeveyn2);

        ebeveyn1.CocukEkle(cocuk1);
        ebeveyn1.CocukEkle(cocuk2);
        ebeveyn2.CocukEkle(cocuk3);

        // Ebeveynlerin çocukları gösteriliyor
        ebeveyn1.CocuklariGoster();
        ebeveyn2.CocuklariGoster();
    }
}
