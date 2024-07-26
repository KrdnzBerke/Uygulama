// See https://aka.ms/new-console-template for more information

/* double snotu = 0, toplam = 0, ortalama = 0;
for (int i = 0; i < 20; i++)
{
    Console.Write("{0}. notu giriniz:", (i + 1));
Okunot:
    snotu = Convert.ToDouble(Console.ReadLine());
    if (snotu < 0 || snotu > 100)
    {
        Console.Write("Yanlış not girdiniz.\nTekrardan giriniz:");
        goto Okunot;
    }
    toplam += snotu;
}

ortalama = toplam / 20;
Console.WriteLine("Toplam={0}\nOrtalama={1}", toplam, ortalama);
Console.ReadKey(); */



/* double derece = 0;
Console.Write("Sıcaklık değerini giriniz:");
derece = Convert.ToDouble(Console.ReadLine());

if (derece <= 0)
{
    Console.Write("KATI");
}
else if (derece > 0 && derece < 100)
{
    Console.Write("SIVI");
}
else
{
    Console.Write("GAZ");
}

Console.ReadKey(); */

double fiyat = 0;
int adet = 0;
Console.Write("Ürünün fiyatını giriniz:");

OkuFiyat:
fiyat = Convert.ToDouble(Console.ReadLine());

if (fiyat <= 0)
{
    Console.Write("Yanlış fiyat bilgisi girdiniz.\nFiyatı tekrardan giriniz:");
    goto OkuFiyat;
}


Console.Write("Aldığınız ürün miktarını giriniz:");

OkuAdet:
adet = Convert.ToInt32(Console.ReadLine());

if (adet <= 0)
{
    Console.Write("Yanlış miktar bilgisi girdiniz.\nAldığınız ürün miktarını tekrardan giriniz:");
    goto OkuAdet;
}

double tutar = fiyat * adet;
Console.WriteLine("Ödeyeceğiniz toplam tutar {0}TL", tutar);
Console.ReadKey();