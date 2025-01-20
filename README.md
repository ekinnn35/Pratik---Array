Array Operations in C#
Proje Açıklaması
Bu proje, C# programlama dilinde dizi (array) işlemlerini öğretmek amacıyla hazırlanmıştır. Projede, kullanıcıdan alınan sayılarla bir dizi oluşturulmuş, yeni bir eleman eklenmiş ve dizi sıralanarak ekrana yazdırılmıştır.

Proje Aşamaları
Dizi Tanımlama:

10 adet tam sayı verisi alabilecek bir dizi tanımlanmıştır.
Diziyi Doldurma ve Yazdırma:

for döngüsü ile kullanıcıdan dizi elemanları alınır.
foreach döngüsü ile dizi elemanları ekrana yazdırılır.
Yeni Eleman Ekleme:

Kullanıcıdan alınan yeni bir sayı, mevcut dizinin boyutu artırılarak eklenir.
Büyükten Küçüğe Sıralama:

Dizi önce küçükten büyüğe sıralanır, ardından ters çevrilerek büyükten küçüğe sıralı şekilde yazdırılır.
Proje Yapısı
bash
Kopyala
ArrayExample/
└── Program.cs    # Ana program kodlarının bulunduğu dosya.
Nasıl Çalıştırılır?
Projeyi bir C# geliştirme ortamında (Visual Studio, VS Code, .NET CLI) açın.

Komut satırında projenin bulunduğu klasöre gidin.

Aşağıdaki komutu çalıştırarak programı derleyin ve çalıştırın:

sh
Kopyala
dotnet run
Konsolda aşağıdaki adımları takip edin:

10 adet sayı girin.
Yeni bir sayı ekleyin.
Programın sıralı çıktısını görüntüleyin.
Kullanılan C# Konseptleri
Diziler (Arrays)
Döngüler (For, Foreach)
Kullanıcı Girişi (Console.ReadLine)
Dizi Manipülasyonu (Array.Sort(), Array.Reverse())
