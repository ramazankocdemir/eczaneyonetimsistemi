# Eczane Yönetim Sistemi (WinForms)

Eczane Yönetim Sistemi; ilaç kayıt/kabul, stok takibi ve barkod ile satış işlemlerini gerçekleştirmek için geliştirilmiş bir masaüstü uygulamasıdır. Uygulama C# WinForms ile geliştirilmiş olup veri erişimi için SQL Server LocalDB kullanır. Proje, katmanlı mimari yaklaşımıyla (Entities / Business / DataAccess) daha sürdürülebilir ve yönetilebilir bir yapı hedefler.

## Özellikler

- Barkod ile ilaç arama
- Satış işlemi (adet bazlı)
- Stok düşme kontrolü (stok yetersizse satış engellenir)
- Son kullanma tarihi kontrolü (tarihi geçmiş ürün satışı engellenir)
- Reçeteli / reçetesiz ilaç ayrımı ile dinamik satış tutarı hesaplama (OOP + Polimorfizm)

## Mimari ve Kullanılan Teknolojiler

- .NET (WinForms)
- SQL Server LocalDB
- Katmanlı Mimari
  - Entities: Varlık modelleri (ör. Ilac, DTO yapıları)
  - Business: İş kuralları ve hesaplamalar
  - DataAccess: Veritabanı işlemleri (Repository yaklaşımı)
- OOP Prensipleri
  - Kalıtım, kapsülleme, polimorfizm, soyutlama
- Tasarım Yaklaşımı
  - Factory Pattern: DTO üzerinden doğru ilaç tipinin üretilmesi (ör. reçeteli/reçetesiz)

## Ekranlar (Özet)

- Ana Panel: Modüllere erişim
- İlaç Kabul: Yeni ilaç kayıt/ekleme işlemleri
- Satış (FrmSatis): Barkod ile bulma, tutar hesaplama, stok düşme ve satış akışı

## Kurulum

### Gereksinimler

- Windows 10/11
- Visual Studio 2022 (önerilir)
- .NET (projede kullanılan hedef framework’e uygun sürüm)
- SQL Server Express LocalDB (Visual Studio ile birlikte gelir)

### Projeyi Çalıştırma

1. Depoyu klonlayın:
   - GitHub üzerinden repo bağlantısını kopyalayın ve Visual Studio ile açın veya terminalden klonlayın.

2. Visual Studio’da solution dosyasını (.sln) açın.

3. NuGet paketleri varsa geri yüklenmesini bekleyin:
   - Visual Studio otomatik restore yapar. Gerekirse:
     - Tools > NuGet Package Manager > Restore

4. Build alın:
   - Build > Rebuild Solution

5. Uygulamayı çalıştırın:
   - Start (F5)

## Veritabanı (LocalDB) Notu

Bu proje SQL Server LocalDB kullanır. Mevcut durumda veritabanını “script ile kurulum” şeklinde ayrıca paketlemedim. Dolayısıyla projeyi farklı bir bilgisayarda çalıştırırken şu durumlarla karşılaşabilirsiniz:

- Connection string, bilgisayara özgü bir dosya yolu (AttachDbFilename) içeriyorsa düzenlenmesi gerekebilir.
- LocalDB veritabanı dosyası (.mdf/.ldf) proje içinde/yanında konumlanmış olabilir.

Çalıştırma sırasında veritabanı bağlantı hatası alırsanız:
- App.config (veya Settings) içindeki connection string’i kontrol edin.
- LocalDB’nin kurulu olduğundan emin olun.
- Veritabanı dosyalarının projede bulunduğu yolu doğrulayın.

İlerleyen sürümlerde “Database” klasörü altında kurulum script’leri (CREATE TABLE / seed data) eklenerek taşınabilir kurulum desteklenebilir.

## Satış Akışı (Özet)

FrmSatis ekranında işlem sırası:
1. Barkod girilir ve “Bul” ile ilaç getirilir.
2. İsteğe bağlı olarak sigorta bilgisine göre “Fiyat Gör” ile satış tutarı hesaplanır.
3. “Satış Yap” ile:
   - Son kullanma tarihi kontrol edilir,
   - Stok yeterliliği kontrol edilerek stok düşülür,
   - İşlem başarılıysa ekran temizlenir.



## Katkı ve Geliştirme

Katkılar ve öneriler için issue/pull request açabilirsiniz. Proje bir ders/ödev ve geliştirme amaçlıdır; mimari iyileştirmeler (DB script, testler, hata yönetimi, logging) zamanla eklenebilir.


