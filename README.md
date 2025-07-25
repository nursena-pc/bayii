#  Dergi ve Gazete Aboneliği Yönetim Sistemi

Bu proje, bir gazete ve dergi bayisinin abone işlemlerini kolaylaştırmak amacıyla **Windows Forms** platformunda geliştirilmiş bir **abonelik yönetim sistemidir**. Sistem, SQL Server tabanlı ilişkisel veritabanı yapısı, kullanıcı rolleri, gelişmiş sorgulama ve veri güvenliği özellikleri ile kurumsal kullanım için uygundur.

##  Proje Özeti
- Platform: **Windows Forms (C#)**
- Veritabanı: **Microsoft SQL Server**

##  Özellikler

###  Veritabanı Tasarımı
- **İlişkisel veri modeli**: Abone, Yayın, Abonelik ve Ödeme tabloları
- **ER Diyagramı**: İlişkiler ve veri akışı modellemesi
- **Veri tutarlılığı**: `FOR` ve `INSTEAD OF` trigger'lar ile kayıt güvenliği
- **Silinmiş kayıt arşivi**: Veri kaybı yaşanmadan silinen kayıtlar ayrı tabloda tutulur

###  Dinamik Raporlama
- Kullanıcılar yayın adı, fiyat gibi kriterlere göre rapor oluşturabilir
- Tüm sorgular `Stored Procedure` üzerinden gerçekleştirilir
- Rapor çıktıları **PDF formatında dışa aktarılabilir**

###  Kullanıcı Giriş ve Yetkilendirme
- Giriş ekranı ile **kimlik doğrulama**
- Role-based access (RBAC):  
  - `Admin`: Tüm veri işlemleri  
  - `Kullanıcı`: Sadece sorgulama ve görüntüleme
- Gelişmiş yetkilendirme ile veri güvenliği sağlanır

### 📤 Veri Aktarımı (Import / Export)
- CSV ve Excel formatında veri aktarımı (içe / dışa)
- Esnek veri entegrasyonu sayesinde kolay veri yönetimi

### 💾 Yedekleme ve Kurtarma Modülü
- Veritabanı tek tıklama ile **yedeklenebilir**
- Geri yükleme işlemi kullanıcı dostu arayüz üzerinden gerçekleştirilir

##  Kullanılan Yapılar ve Teknolojiler

| Alan | Teknoloji |
|------|-----------|
| Uygulama Arayüzü | Windows Forms (C# .NET) |
| Veritabanı | Microsoft SQL Server |
| Sorgular & Logic | Stored Procedures, Trigger’lar |
| Yetkilendirme | Rol bazlı giriş sistemi (Admin / Kullanıcı) |
| Raporlama | SQL Query + PDF Export |
| Veri Aktarımı | CSV, Excel (Import / Export) |
| Yedekleme | Otomatik yedek alma / geri yükleme modülü |

##  Geliştirilen Modüller
- [x] Abone Yönetimi
- [x] Yayın ve Kategori Yönetimi
- [x] Abonelik Takibi
- [x] Ödeme Kayıtları
- [x] Dinamik Raporlama
- [x] Giriş / Yetkilendirme Sistemi
- [x] Trigger ile veri güvenliği
- [x] Veri Aktarma / Yedekleme

## 🛡 Güvenlik ve Stabilite
- Silme işlemleri doğrudan değil, "Silinmiş Kayıtlar" tablosuna arşivlenir
- Sistem yedekleme ile veri kayıplarına karşı koruma altındadır
- Role-based yetkilendirme ile veri erişimi kontrol altındadır

---

 Bu proje; kurumsal abonelik sistemleri, veri yönetimi ve raporlama sistemleri geliştirmek isteyen yazılımcılar için örnek teşkil edebilir. Hem veri güvenliği hem de kullanıcı deneyimi açısından profesyonel düzeyde tasarlanmıştır.

---
# Ekran Görüntüleri
---
## kullanıcı giriş ekranları
<img width="537" height="642" alt="Ekran görüntüsü 2024-12-11 045304" src="https://github.com/user-attachments/assets/0ea3b043-7b30-416a-be94-0884db748520" />
<img width="532" height="637" alt="Ekran görüntüsü 2024-12-11 045325" src="https://github.com/user-attachments/assets/382b7276-256c-444d-bf92-65df3449835b" />
<img width="974" height="555" alt="Ekran görüntüsü 2024-12-11 045548" src="https://github.com/user-attachments/assets/af5b7318-fd9b-4fff-9fa9-73d9738bb560" />

## kullanıcı ana ekranı
<img width="1025" height="539" alt="Ekran görüntüsü 2024-12-11 045601" src="https://github.com/user-attachments/assets/0c6a366b-540d-4994-9dd7-550762692db7" />

## yayınlar, pdf, filtreleme (ortak) ekranı
<img width="745" height="490" alt="Ekran görüntüsü 2024-12-11 045716" src="https://github.com/user-attachments/assets/54694ce7-d816-4de8-9d86-92643a9c3d76" />
<img width="1807" height="936" alt="Ekran görüntüsü 2024-12-11 045910" src="https://github.com/user-attachments/assets/bc023d57-3c01-4b6f-b6b8-e110343c3fef" />
<img width="1919" height="1011" alt="Ekran görüntüsü 2024-12-11 050055" src="https://github.com/user-attachments/assets/baf49670-8997-40fc-ba25-4fe23329cedd" />
<img width="1795" height="873" alt="Ekran görüntüsü 2024-12-11 050116" src="https://github.com/user-attachments/assets/6c0d0994-4fe0-43d0-aad1-a3ceb0c076dd" />
<img width="745" height="481" alt="Ekran görüntüsü 2024-12-11 050136" src="https://github.com/user-attachments/assets/a9e4b5fe-8eb9-40b2-8db0-6e0d74bca9ea" />

## sepete ekleme ve ödeme (ortak) ekranları
<img width="739" height="482" alt="Ekran görüntüsü 2024-12-11 050150" src="https://github.com/user-attachments/assets/2ac6d5ee-d0b2-46c4-9fe5-f6a24bf7f328" />
<img width="746" height="486" alt="Ekran görüntüsü 2024-12-11 050211" src="https://github.com/user-attachments/assets/628a04a1-f019-465e-af0b-174fa1535621" />
<img width="743" height="483" alt="Ekran görüntüsü 2024-12-11 050238" src="https://github.com/user-attachments/assets/5083e856-8708-4701-88a4-c0093d01a6ce" />
<img width="737" height="482" alt="Ekran görüntüsü 2024-12-11 050249" src="https://github.com/user-attachments/assets/e56d2a45-750a-4f63-9483-1bc3d44c0dfd" />
<img width="743" height="489" alt="Ekran görüntüsü 2024-12-11 050437" src="https://github.com/user-attachments/assets/33abadd7-b886-414b-a9b9-8b2f46b20b72" />

## kullanıcı abonelik sorgulama ekranı
<img width="1083" height="501" alt="Ekran görüntüsü 2024-12-11 050502" src="https://github.com/user-attachments/assets/9c075c61-e818-46f4-bacc-30190da37d8a" />
<img width="1161" height="522" alt="Ekran görüntüsü 2024-12-11 050525" src="https://github.com/user-attachments/assets/c2bbcd1e-a2af-406c-b1d8-0afb8f0307a0" />
<img width="1090" height="521" alt="Ekran görüntüsü 2024-12-11 050537" src="https://github.com/user-attachments/assets/d2db82b9-b746-4e73-8277-29baab8c14a2" />

# admin paneli
---
## giriş ekranı
<img width="533" height="639" alt="Ekran görüntüsü 2024-12-11 050620" src="https://github.com/user-attachments/assets/d5ea7615-b6bc-4063-a9bb-e5dec7ee1a7f" />
<img width="524" height="631" alt="Ekran görüntüsü 2024-12-11 050626" src="https://github.com/user-attachments/assets/d495fb65-a95f-4f95-930c-a5a350ca25ca" />

## admin ana ekranı
<img width="1352" height="536" alt="Ekran görüntüsü 2024-12-11 050957" src="https://github.com/user-attachments/assets/10d43ee6-f77e-43af-aa4b-d83c39b5ebcd" />

## abone ekleme, güncelleme ve silme ekranları
<img width="956" height="533" alt="Ekran görüntüsü 2024-12-11 051456" src="https://github.com/user-attachments/assets/7ecbbbcd-f609-4344-928f-d45d57b52b64" />
<img width="953" height="539" alt="Ekran görüntüsü 2024-12-11 051615" src="https://github.com/user-attachments/assets/b2c53959-2adc-416f-9726-e7cf87478d0e" />
<img width="949" height="533" alt="Ekran görüntüsü 2024-12-11 051710" src="https://github.com/user-attachments/assets/7bac2385-9ae2-461a-80a1-27399051e8ad" />
<img width="951" height="538" alt="Ekran görüntüsü 2024-12-11 051739" src="https://github.com/user-attachments/assets/01076be4-2487-4518-a6a7-655f18f82222" />

## abone bilgilerini csv uzantısı ile dışarı aktarım
<img width="1850" height="654" alt="Ekran görüntüsü 2024-12-11 051841" src="https://github.com/user-attachments/assets/cef4aa3b-c12b-403a-95b8-1137bf50922d" />
<img width="855" height="536" alt="Ekran görüntüsü 2024-12-11 051904" src="https://github.com/user-attachments/assets/e41045cb-645a-44d5-b0f5-4ff894fbe477" />

## abonelikleri görüntüleme
<img width="1301" height="574" alt="Ekran görüntüsü 2024-12-11 052328" src="https://github.com/user-attachments/assets/2989f60d-8871-4adf-b64f-9c1fea918e28" />
<img width="1299" height="570" alt="Ekran görüntüsü 2024-12-11 052339" src="https://github.com/user-attachments/assets/56ab3009-ba03-4f1f-99db-8a4bd4aff7fa" />
<img width="1261" height="558" alt="Ekran görüntüsü 2024-12-11 052358" src="https://github.com/user-attachments/assets/7248970b-e016-42ac-b880-27cd6acaac6c" />

## yayın ekleme, silme ve güncelleme ekranları
<img width="1321" height="579" alt="Ekran görüntüsü 2024-12-11 052532" src="https://github.com/user-attachments/assets/13d53641-f6e6-4b1d-90f9-7ffd6e5e87e1" />
<img width="1343" height="593" alt="Ekran görüntüsü 2024-12-11 052658" src="https://github.com/user-attachments/assets/30a79cf0-9626-42b2-b628-7c9006d483de" />
<img width="1361" height="584" alt="Ekran görüntüsü 2024-12-11 052704" src="https://github.com/user-attachments/assets/13d5a240-0c4e-4953-b1bd-6dd17966c99d" />
<img width="1346" height="578" alt="Ekran görüntüsü 2024-12-11 052841" src="https://github.com/user-attachments/assets/d1effcbf-6def-468d-b97c-48f86daff7bf" />
<img width="1326" height="556" alt="Ekran görüntüsü 2024-12-11 053038" src="https://github.com/user-attachments/assets/f1f90a4c-9682-4a60-9b75-0dd1324961c8" />


## veritabanı yedekleme ve yedektön dönme ekranları
<img width="1350" height="551" alt="Ekran görüntüsü 2024-12-11 053021" src="https://github.com/user-attachments/assets/d5b74352-c3f9-4139-afb7-2bab9678e68e" />
<img width="1326" height="556" alt="Ekran görüntüsü 2024-12-11 053038" src="https://github.com/user-attachments/assets/3688c89d-8135-4a7f-bc7f-c7f88c5e383b" />
<img width="1338" height="573" alt="Ekran görüntüsü 2024-12-11 053048" src="https://github.com/user-attachments/assets/f75d4b75-9689-44e6-a73b-dd991523ec49" />
<img width="1359" height="571" alt="Ekran görüntüsü 2024-12-11 053111" src="https://github.com/user-attachments/assets/1da6c4a1-981e-4259-bcea-785b424a9513" />








