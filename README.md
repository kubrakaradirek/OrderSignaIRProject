Projede ASP.NET Core 6.0 kullanılmış olup, vitrin ve yönetici panelleri bulunmaktadır. SignalR kütüphanesi, anlık bildirimler ve sepet gibi işlemler için kapsamlı bir şekilde kullanılmıştır. Restoran sistemine ait bir uygulama olan bu proje, sipariş yönetimini sağlar. Arka planda API kullanılmış olup, API yapısı kullanıcı arayüzü tarafında tüketilmiştir. Rezervasyon işlemleri için kullanıcılara e-posta gönderilmiştir. Anlık bildirimler ve sepet gibi işlemler için SignalR kullanılmıştır. N-tier mimarisi kullanılmıştır.

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

![Ekran görüntüsü 2024-05-16 002824](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/3b345322-677e-43a0-bdc7-c77589b7e98a)
![Ekran görüntüsü 2024-05-16 002839](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/90690cc6-d02a-4a6b-8bee-6de724a687b0)
![Ekran görüntüsü 2024-05-16 004046](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/3b7348a8-b3a8-4504-92da-d28acae85fab)
![Ekran görüntüsü 2024-05-16 003248](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/59c9350a-b2a4-4ac7-b5c8-4f181d5ea84c)
![Ekran görüntüsü 2024-05-16 003413](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/e132a48d-89ab-4258-a0b2-a4290086034d)
![Ekran görüntüsü 2024-05-16 003425](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/4f1283f2-89f0-431d-a4f6-9d9be7f217cf)
![Ekran görüntüsü 2024-05-16 002937](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/10c2158f-dc16-4c05-9006-85c3e86027a4)
![Ekran görüntüsü 2024-05-16 002846](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/2bcfa35b-70f6-4952-9c7b-6cb181524d9f)
![Ekran görüntüsü 2024-05-16 003510](https://github.com/kubrakaradirek/OrderSignaIRProject/assets/133059827/7ee7c493-0702-45f7-95b0-fea8905c8337)
