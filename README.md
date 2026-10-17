# 🏨 Hotel RapidApi - Otel Arama ve Rezervasyon Uygulaması

Booking.com API'sini kullanarak kolay ve hızlı bir şekilde otel araması yapabileceğiniz, otel detaylarını görebileceğiniz modern bir web uygulaması.

## 📋 İçerik

- [Proje Özellikleri](#-proje-özellikleri)
- [Teknoloji Yığını](#-teknoloji-yığını)
- [Kurulum ve Başlangıç](#-kurulum-ve-başlangıç)
- [Proje Yapısı](#-proje-yapısı)
- [Özellikler](#-özellikler)
- [Ekran Görüntüleri](#-ekran-görüntüleri)
- [API Entegrasyonu](#-api-entegrasyonu)


---

## ✨ Proje Özellikleri

- **Kolay Otel Arama**: Şehir adı, tarih aralığı ve misafir sayısına göre otel arayın
- **Detaylı Otel Bilgileri**: Seçilen otelin kapsamlı ayrıntılarını görüntüleyin
- **Oda Mevcudiyeti**: Seçili tarihler için mevcut odaları ve fiyatları kontrol edin
- **Kullanıcı Yorumları**: Gerçek misafirlerin otellar hakkında yazdıkları yorumları ve puanları görün
- **Çok Dilli Destek**: Türkçe dil desteği ile tam yerelleştirme
- **Duyarlı Tasarım**: Mobil, tablet ve masaüstü cihazlarda mükemmel görüntüleme
- **Gerçek Zamanlı Veriler**: Booking.com'dan en güncel otel bilgilerini alın

---

## 🛠️ Teknoloji Yığını

| Teknoloji | Sürüm | Kullanım Amacı |
|-----------|-------|----------------|
| **.NET** | 8.0 | Ana framework |
| **ASP.NET Core** | 8.0 | Web framework |
| **MVC/Razor Pages** | - | View rendering |
| **C#** | 11+ | Backend programlama dili |
| **Newtonsoft.Json** | 13.0.4 | JSON serialization/deserialization |
| **RapidAPI** | - | Booking.com API erişimi |
| **Bootstrap** | - | Responsive UI tasarımı |

---

## 📥 Kurulum ve Başlangıç

### Kurulum Adımları

1. **Repository'yi klonlayın**
   ```bash
   git clone https://github.com/ComputerUni/Hotel-RapidApi.git
   cd Hotel-RapidApi
   ```

2. **Proje dizinine gidin**
   ```bash
   cd RapidApiHotel.Web
   ```

3. **NuGet paketlerini yükleyin**
   ```bash
   dotnet restore
   ```

4. **API Anahtarını Yapılandırın**

   `HotelController.cs` dosyasında aşağıdaki satırları bulun:
   ```csharp
   { "x-rapidapi-key", "YOUR_API_KEY_HERE" }
   { "x-rapidapi-host", "booking-com15.p.rapidapi.com" }
   ```

   Başlangıçta bu anahtarları kopyalayıp [RapidAPI](https://rapidapi.com) hesabınızdan aldığınız anahtarlar ile değiştirin.

5. **Uygulamayı çalıştırın**
   ```bash
   dotnet run
   ```

6. **Tarayıcıda açın**
   ```
   https://localhost:7000
   ```

---

## 📁 Proje Yapısı

```
RapidApiHotel.Web/
├── Controllers/
│   ├── HomeController.cs          # Ana sayfa ve hata yönetimi
│   └── HotelController.cs         # Otel arama ve detay işlemleri
├── Models/
│   ├── HotelListViewModel.cs      # Otel listesi veri modeli
│   ├── HotelDetailViewModel.cs    # Otel detayı veri modeli
│   ├── HotelRoomListWithAvailabilityViewModel.cs  # Oda mevcudiyeti modeli
│   ├── HotelReviewScoresViewModel.cs  # Yorum puanları modeli
│   ├── HotelReviewTipsViewModel.cs    # Kullanıcı yorumları modeli
│   ├── HotelDetailDescriptionAndInfoViewModel.cs  # Otel açıklaması modeli
│   └── ErrorViewModel.cs          # Hata sayfası modeli
├── Views/
│   ├── Hotel/
│   │   ├── Index.cshtml          # Otel arama sayfası
│   │   ├── Search.cshtml         # Arama sonuçları sayfası
│   │   └── Detail.cshtml         # Otel detay sayfası
│   ├── Home/
│   │   ├── Index.cshtml          # Ana sayfa
│   │   └── Privacy.cshtml        # Gizlilik politikası
│   └── Shared/
│       └── Default.cshtml        # Ortak layout dosyaları
├── wwwroot/
│   ├── css/                      # Stil dosyaları
│   ├── js/                       # JavaScript dosyaları
│   └── lib/                      # Harici kütüphaneler
├── Program.cs                     # Uygulama başlangıç noktası
└── appsettings.json              # Uygulama konfigürasyonu
```

---

## 🎯 Özellikler

### 1. Otel Arama
![Otel Arama]

Kullanıcılar aşağıdaki parametrelerle otel araması yapabilirler:
- 🔍 **Şehir Adı**: Aranacak şehrin adı
- 📅 **Varış Tarihi**: Otele giriş tarihi
- 📅 **Çıkış Tarihi**: Otelden çıkış tarihi
- 👤 **Yetişkin Sayısı**: Kaç yetişkin kalacağı
- 👶 **Çocuk Sayısı**: Kaç çocuk kalacağı
- 🛏️ **Oda Sayısı**: Kaç oda gerektiği
- 💱 **Döviz Kodu**: Fiyatlarının ne para biriminde gösterileceği

### 2. Arama Sonuçları
![Arama Sonuçları]

Arama sonuçları sayfasında:
- Belirlenen kriterlere uygun tüm oteller listelenir
- Her otel için kapasitesi, puanı ve fiyatı gösterilir
- Otele tıklayarak detaylı bilgileri görüntüleyebilirsiniz
- Sayfalama ile çok sayıda otel arasında kolayca gezinebilirsiniz

### 3. Otel Detayları
![Otel Detayları]

Otel detay sayfasında:
- 🏨 **Otel Bilgileri**: Otel adı, konumu, puanı ve genel bilgiler
- 📝 **Açıklama**: Otel hakkında ayrıntılı açıklama
- 🛏️ **Mevcut Odalar**: Seçili tarihler için mevcut odalar ve fiyatları
- ⭐ **Kullanıcı Yorumları**: Misafirlerin yazdığı gerçek yorumlar ve puanlar
- 🎯 **Otel Skoru**: Konfor, hijyen, tasarım vb. ayrıntılı puanlar
- 🛎️ **Tesisleri**: Otel tarafından sunulan tüm hizmetler
- 💰 **Fiyat Detayları**: Odaların günlü fiyatları ve toplam maliyeti

### 4. Oda Mevcudiyeti
![Oda Mevcudiyeti]

Oda listesinde:
- Oda tipi ve kapasitesi gösterilir
- Seçili tarih aralığı için mevcudiyet durumu gösterilir
- Oda başına fiyat ve toplam değer hesaplanır
- Oda özelliklerini detaylı olarak görebilirsiniz

### 5. Yorum ve Puanlar
![Yorum ve Puanlar]

Misafirlerin deneyimleri:
- İmajlaşan misafir yorumları ve deneyimleri
- İş ve macera seyahatçıları için ayrı puanlandırma

---

## 🔌 API Entegrasyonu

### RapidAPI Booking.com Uç Noktaları

Uygulama aşağıdaki RapidAPI endpoint'lerini kullanır:

#### 1. **Şehir/Destination Arama**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={city_name}
```
- Kullanıcının girdiği şehir adından destination ID'sini alır

#### 2. **Otel Arama**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels
?dest_id={dest_id}
&search_type=CITY
&arrival_date={arrival_date}
&departure_date={departure_date}
&adults={adults}
&children_age={children_age}
&room_qty={room_qty}
&currency_code={currency_code}
&page_number={page_number}
```
- Belirtilen kriterler ile otel listesini alır
- Sayfalanmış sonuçlar döndürür

#### 3. **Otel Detayları**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails
?hotel_id={hotel_id}
&arrival_date={arrival_date}
&departure_date={departure_date}
&adults={adults}
&children_age={children_age}
&room_qty={room_qty}
&currency_code={currency_code}
```
- Seçilen otel hakkında ayrıntılı bilgileri alır

#### 4. **Oda Mevcudiyeti**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/getRoomListWithAvailability
?hotel_id={hotel_id}
&arrival_date={arrival_date}
&departure_date={departure_date}
```
- Seçili tarihler için mevcut odaları ve fiyatlarını alır

#### 5. **Otel Puanları**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelReviewScores
?hotel_id={hotel_id}
```
- Otel hakkında misafir puanlarını alır

#### 6. **Otel Yorumları**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelReviews
?hotel_id={hotel_id}
&sort_option_id=sort_most_relevant
```
- Misafirlerin yazdığı yorumları alır

#### 7. **Otel Açıklaması ve Bilgileri**
```
GET https://booking-com15.p.rapidapi.com/api/v1/hotels/getDescriptionAndInfo
?hotel_id={hotel_id}
```
- Otel hakkında detaylı açıklama ve hizmetleri alır

### Header Bilgileri
Her istek için aşağıdaki header parametreleri gereklidir:

```http
x-rapidapi-key: YOUR_API_KEY
x-rapidapi-host: booking-com15.p.rapidapi.com
```

---

## 📸 Ekran Görüntüleri

![Ekran görüntüleri-1](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200057.png)

![Ekran görüntüleri-2](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200108.png)

![Ekran görüntüleri-3](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200119.png)

![Ekran görüntüleri-4](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200221.png)

![Ekran görüntüleri-5](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200231.png)

![Ekran görüntüleri-6](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200245.png)

![Ekran görüntüleri-7](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200642.png)

![Ekran görüntüleri-8](screenshots/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-10-17%20200959.png)

---

## 📝 Dosya Açıklamaları

### Controllers Katmanı

#### **HotelController.cs**
Otel arama ve detay işlemlerini yönetir:
- `Index()`: Otel arama formunu gösterir (GET ve POST)
- `Search()`: Arama kriterlerine göre otel listesini alır
- `Detail()`: Seçilen otel'in detaylı bilgilerini gösterir
- `GetDestinationIdAsync()`: Şehir adından destination ID'sini çeker

### Models Katmanı

Her model, Booking.com API'sinden dönen JSON verisini C# nesnelerine dönüştürmek için kullanılır.

- **HotelListViewModel**: Arama sonuçlarındaki otel listesini temsil eder
- **HotelDetailViewModel**: Otel detay sayfasının tüm bilgilerini tutar
- **HotelRoomListWithAvailabilityViewModel**: Mevcut odaları ve fiyatları içerir
- **HotelReviewScoresViewModel**: Otel puanlarını tutar
- **HotelReviewTipsViewModel**: Misafirlerin yorumlarını içerir
- **HotelDetailDescriptionAndInfoViewModel**: Otel açıklaması ve hizmetlerini tutar

### Views Katmanı

#### **Hotel/Index.cshtml**
Otel arama işlemi için form içerir. Kullanıcı form doldurduktan sonra POST işlemiyle arama yapılır.

#### **Hotel/Search.cshtml**
Arama sonuçlarını liste olarak gösterir. Sayfalamanın yönetildiği bulunduğu sayfadır.

#### **Hotel/Detail.cshtml**
Seçilen otel hakkındaki tüm bilgileri gösterir:
- Otel temel bilgileri
- Mevcut odalar
- Misafirlerin puanları
- Gerçek yorumlar
- Otel açıklaması

---

## 🔄 Uygulama Akışı

```
1. Kullanıcı Ana Sayfaya Gelir
		   ↓
2. Hotel/Index Sayfasında Arama Parametrelerini Girer
		   ↓
3. HotelController.Index() (POST) Çalışır
		   ↓
4. GetDestinationIdAsync() ile Şehir ID'sini Alır
		   ↓
5. Hotel/Search Sayfasına Yönlendirme Yapılır
		   ↓
6. HotelController.Search() API'den Otel Listesini Çeker
		   ↓
7. Hotel/Search.cshtml Sonuçları Gösterir
		   ↓
8. Kullanıcı Bir Oteli Seçer
		   ↓
9. HotelController.Detail() Çalışır
		   ↓
10. 4 Farklı API Endpoint'i Paralel Çağırır:
	- Hotel Details
	- Available Rooms
	- Review Scores
	- Hotel Reviews
	↓
11. Hotel/Detail.cshtml Tüm Bilgileri Gösterir
```

---

## 🚀 Performans Optimizasyonları

- **Paralel API Çağrıları**: Detail sayfasındaki verileri almak için `Task.WhenAll()` kullanılır
- **Async/Await**: Tüm HTTP işlemleri asenkron olarak gerçekleştirilir
- **Sayfalama**: Arama sonuçları sayfalanarak sınırlı veri yüklenir
- **JSON Deserialization**: Newtonsoft.Json kütüphanesi kullanılır

---

## 📚 Ek Kaynaklar
- [Booking.com API Belgeleri](https://rapidapi.com/booking-com15/api/booking-com15/docs)

---

## 🌟 Teşekkürler

Bu projeyi faydalı bulduysanız lütfen bize bir ⭐ verin!

---

<div align="center">

Made with ❤️ by [Computer Uni](https://github.com/ComputerUni)

</div>
