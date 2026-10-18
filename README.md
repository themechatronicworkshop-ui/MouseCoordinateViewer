# Mouse Coordinate Viewer — Fare Koordinat Gösterici

Windows üzerinde fare imlecinin **X ve Y koordinatlarını anlık olarak gösteren**, küçük ve taşınabilir bir masaüstü uygulamasıdır.

## Özellikler

- Fare imlecinin X ve Y koordinatlarını canlı gösterir.
- Pencere diğer pencerelerin üzerinde kalır.
- Birincil ekranın çözünürlüğünü otomatik algılar.
- **Center on primary screen** düğmesiyle imleci ana ekranın merkezine taşır.
- Windows ekran ölçeklendirmesinde fiziksel piksel koordinatlarını kullanır.
- Kurulum veya yönetici izni gerektirmez.

## İndirme ve çalıştırma

1. Depodaki `MouseCoordinateViewer.exe` dosyasını indirin (dosya depoya eklendiğinde).
2. Windows bilgisayarınızda dosyayı çalıştırın.
3. Açılışta imleç ana ekranın merkezine taşınır.
4. Fareyi hareket ettirdikçe X ve Y koordinatları güncellenir.
5. Programı kapatmak için pencereyi kapatın.

**Not:** EXE henüz bu GitHub deposunda yayımlanmış değildir. Kaynak kodu indirip aşağıdaki yöntemle derleyebilirsiniz.

## Kaynak koddan derleme

1. Depoyu **Code → Download ZIP** seçeneğiyle indirin ve ZIP'i açın.
2. Windows'ta `build.cmd` dosyasını çalıştırın.
3. Derleme başarılı olursa `MouseCoordinateViewer.exe` oluşturulur.

Gereksinim: Windows ve .NET Framework 4.x C# derleyicisi. Derleme için Visual Studio zorunlu değildir; gerekli derleyicinin sistemde bulunması gerekir.

## Örnek

1920 × 1080 çözünürlüklü bir ana ekranda merkez yaklaşık **X: 960, Y: 540** koordinatıdır. 1280 × 1024 ekranda merkez **X: 640, Y: 512** olur. Birden fazla ekran kullanıldığında bazı koordinatlar negatif olabilir.

## Dosyalar

| Dosya | Açıklama |
|---|---|
| `MouseCoordinateViewer.cs` | C# uygulama kaynak kodu |
| `MouseCoordinateViewer.manifest` | Windows uygulama bildirimi ve DPI ayarı |
| `build.cmd` | Windows derleme betiği |
| `.gitignore` | Git tarafından yok sayılacak dosyalar |
| `README.md` | Türkçe proje tanıtımı ve kullanım kılavuzu |

## Test durumu

İngilizce arayüzlü sürümün derlendiği ve özgün sürümün imleç okuma/ekran merkezi testinden geçtiği bildirilmiştir. Arayüzün Windows üzerinde görsel doğrulaması yapılmamıştır. Bu depoda ayrıca otomatik test altyapısı bulunmamaktadır.

## Güvenlik ve davranış

Program başlangıçta ve merkezleme düğmesine basıldığında fare imlecini taşır. Fare tıklaması yapmaz, dosyaları değiştirmez ve yönetici izni istemez.

## Lisans

Bu depoda henüz bir lisans dosyası bulunmamaktadır. Kullanım, değiştirme ve yeniden dağıtım haklarını açıkça belirtmek için ayrıca bir lisans seçilmelidir.
