Bu projede basit bir envanter sistemi geliştirdim.

![Ekran Görüntüsü (85)](https://github.com/Florianus04/UnityInventorySystem/assets/101597266/0dbefd7b-2a02-4a0b-8214-12e1193caffc)

Yukarıdaki görselde 2 tane kaydırmalı panel bulunmakta. Sağ taraftaki panel envanterimiz, sol taraftaki ise mağazayı temsil ediyor.
Her paneli temsil eden bir int dizimiz var bu dizilerin içinde itemlerin numaraları bulunuyor.
Envantere alınan itemler int olarak envanter dizisinde bulunuyor bu verileri kendinize göre alıp oyununuza entegre edebilirsiniz.

![Ekran görüntüsü 2024-05-18 153129](https://github.com/Florianus04/UnityInventorySystem/assets/101597266/2141466d-6457-47f8-9067-8d10d7384137)

Yukarıda temsili olarak oluşturduğum itemler bulunmaktadır.
İtemNo itemlerin numarasını tutar bu sayede hangi itemin nerde olduğunu kontrol edebilirsiniz.
Eğer kendi itemlerinizi oluşturursanız burdan her item için numara vermeniz gerekir.
EquipButton ise itemlerin hangi slotta bulunduğunu kontrol eder ve ona göre envantere taşıma veya çıkarma işlemini gerçekleştirir.

![Ekran görüntüsü 2024-05-18 152645](https://github.com/Florianus04/UnityInventorySystem/assets/101597266/b48feb69-37e4-471d-91da-af717f6c5b6e)

Yukarıdaki görselde 2 panelde de bulunan slotlar var bu slotlara ihtiyaca göre ekleme veya çıkarma yapabilirsiniz
Sistem çalışırken taşıma sırasında önce boş slot olup olmadığı kontrol edilir eğer boş slot bulunursa ilk müsait yere itemler yerleştirilir.
Şu an default olarak 5 mağaza slotu 3 envanter slotu vardır yani envantere 3 itemden fazlasını ekleyemezsiniz.

![Ekran görüntüsü 2024-05-18 152702](https://github.com/Florianus04/UnityInventorySystem/assets/101597266/e6a206a5-bd3d-48c6-a99b-c21d68af74cf)

Yukarıdaki görselde Item List kısmına itemlerinizi ItemNo sırasıyla ekleyin.
Store ve Inventory Transforms ise 2 panel için oluşturduğunuz slotları temsil eder.
En alttaki panellere ise mağaza ve envanter kaydırmalı panellerini bağlayın.

Kullanımı basittir istediğiniz veriler liste olarak otomatik tutulur koddan erişebilirsiniz. İyi çalışmalar.



