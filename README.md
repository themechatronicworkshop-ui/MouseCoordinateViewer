# Mouse Coordinate Viewer — Fare Koordinat Gösterici

🇹🇷 **Türkçe (Ana Dil)** | 🇬🇧 **[English documentation](README_EN.md)**

## Uygulama ekran görüntüsü

![Mouse Coordinate Viewer uygulama ekranı](1.png)


## Projenin amacı

**Mouse Coordinate Viewer**, Windows üzerinde fare imlecinin X ve Y koordinatlarını gerçek zamanlı gösteren, ekran koordinatlarına dayalı otomasyon çalışmalarını kolaylaştıran hafif bir yardımcı yazılımdır.

Özellikle sanal fare ve klavye kontrolü, otomatik tıklama, dosya ve klasör taşıma iş akışları, tekrarlanan masaüstü görevleri ve kullanıcı arayüzü testleri gibi projelerde **hedef noktaların koordinatlarını belirlemek** için kullanılabilir.

Program, geliştiricilerin tıklanacak düğmelerin, sürükleme başlangıç ve bitiş noktalarının ve ekran üzerindeki işlem alanlarının konumlarını tespit etmesine yardımcı olur. **Önemli:** Uygulama tek başına otomatik tıklama, klavye girişi veya dosya taşıma yapmaz; bu tür otomasyonları geliştirmek için koordinat bilgisi sağlar.

### Kullanım alanları

- **Sanal fare ve klavye otomasyonu:** Fare hareketi ve tıklama hedeflerinin koordinatlarını bulma.
- **Dosya ve klasör iş akışları:** Sürükle-bırak gibi ekran tabanlı işlemlerde başlangıç ve hedef noktalarını belirleme.
- **Masaüstü otomasyonu:** Tekrarlanan görevler için ekran üzerindeki kontrol noktalarını saptama.
- **Arayüz testleri:** Düğme, menü ve diğer ekran öğelerinin konumlarını inceleme.
- **Eğitim ve geliştirme:** Ekran koordinat sistemini öğrenme ve otomasyon prototipleri oluşturma.

**Teknik not:** Ekran çözünürlüğü, pencere konumu, ölçeklendirme ve çoklu monitör düzeni değiştiğinde koordinatlar da değişebilir. Sabit koordinatlarla çalışan otomasyonlarda bu koşullar göz önünde bulundurulmalıdır.

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
