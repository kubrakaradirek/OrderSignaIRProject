This project was developed using **ASP.NET Core 6.0** and includes both a storefront and an admin panel. I developed it by completing Murat Yücedağ's Udemy course **“ASP.NET Core API with SignalR for QR Code-Based Order Management.”** The **SignalR** library was extensively used for real-time notifications and cart operations.

The project is a restaurant system application that manages orders. The backend is implemented with an API, which is consumed by the user interface. Email notifications are sent to users for reservation operations. **SignalR** is used for real-time notifications and cart functionality, and the project follows an **N-tier architecture**.

The system allows a restaurant to receive real-time orders, where customers can place orders via QR codes. Real-time data, including notifications and statistics, is maintained. Customers can add or remove items from their cart based on the table they are seated at. Once the cart is confirmed, the order is sent instantly to the kitchen.

SignalR is used not only for notifications but also for instantly sending orders to the chef, updating statistics in real time, and displaying the current occupancy status of tables. **MSSQL** is used as the database, and **Identity** is used for security and authentication.


## Used Technology

-	ASP.NET Core 6.0

- SignalR

-	Entity Framework Core

- Bootstrap

- QR Code Generator

- SMTP Mail Service

- ASP.NET Identity

- AJAX

## Features:

-Allows customers to place food orders

-SignalR integration for real-time order updates

-Orders can be placed using QR codes (sent to the customer)

-Email notifications for the admin regarding orders and updates

-ASP.NET Identity for authentication and authorization

-Asynchronous data exchange using AJAX

-Users can update profile information and view order history

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
