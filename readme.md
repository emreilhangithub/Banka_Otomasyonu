# Banka_Otomasyonu

## Proje Tanıtımı 

*Bu projede **.Net** kullanarak DevExpress ile banka otomasyonu oluşturdum. CRUD operasyonları için ado.net disconnect mimari kullanıldım.*

# Database Yedeği #
Databse kısmına aşşağıdan ulaşıp kendinize yükleyebilirsiniz. https://github.com/emreilhangithub/Banka_Otomasyonu/tree/master/database

# Proje İçeriği #

### Müşteri Giriş Ekranı
Müşteri numarası girilerek giriş yapılır.
![MusteriGiris](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriGiris.png)

### Müşteri Paneli
Müşteri giriş yaptıktan sonra işlemler yapabileceği müşteri paneli açılır.
![MusteriPaneli](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriPaneli.png)

### Müşteri Para Çekme Ekranı
Müşteri para çekme ekranından hesap numarasını seçtikten sonra hesap bakiyesi gelir ve hesabındaki bakiye kadar para çekebilir.  
![MusteriParaCek](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriParaCek.png)

### Müşteri Para Çekme Limit
Müşteri para çekme limiti günde en fazla 750 tl dir bu parayı geçerse uyarı verecektir.  
![MusteriParaCekLimit](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriParaCekLimit.png)

### Müşteri Para Yatırma Ekranı
Müşteri para yatırma ekranından istediği hesabını seçerek para yatırma işlemi gerçekleştirir.
Yatırılan tutar kadar bakiyesi artacaktır.


![MusteriParaYatir](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriParaYatir.png)

### Müşteri Havale Yapma Ekranı
1)Müşteri havale yapma ekranından gönreceği hesabı seçer 2)Paranın yatırılacağı hesap numarasını girer 3)Aktarmak istediği tutarı girer.
Havale et butonuna basınca hesap gerçekteden var ise vede bakiye yeterli ise bu havale işlemi gerçekleştirilir.
4)Havale tutarı kadar miktar kendi hesabının bakiyesinden eksilir 5) Gönderdiği kişinin bakiyesi artacaktır


![MusteriHavale](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriHavale.png)

### Müşteri Hesap Özeti Ekranı
1)Seçilen bir hesap için belirtilen tarih aralığında hesap özeti görüntülenecektir. Çekilen, yatırılan, havale yapılmışsa kime yapıldığı ve miktarı, 
başka bir hesaptan havale para geldiyse kimden geldiği ve miktarı gibi bilgiler ve bu işlemlerin tarihleri görütüleniyor.


![MusteriHesapOzet](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriHesapOzet.png)

### Müşteri Döviz Kuru Ekranı
1)Müşteri kur hesaplarını bu ekrandan yapacak şuanlık günlük dövüz kurlarını çekmedim talep olmadığı için.
![MusteriDovizKuru](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriDovizKuru.png)

### Kullanıcı Giriş Ekranı
Kullanıcı bilgilerini doldurarak giriş yapabilir.
![KullaniciGiris](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciGiris.png)

### Kullanici Şifre Unuttum Ekranı
Kullanıcı giriş yaparken şifresini unutursa şifre mi unuttum butonuna bastıktan sonra Kullanıcı sistemde kayıtlı mail adresini yazar.
![KullaniciSifremiUnuttum](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciSifremiUnuttum.png)
Kullanının şifresi kayıtlı mail adresine gider.
![KullaniciSifremiUnuttumMail](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciSifremiUnuttumMail.png)
Örnek gelen bir şifre maili
![KullaniciSifremiUnuttumMailGeldi](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciSifremiUnuttumMailGeldi.png)

### Kullanici Paneli
Kullanıcı giriş yaptıktan sonra işlemler yapabileceği kullanıcı paneli açılır.
![KullaniciPaneli](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciPaneli.png)

### Kullanici Ekleme
Yeni kullanıcı eklemek için oluşturulan ekrandır.
![KullaniciEkle](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/KullaniciEkle.png)

### Hesap Açma
Yeni hesap açmayı sağlar sistemde aynı hesap numarası var ise hata verir.
![HesapAc](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/HesapAc.png)

### Hesaplarını Getir
Kullanıcı müşteri numarasını yazdıktan sonra sistemde kayıtlı hesaplarını getirir. 
![HesapGetir](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/HesapGetir.png)

### Hesap Kapama
Kullanıcı hesabını kapatmaya yarar. Burada hesap kapatabilmek için hesabında para olmaması gerekmektedir yani bakiye 0 olması gerekiyor.
![HesapSil](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/HesapSil.png)

### Hesap Ekleme-Güncelleme
Kullanıcının yeni müşteri eklemesini sağlar ve var olan müşteriyi güncellemeyi sağlar.
![MusteriEkleGuncelle](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/MusteriEkleGuncelle.png)

### İşlem Türü Ekleme
Kullanıcının yeni işlem türü eklemesini sağlar. Örnek ibana para gönderme gibi.
![IslemTuruEkle](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/IslemTuruEkle.png)

### İşlem Türü Silme
Kullanıcının var olan işlem türlerini silmesini sağlar. Örnek para çekmeyi silebilir (işlem türü tablosundan)
![IslemTuruSil](https://github.com/emreilhangithub/Banka_Otomasyonu/blob/master/images/IslemTuruSil.png)


```.NET``` ```C#``` ```MSSQL```  ```DevExpress``` ```Software``` ```Computer``` ```Programmer``` 
