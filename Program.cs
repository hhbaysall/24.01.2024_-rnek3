// Kullanıcıya Kaç adet öğrenci bilgisi girmek isteğini soralım.
// O sayı kadar öğrenci bilgisi talep edelim.
// öğrencilerin genel not ort sini ekrana yazdıralım.
// ad soyad n1 n2 n3  

using _24._01._2024_örnek3;

Console.Write("Girilecek öğrenci bilgisi girmek istersiniz?  ");
int adet=int.Parse(Console.ReadLine());
Console.WriteLine();

List<Ogranci> ogrenciler =new List<Ogranci>();

for (int i = 0; i < adet; i++)
{
    Console.Write("{0}. Öğrenci Bilgileri",i+1);
    Console.WriteLine("----------------------");
    Ogranci o = new Ogranci();
    Console.Write("Ad: ");
    o.Ad = Console.ReadLine();
    Console.Write("Soy Ad: ");
    o.SoyAd = Console.ReadLine();
    Console.Write("1. Notu: ");
    o.N1=int.Parse(Console.ReadLine());
    Console.Write("2. Notu: ");
    o.N2 = int.Parse(Console.ReadLine());
    Console.Write("3. Notu: ");
    o.N3 = int.Parse(Console.ReadLine());
    ogrenciler.Add(o);
}

double genelOrt = 0;

foreach (var item in ogrenciler)
{
    genelOrt += item.Ortalama;
}
genelOrt = genelOrt / ogrenciler.Count;

Console.WriteLine("Genel ortalama: "+genelOrt);