# 🛒 FoodMart Projesi

FoodMart, **ASP.NET Core 8.0** ve **MongoDB** ile geliştirilmiş, dinamik bir e-ticaret platformudur.  
Hem kullanıcı dostu bir web sitesi hem de yönetim için kapsamlı bir admin paneli içerir.

---

## 👩‍💻 Kullanıcı Arayüzü

- 💸 **Tüm Ürünler:** Ürün ve kategoriler ayrı olarak gösterilir.  
- 📈 **Uygun Fiyatlı Ürünler:** En uygun ürünler ana sayfada listelenir.  
- 📧 **İndirim Kodu Mail Gönderimi:** Kullanıcılar e-posta adreslerini girerek indirim kodu alabilir.  
  Mail gönderimi **MailKit** kütüphanesi ile güvenli ve hızlı şekilde sağlanır.

---
## 🔐 Admin Paneli Özellikleri

- 🔑 **Giriş/Çıkış:** Admin, kullanıcı adı ve şifreyle sisteme giriş yapabilir. 
- 📝 **Kategori Yönetimi:** Kategori ekleme, silme, güncelleme, listeleme.  
- 🛍️ **Ürün Yönetimi:** Ürünlerin eklenmesi, silinmesi, güncellenmesi.  
- 💰 **İndirim Yönetimi:** Ürün ve kategori bazında indirimler tanımlanabilir.

  ---

## 🛠️ Kullanılan Teknolojiler ve Yapılar


- 💻 **ASP.NET Core 8.0**: Microsoft’un modern, açık kaynaklı web uygulama framework’ü ve admin paneli bu altyapı ile geliştirildi. 
- 🍃 **MongoDB**: NoSQL, doküman tabanlı veritabanı. Ürün, kategori, satış ve kullanıcı verileri koleksiyon yapısıyla yönetildi. 
- 🔄 **AutoMapper**: Nesne-to-nesne dönüştürme kütüphanesi. DTO ve entity sınıfları arasındaki dönüşümler sadeleştirildi. 
- 📦 **DTO (Data Transfer Objects)**: Veri transferini optimize eden veri modeli. Katmanlar arası veri aktarımında kullanılarak güvenlik ve performans artırıldı. 
- ✉️ **MailKit**: SMTP protokolü ile e-posta gönderimi sağlayan kütüphane. Kullanıcılara indirim kodu otomatik olarak e-posta ile gönderildi. 
- 🌐 **ViewComponent**: Modüler yapı için Razor bileşenleri. Slider, öne çıkanlar, indirimli ürünler gibi alanlar bu yapı ile dinamikleştirildi. 
- 🗂️ **Session Management**: Oturum yönetimi mekanizması. Admin giriş/çıkış ve kullanıcı doğrulama işlemleri oturum üzerinden kontrol edildi. 

---
  
![görsel 1](/images/slider.png)
![görsel 2](/images/categories.png)
![görsel 4](/images/all-products.png)
![görsel 5](/images/subdiscounts.png)
![görsel 6](/images/lowprices-products.png)
![görsel 7](/images/send-mail.png)
![görsel 8](/images/footer.png)
![görsel 9](/images/footer2.png)
![mail](/images/customer-mail.png)
![görsel 10](/images/login.png)
![görsel 11](/images/register.png)
![görsel 12](/images/admin-category.png)
![görsel 13](/images/admin-add-category.png)
![görsel 14](/images/admin-product.png)
![görsel 15](/images/admin-update-product.png)
![görsel 16](/images/admin-discount.png)
![görsel 17](/images/admin-add-discount.png)
![görsel 17](/images/admin-update-discount.png)
![görsel 17](/images/admin-title.png)
![görsel 17](/images/admin-update-title.png)

---

✨ **Teşekkürler!** ✨
