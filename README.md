Teknoloji Mağazası Ürün Yönetimi
Bu proje, bir teknoloji mağazasında telefon ve bilgisayar kayıtlarını yönetmek için oluşturulmuş bir konsol uygulamasıdır. Proje, nesne yönelimli programlama (OOP) prensipleri olan inheritance, encapsulation, polymorphism ve abstraction konseptlerini içermektedir.

Özellikler
Inheritance (Miras): BaseMakine sınıfından Telefon ve Bilgisayar sınıfları türetilmiştir.
Encapsulation (Kapsülleme): Bilgisayar sınıfında UsbGirisSayisi özelliği 2 veya 4 olarak sınırlandırılmıştır; aksi halde varsayılan değer atanır.
Polymorphism (Çok Biçimlilik): BilgileriYazdir() metodu, türetilen sınıflarda ezilerek (override) farklı işlevler eklenmiştir.
Abstraction (Soyutlama): UrunAdiGetir() metodu BaseMakine sınıfında soyutlanmış ve türetilen sınıflarda özelleştirilmiştir.
Üretim tarihi, nesne oluşturulurken otomatik olarak atanır.
Kullanıcı, telefon veya bilgisayar oluşturabilir, bilgilerini girdikten sonra detayları görebilir.
Program Akışı
Kullanıcıya telefon üretmek için 1, bilgisayar üretmek için 2'ye basması gerektiği sorulur.
Kullanıcıdan ürün bilgileri alınır:
Telefon: Ad, seri numarası, açıklama, işletim sistemi, TR lisans durumu.
Bilgisayar: Ad, seri numarası, açıklama, işletim sistemi, USB giriş sayısı, Bluetooth durumu.
Giriş yapılan bilgilere göre bir nesne oluşturulur ve ekranda detaylar yazdırılır.
Kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur.
Evet denirse program yeniden başlar; Hayır denirse program sonlandırılır.
Kullanılan Teknolojiler
C#: Projenin geliştirme dili.
.NET Core: Konsol uygulamasını çalıştırmak için kullanılmıştır.
