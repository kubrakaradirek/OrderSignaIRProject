Projede ASP.NET Core 6.0 kullanılmış olup, vitrin ve yönetici panelleri bulunmaktadır.Bu projeyi Murat Yücedağ'ın Udemy kursundaki "ASP.NET Core API SignalR ile QR kodlu sipariş yönetimi" kursunu tamamlayarak geliştirdim.  SignalR kütüphanesi, anlık bildirimler ve sepet gibi işlemler için kapsamlı bir şekilde kullanılmıştır. Restoran sistemine ait bir uygulama olan bu proje, sipariş yönetimini sağlar. Arka planda API kullanılmış olup, API yapısı kullanıcı arayüzü tarafında tüketilmiştir. Rezervasyon işlemleri için kullanıcılara e-posta gönderilmiştir. Anlık bildirimler ve sepet gibi işlemler için SignalR kullanılmıştır. N-tier mimarisi kullanılmıştır.

Projede bir restoranın anlık sipariş aldığı, müşterilerin QR koduyla sipariş verebildiği, anlık bildirimler ve istatistikleri içeren gerçek zamanlı verilerin tutulduğu bir yapı bulunmaktadır. Müşteriler, oturdukları masaya göre sepetlerine ürün ekleyebilir veya çıkarabilirler. Sepet onaylandığında, sipariş anlık olarak mutfak bölümüne iletilir.

SignalR, sadece bildirimlerde değil, aynı zamanda siparişlerin anlık olarak şefe iletilmesinde, istatistiklerin anlık olarak değişmesinde ve masaların anlık dolu-boş durumlarının gösterilmesinde kullanılmıştır. Veritabanı olarak MSSQL kullanılmıştır. Güvenlik işlemlerinde Identity kullanılmıştır.

## Kullanılan Teknolojiler:

-	ASP.NET Core 6.0

- SignalR

-	Entity Framework Core

- Bootstrap

- QR Code Generator

- SMTP Mail Service

- ASP.NET Identity

- AJAX

## Özellikler:

-	Müşterilerin yemek siparişi verebilmesi

-	Gerçek zamanlı sipariş güncellemeleri için SignalR entegrasyonu

-	Siparişlerin QR kodlarıyla verilebilmesi (Müşteriye gönderilir)

-	Yöneticiye siparişleri ve güncellemeler için e-posta bildirimleri

-	Kimlik doğrulama ve yetkilendirme için ASP.NET Identity sistemi

-	AJAX kullanarak asenkron veri alışverişi

-	Kullanıcıların profil bilgilerini güncelleme ve sipariş geçmişini görüntüleme

![Ekran görüntüsü 2024-05-26 192713](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/f7af0724-3686-4b4b-98eb-9852e7d36b0b)
![Ekran görüntüsü 2024-05-26 192738](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/3eb7f6bd-61c5-434f-9571-82b2b8d9d660)
![Ekran görüntüsü 2024-05-26 201030](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/da1fada7-d5f0-488f-8f26-9810b5488754)
![Ekran görüntüsü 2024-05-26 201058](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/d499e396-9527-4a78-a9c1-efadaf8702a4)
![Ekran görüntüsü 2024-05-26 201128](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/4b5fda73-07a4-44ec-b399-f7261131faff)
![Ekran görüntüsü 2024-05-26 201150](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/092695a6-6c31-416e-8f0a-a5071ed8f913)
![Ekran görüntüsü 2024-05-26 201206](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/d9adaf8f-bcc1-44ac-85ee-80742228868a)
![Ekran görüntüsü 2024-05-26 201224](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/9d089bee-fbd1-4dc2-bdd5-476281248546)
![Ekran görüntüsü 2024-05-26 201253](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/835a664d-2e2d-4178-8361-8c380422654d)
![Ekran görüntüsü 2024-05-26 201311](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/fc4908fd-7a08-4f8d-8a3a-20b655c5e4ce)
![Ekran görüntüsü 2024-05-26 201658](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/aa63d536-4a71-44f9-85b4-98889933018a)
![Ekran görüntüsü 2024-05-26 201750](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/d8fb8a21-2f48-4a40-ab76-86c6867713e2)
![Ekran görüntüsü 2024-05-26 201817](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/41dc89de-d2de-4775-9046-247e5c7e9310)![Ekran görüntüsü 2024-05-26 201832](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/73b96457-9944-460d-b8f5-10cf6c6b363c)
