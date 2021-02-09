using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istanbulWeb.Models;

namespace istanbulWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<ReadMore> haberler = new List<ReadMore>
            {
                new ReadMore(){ResimYolu="../iwpProje/covid.jpg",
                    Baslik="Covid-19",
                    Paragraf="COVID-19 verileri resmi kanallardan ve ayrıntılı olarak verilmelidir! Klinik ve radyolojik olarak COVID-19 tanısı alan hastalar aksi kanıtlanıncaya kadar COVID-19 kabul edilerek gerekli önlemler alınmalıdır!TC Sağlık Bakanllığının Covid-19 Bilgilendirme Sayfasına gitmek için butona tıklayın.",
                    Link="https://covid19.saglik.gov.tr/"},
                new ReadMore(){ResimYolu="../iwpProje/ibb.png",Baslik="İstanbul Büyükşehir Belediyesi",Paragraf="İstanbul Büyükşehir Belediyesinin resmi sitesine gitmek için tıklayın.",Link="https://www.ibb.istanbul/"},
                new ReadMore(){ResimYolu="../iwpProje/hava.jpg",Baslik="Hava Durumu",Paragraf="İstanbul İçin Detaylı Hava Durumu Tahminini Görmek için tıklayın.",Link="https://www.mgm.gov.tr/tahmin/il-ve-ilceler.aspx?il=Istanbul"},
                new ReadMore(){ResimYolu="../iwpProje/iett.jpg",Baslik="İETT",Paragraf="Otobüs Saatlerinizi öğrenmek için tıklayın.",Link="https://www.iett.istanbul/"}

            };
            return View(haberler);
        }
        public ActionResult Giris()
        {

            return View();
        }
        public ActionResult Data()
        {
            return View();
        }
        public ActionResult Egitim()
        {

            List<Read> read = new List<Read>
            {
            new Read(){ResimYolu = "../iwpProje/Gurak1.jpg",
            Baslik = "Eğitim",
            Paragraf = "Elimizdeki verilere bakıldığında okuma yazma bilen kişi sayının yeterli olmadığını görmekteyiz. Özellikle okuma yazma bilen kadınların erkeklere göre azınlıkta olduğu görülüyor. Oysa ki kadın eğitimi ile ilgili yapılan çalışmaların çoğunda, kadın eğitiminin erkek eğitiminden daha önemli olduğu vurgulanmaktadır.Çünkü bir kadının eğitilmesi demek aynı zamanda aile içerisinde baba da dahil diğer çocukların görgülerinin artırılması demektir.Annenin daha uzun süreli bir eğitim düzeyine sahip olması aile içerisinde hem erkek hem de kız çocuğunun daha uzun süreli bir eğitimden geçirilmesinin imkanlarını yaratır." ,
            Paragraf2="Kadınlarına gerekli eğitim imkanlarını hazırlamayan,öğretim sürelerini kısa tutan toplumlarda kadınların yetkin ve toplumsal saygınlığı olan meslekleri elde etmesi oldukça zor olacaktır.Bunun sonucunda bu tür toplumlarda “Kültürel Sermaye” birikiminin az olmasını sağlayacak ve aile içerisinde çocuğun olumlu şekilde sosyalleşmesini,okul öncesi bir takım bilgi ve beceriye sahip olmasını,öğrenmeye hazır bulunuşluk düzeyini olumsuz şekilde etkileyecektir. Bu yüzden eğitime önem verilmelidir özellikle de kız çocuklarının eğitimine.",
            Kaynak = "https://dergipark.org.tr/tr/download/article-file/118029"
            }

            };

            return View(read);
        }
        public ActionResult Ulasim()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/istanbul-trafigi.jpg",Baslik="İstanbul Trafiği",Paragraf=" İstanbul yaklaşık 17 milyon nüfusuyla Türkiye’ en kalabalık olan ilidir. İki kıta olan Asya ve Avrupa’yı birbirine bağlaması"+
                "ve balkanlara bu şehrimiz üzerinden geçiş sağlanması ile tarih boyunca önemini korumuştur. Tarih çağlar boyunca birçok uygarlığa"+
                "ev sahipliği yapan İstanbul, hep gözde şehir olmuştur. Çok fazla imparatorluk’ ada başkentlik yapmıştır. Şehirin önemi böylece artmakta"+
                " çünkü, tarihi kalıntılar ve gezilecek yerlerin çok olması turist nufüsuda artırmaktadır. Yaz, kış demeden gelen turistler özellikle, Ayasofya"+
                " camii ve Sultan Ahmet Camiini gezmektedir. Yurt içi ve yurt dışı turist akımını da düşünürsek inanılmaz bir insan kalabalığı karşımıza çıkmaktadır.",
                Paragraf2= "Nüfusun bu kadar kalabalık olması bir çok problemi de beraberinde getirmektedir. İstanbul’ un en büyük sorunu trafik olarak karşımıza çıkmaktadır."+
                " İstanbul trafiğine her geçen bir önlem daha alınmasına rağmen bu sorun bir türlü çözülememektedir. İstanbul şehir içi ulaşımda bir çok tramvay, metro,"+
                " İETT ( İstanbul Elektrikli Tramvay ve Tünel işletmeleri), metrobüs, ido ve vapur seferleri yapılmakta amaç herkesin hızlı ve güvenli bir şekilde ulaşımını"+
                " sağlamaktır. Saymış olduğumuz ulaşım araçlarından birinin aksaması tüm trafiği alt üst etmektedir. Sabahın erken saatlerinde başlayan İstanbul trafiği"+
                " öğlen biraz nefes alsada akşam iş çıkış saatlerinde herkesin bu trafiğe yakalanmasına sebep olmaktadır. Özellikle şahsi taksilerle ulaşımını gerçekleştirenler"+
                " saatlerce yolda beklemek zorunda kaldıkları görülmektedir.",
                    Kaynak="https://www.bilgicik.com/yazi/istanbulda-trafik-problemi/"}

            };
            return View(read);
        }
        public ActionResult Cevre()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/eniro.jpg",
                    Baslik="Doğamızı Koruyalım!",Paragraf="Doğaya bıraktığımız atıklar yüzünden yakında Dünyamız yaşanmayacak hale gelecek. Yukarıda ki verilerde de gördüğünüz üzeri istanbulda da yılda doğaya bırakılan atık atık miktarı çok fazla. Özelliklede denizlere atılan atıklar yüzünden denizler artık girilemeyecek durumda ve bu atıklar yüzünden deniz canlıları da zarar görmektedir.Bu şekilde devam ederse malesef dünya yaşanmaycak hale gelecek bunun olmaması için herkesin bireysel olarak yapabileceği bazı şeyler:",
                Paragraf2=" Tüketirken tekrar düşünülmeli, gereksiz tüketimden kaçınılmalıdır." +
                " Tükettiğimiz ürünleri tercih ederken çevresel etkilerine dikkat edilmeli ve seçimler bilinçli bir şekilde yapılmalıdır." +
                " Çöpler, çöp poşetinin ağzını sıkıca bağlandıktan sonra çöp kutusuna atılmalıdır.Ormanlar korunmalıdır.Ağaçlara zarar verilmemelidir." +
                " Çimlerin üzerinde ateş yakılmamalıdır.Hayvanlara zarar vermekten kaçınılmalıdır." +
                " Denizler kirletilmemelidir.Evcil hayvanların atıkları temizlenmelidir." +
                " Çevremiz sahiplenmeli, değeri ve önemi çocuklara öğretilmeli, büyüklere anlatılmalıdır.Enerji tasarrufu yapılmalıdır." +
                " Biten piller pil kutusuna atılmalıdır.Piknikten sonra ateş söndürülmeli ve asla yerde çöp bırakılmamalıdır." +
                " Kâğıt, teneke, cam, pil gibi geri dönüşümü olan maddeler geri dönüşüm kutularına atılmalıdır.Egzozlu taşıtlar fazlalaşmamalıdır." +
                " Başta su olmak üzere her konuda israftan kaçınılmalıdır.ürünleri özellikle de saç sprayleri ve deodorantlar fazla kullanılmamalıdır.",
                    Kaynak="https://sites.google.com/site/nurcancakalsitesi/cevreyi-korumak-icin-neler-yapmaliyiz" }
            };


            return View(read);
        }
        public ActionResult DogalAfet()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/deprem.jpg",Baslik="Deprem Anında Yapılması Gerekenler",Paragraf="Doğal afetler yaşamımızı derinden etkilemektedir. Özelliklede ülkemizde sık yaşanan deprem bu afetleri en az hasarla atlatmak  için aşağıdakiler yapılabilir:" +
                "C. DEPREM SIRASINDA ALINACAK ÖNLEMLER",
                   Paragraf2= " I. Bina İçerisinde"+
                    " 1- Kesinlikle panik yapmamalıyız. Sabitlenmemiş dolap, raf, pencere vb. eşyalardan uzak"+
                    " durmalıyız. Varsa sandalyelerle desteklenmiş masa yanına veya dolgun ve hacimli koltuk, kanepe, içi"+
                    " dolu sandık gibi koruma sağlayabilecek eşya yanına çömelmeli veya uzanmalıyız. Başımızı iki"+
                    " elimizin arasında alarak veya bir koruyucu (yastık, kitap vb) malzeme ile korumalıyız. ÇÖK-KAPANTUTUN doğru davranış şeklini uygulayarak sarsıntı geçene dek beklemeliyiz"+
                    " 2- Tekerlekli sandalyede isek tekerlekleri kilitleyerek başımızı ve boynumuzu korumaya"+
                    " almalıyız."+
                    " 3- Mutfak, imalathane, laboratuvar gibi is aletlerinin bulunduğu yerlerde; ocak, fırın ve bu gibi"+
                    " cihazları kapatmalıyız. Dökülebilecek malzeme ve maddelerden uzaklaşmalıyız.Birinci maddede"+
                    " belirtildiği şekilde kendimizi korumalıyız."+
                    " 4 - Sarsıntı geçtikten sonra elektrik, gaz ve su vanalarını kapatmalıyız.Soba ve ısıtıcıları"+
                    " söndürmeliyiz.Diğer güvenlik önlemlerini almalıyız ve daha önceden hazırlanmış acil durum çantası"+
                    " ile gerekli olan eşya ve malzemeyi yanımıza alarak derhal binayı daha önce tespit ettiğimiz yoldan"+
                    " terk edip toplanma bölgesine gitmeliyiz."+
                    " 5 - Merdiven, balkon, koridor ve geniş sahanlı yerlerden, kolonlardan ve pencerelerden"+
                    " uzaklaşmalıyız."+
                    " 6 - Okulda isek sınıfta kalarak sağlamsa sıra yanına birinci maddede belirtildiği şekilde ÇÖKKAPAN - TUTUN hareketini yaparak başımızı korumalıyız."+
                    " 7 - Kesinlikle asansör kullanmamalıyız. Asansörde isek kat çıkış düğmesine basarak asansörü"+
                    "  terk etmeliyiz."+
                    "  II.Bina Dışında"+
                    " 1 - Enerji hatlarından, diğer binalardan ve duvar diplerinden uzaklaşmalıyız. Açık arazide"+
                    " çömelerek etraftan gelen tehlikelere karşı hazırlıklı olmalıyız."+
                    " 2 - Deniz kıyısından uzaklaşmalıyız."+
                    " 3 - Toprak kayması, tas veya kaya düşebilecek yamaç altlarında bulunmamalıyız.Böyle bir"+
                    " ortamda isek en seri şekilde güvenli bir ortama geçmeliyiz."+
                    " 4 - Binalardan düşebilecek baca, cam kırıkları ve sıvalara karşı tedbirli olmalıyız."+
                    " 5 - Toprak altındaki kanalizasyon, elektrik ve gaz hatlarından gelecek tehlikelere karşı dikkatli"+
                    " olmalıyız."+
                    " III.Araç Kullanırken"+
                    " 1 - Bulunduğumuz yer güvenli ise durmalı ve araç içinde kalmalıyız. Araç karayolunda seyir"+
                    "  halinde ise; yolu kapatmadan sağa yanaşıp durmalıyız.Kontak anahtarını yerinde bırakıp, pencereler"+
                    "  kapalı olarak araç içerisinde beklemeliyiz.Ancak sarsıntı durduktan sonra açık alanlara gitmeliyiz."+
                    " 2 - Normal trafikten, ağaçlardan, direklerden ve enerji nakil hatlarından mümkün olduğu kadar"+
                    " uzaklaşmalıyız."+
                    " 3 - Araç meskun mahallerde ise ya da güvenli bir yerde değilse; aracı durdurmalı, kontak"+
                    " anahtarı üzerinde bırakılarak aracı terk etmeli ve açık alanlara gitmeliyiz."+
                    " IV.Metroda veya Diğer Toplu Taşıma Araçlarında"+
                    " 1 - Gerekmedikçe, kesinlikle metro ve trenden inmemeliyiz.Elektriğe kapılabilir veya diğer bir"+
                    " tren çarpabilir."+
                    " 2 - Trenin içinde, sıkıca tutturulmuş askı, korkuluk veya herhangi bir yere tutunmalıyız."+
                    " 3 - Metro veya tren personeli tarafından verilen talimatları izlemeliyiz.",
                    Kaynak="http://www.bingol.edu.tr/documents/AssetFiles/AFETLER%20VE%20ALINACAK%20%C3%96NLEMLER_3cd0fc1d-b671-4f44-8470-a4c187ae597e.pdf"}
            };
            return View(read);
        }

        public ActionResult Kultur()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/kultur.jpg",Baslik="Tiyatrolar",Paragraf="Son yıllarda Türk tiyatrosundaki değişim ve seyirci yönelişini göz önüne alan Şehir Tiyatroları, yerli ve yabancı yazarlardan oluşan geniş bir repertuarla İstanbul seyircisine ve turneler yoluyla da diğer kentlerdeki tiyatroseverlere perdelerini açmakta. Ayrıca, yabancı yönetmenleri ve tiyatro adamlarını davet ederek, sahneye koydukları oyunları Türk seyircisine ulaştırmaktadır. Bugün on sahnesi olan Şehir Tiyatroları, her gün 3000 civarında İstanbul seyircisine perdelerini açıyor. Bu sahneler: Harbiye Muhsin Ertuğrul Sahnesi, Kadıköy Haldun Taner Sahnesi, Fatih Reşat Nuri Sahnesi, Gaziosmanpaşa Sahnesi, Gaziosmanpaşa Ferih Egemen Çocuk Sahnesi, Üsküdar Musahipzade Celal Sahnesi, Üsküdar Kerem Yılmazer Sahnesi, Kağıthane Sadabad Sahnesi, Kağıthane Küçük Kemal Çocuk Sahnesi, Ümraniye Sahnesi’dir.",Kaynak="https://tiyatrolar.com.tr/istanbulsehirtiyatrolari/?s=hakkinda" }
            };
            return View(read);
        }
        public ActionResult Nufus()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/nufus.jpg",
                    Baslik="İstanbul Nüfusu",
                    Paragraf="Asırlardır birçok medeniyete ev sahipliği yapmış olan İstanbul, Türkiye’nin en kalabalık nüfusa sahip şehridir. İstanbul’un en önemli özelliklerinden "+
                    " biri de tarihin her döneminde göç almış olmasıdır. İstanbul, bu özelliğini Cumhuriyet Dönemi'nde de devam ettirmiştir. Nüfus bakımından Türkiye’nin"+
                    " en büyük kenti olmasının yanı sıra İstanbul, aynı zamanda nitelikli insan gücünün ve önemli yatırımların toplandığı bir metropoldür.",
                    Paragraf2=" İstanbul’un nüfusu 2010 yılında 13 milyon 255 bin 685, 2011 yılında 13 milyon 624 bin 240, 2012 yılında 13 milyon 854 bin 740, 2015 yılında 14 milyon 657"+
                    " bin 434, 2016 yılında 14 milyon 804 bin 116, 2017 yılında 15 milyon 29 bin 231, 2018 yılında ise 15 milyon 67 bin 724 olmuştur." ,
                    Kaynak="http://www.istanbul.gov.tr/nufus-bakimindan-turkiyenin-en-buyuk-kenti-istanbul"}
            };
            return View(read);
        }
        public ActionResult Spor()
        {
            List<Read> read = new List<Read>
            {
                new Read(){ResimYolu="../iwpProje/spor.jpg",Baslik="Spor Tesisleri",
                    Paragraf="51 spor tesisi ve kompleksinde İstanbul Büyükşehir Belediyesi Gençlik ve Spor Müdürlüğü’nün tesis İşletmeciliği modeli ile yürütülen spor hizmetlerinden yılda yaklaşık 3,5 milyon İstanbulluya bireysel ve grup halinde spor yaptırılmaktadır.",
                    Paragraf2="Tesislerimiz sporu tabana yaymak, büyük küçük herkese spor yapma alışkanlığı kazandırmak ve mümkün olan en fazla sayıda İstanbullunun spor yapmasını sağlamak amacıyla (haftanın 7 günü 08.00-18.00 saatleri arası ücretsiz) 08:00 – 22:00 saatleri arasında halkın kullanımına sunulmaktadır.Tesislerde futbol, voleybol, basketbol, tenis, fitness, yüzme, step aerobik, pilates, karate, cimnastik, judo, taekwon-do, masa tenisi, buz pateni, fonksiyonel antrenman, spinning, aero dans, bosu, kick boks, kungfu wushu, okçuluk, badminton, atletizm, güreş, savunma sporları, sqush, kapoera branşlarında hizmet verilmektedir.Tüm tesislerimizdeki ücretsiz spor hizmetlerimizden yararlanılabilmesi için öncelikle www.spor.istanbul adresi üzerinden kayıt olunması gerekmektedir.",
                    Kaynak="https://www.ibb.istanbul/SitePage/Index/197" }
            };
            return View(read);
        }

    }
}