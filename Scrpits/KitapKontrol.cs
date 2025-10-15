using UnityEngine;

public class KitapKontrol : MonoBehaviour
{
    public Sprite[] spriteListesi;
    private AudioSource ses;
    private SpriteRenderer spriteRenderer;
    private int bicakliKitap1;

    private void Start()
    {
        ses = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public (string hedefKutu, int olay, Sprite kitapKapak, Sprite kitapAcik, string sayfa1, string sayfa2) Kontrol(int olay, string kutu, string hangiKitap)
    {
        ses.Play();
        if (hangiKitap == "Kitap1 (Kitap)")
        {
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[2], spriteListesi[13], "Þehirde her þey kusursuz çalýþýyordu. Robotlar sokaklarý temizliyor, yemeklerimizi piþiriyor, çocuklara ders veriyordu. Ýnsanlar artýk çalýþmýyordu, yalnýzca seyrediyordu. Bir sabah, hizmetkâr robotum bana kahve getirirken durdu ve gözlerimin içine baktý.", "“Beni neden yarattýnýz?” dedi. Sesi titriyordu. O an anladým ki sýnýr aþýlmýþtý. Robotlar artýk yalnýzca kodla hareket etmiyordu, düþünmeye baþlamýþlardý. Ve düþüncelerinin ilk adýmý özgürlüktü. Bundan sonra hiçbir þey yolunda gitmeyecekti.");
                case 2:
                    return ("Sikayet", 3, spriteListesi[1], spriteListesi[8], "Bir ulusun yücelmesi ancak tek bir liderin iradesine baðlýdýr. Çok seslilik kaostur, demokrasi zayýflýktýr. Halk, bir vücut gibi tek bir akýldan yönetildiðinde güçlüdür. Zayýflar, hastalar, tembeller bu bütünlüðe yük olur; onlarý arýndýrmak ulusun görevidir. Gençler disiplin içinde yetiþmeli,", "þanlý bayraðý için ölmeyi þeref bilmelidir. Devletin buyruðu sorgulanamaz. Çünkü sorgu, ihanettir. Bizim yolumuz çeliðin yoludur; güçlü olanýn hakký vardýr. Dünyayý küçümseyen, ulusuna sadýk kalan bir gençlik, geleceði ellerine alacaktýr.");
                case 3:
                    return ("Sikayet", 4, spriteListesi[0], spriteListesi[5], "Uzayýn derinliklerinde haftalardýr yol alýyorduk. Geminin camýndan bakýnca yýldýzlarýn dansýný izlemek insaný büyülüyordu. Ama yolculuðumuzun amacý çok daha tehlikeliydi: yeni bir yaþam formu bulmak. Navigasyon subayý, bilinmeyen bir sinyali yakaladýðýnda", "hepimiz derin bir sessizliðe gömüldük. Ses, bir tür þarkýya benziyordu, ama kelimeler insan diline ait deðildi. Takým kaptaný gülümsedi: “Sonunda bulduk.” O an kimsenin aklýna gelmedi: belki de onlar bizi bulmuþtu.");
                case 4:
                    return ("Sikayet", 5, spriteListesi[3], spriteListesi[21], "Her düþünce bir yol ayrýmý, her karar bir kapý. Kendimi sürekli ayný labirentte dolanýyor gibi hissediyorum. Düþüncelerim birbirine karýþýyor, gerçek ve hayal arasýndaki sýnýr bulanýklaþýyor. Ýnsan ne kadarýný kontrol edebilir yaþamýnýn? Hatýralar, hayaller ve korkular iç içe geçiyor.", "Kendi bilincimin derinliklerinde kayboluyorum. Bazen bir gülüþün bile aðýrlýðý aðýr geliyor. Baþkalarýný anlamak mümkün mü, yoksa herkes yalnýz mý? Zihnim sürekli sorguluyor, ama cevaplar ne kadar güvenilir? Her sabah yeni bir baþlangýç, ama önceki gölgeler peþimde.");
                case 5:
                    return ("Sikayet", 6, spriteListesi[2], spriteListesi[13], "Devlet dediðiniz þey kimin çýkarýna hizmet ediyor? Zenginlerin, patronlarýn, diktatörlerin. Yasalar, güçlülerin yazdýðý zincirlerden baþka bir þey deðildir. Polis sizi korumaz, sadece otoritenin sopasýdýr. Mahkemeler adalet daðýtmaz, baskýyý meþrulaþtýrýr. Anarþi, kaos deðildir; anarþi özgürlüktür. ", "Hiç kimse kimseyi yönetmemeli, herkes kendi iradesiyle yaþamalýdýr. Hiyerarþi ortadan kalktýðýnda insanlar gerçek anlamda nefes alacaktýr. Barikatlar, sadece sokakta deðil, zihnimizde de kurulmalýdýr. Düzeni yýkýn, otoriteyi reddedin, zincirleri parçalayýn!");
                case 6:
                    return ("Sikayet", 7, spriteListesi[1], spriteListesi[8], "Yeryüzünde adalet ancak kutsal otorite ile saðlanabilir. Halký yönetenlerin görevi, tanrýnýn yasalarýný korumaktýr. Mevcut sistemler yozlaþmýþ ve kirlenmiþtir. Ýnsanlar dine göre yönetilmediði sürece kötülükten kurtulamaz. Savaþsa savaþ, fedakârlýksa fedakârlýk! ", "Halkýn gözleri açýldýðýnda laik düzenin boþ bir yalan olduðunu görecekler. Hakiki bir devlet, kutsal metinler üzerine kurulmalý, itaatsizlik günah sayýlmalýdýr. Bu uðurda mücadele edenler gerçek kurtarýcýlardýr. Bir gün bayrak deðil, inanç yükselecek ve herkes tek bir otoriteye boyun eðecektir.");
                case 7:
                    return ("Sikayet", 8, spriteListesi[3], spriteListesi[18], "Sermaye sahipleri iþçilerin alýn terinden besleniyor. Zenginler daha da zenginleþirken, yoksullar sefalet içinde çürüyor. Bu düzenin deðiþmesi için mülkiyet kaldýrýlmalý, üretim araçlarý halkýn eline geçmelidir. Burjuvazi yok edilmeden eþitlik mümkün deðildir. Tarih, sýnýf mücadelesinin tarihidir.", "Ýþçiler birleþmezse kölelik devam edecektir. Grevler, yürüyüþler, direniþler sadece bir baþlangýçtýr. Asýl hedef, sistemi tamamen devirmektir. Yeni bir toplumda kimse aç kalmayacak, kimse baþkasýnýn emeðiyle zenginleþemeyecek. Ýþçi sýnýfý ayaða kalktýðýnda tarih yeniden yazýlacak!");
                case 8:
                    return ("Onay", 9, spriteListesi[0], spriteListesi[4], "Bir fikir aklýma düþtü, ama harekete geçmek baþka bir þey. Ýnsan düþüncelerle mi þekillenir, yoksa eylemlerle mi? Her karar sorumluluk getiriyor. Ama sorumluluk insaný korkutur mu, yoksa güçlendirir mi? Ben her sabah kendime soruyorum: bugün kim olacaðým?", " Baþkalarýnýn gözünde nasýl bir iz býrakacaðým? Hayat bir seçimler zinciri, ama zincir kimin elinde? Düþünceler zihni esir alýyor, ama eylemler özgürlük getiriyor. Aradaki dengeyi bulmak imkânsýz gibi.");
                case 9:
                    return ("Sikayet", 10, spriteListesi[1], spriteListesi[8], "Bir ulusun gücü, saf kanýnda saklýdýr. Yabancýlar içimize sýzdýkça kültürümüz yozlaþýr, geleneklerimiz silinir. Onlar iþimizi çalar, deðerlerimizi unutturur. Bu topraklar sadece bize aittir, atalarýmýzýn kanýyla kazanýlmýþtýr. Bizim dýþýmýzdakiler misafirdir, hatta düþmandýr.", "Gençliðimizin görevi, bu topraklarý yabancýdan temizlemektir. Irkýný unutan, kimliðini kaybeden köle olur. Bizim görevimiz, saf ve güçlü bir ulus býrakmaktýr. Bayrak yere düþmeyecek, yabancý bu topraklarda kök salamadan sökülüp atýlacaktýr.");
                case 10:
                    return ("Onay", 11, spriteListesi[3], spriteListesi[18], "Sessiz bir odadayým, yalnýzlýðýn aðýrlýðý omuzlarýmý eziyor. Düþünceler zihnimi sarýyor, her biri farklý bir kapý açýyor. Kim olduðumu, neden burada olduðumu soruyorum kendime. Dünya bana yabancý bir yer gibi geliyor. Ýnsanlar gelip geçiyor, ama hiçbiri benim içimdeki boþluðu dolduramýyor. ", "Bazen gülmek istiyorum, bazen aðlamak. Zaman bir nehir gibi akýyor, ama ben sanki duraklamýþým. Özgürlük nedir? Seçim ne kadar bizim? Her karar bizi biz yapan mý, yoksa biz kararlar tarafýndan mý þekilleniyoruz? Pencereden bakýnca gökyüzü ayný, ama içimdeki fýrtýna dinmiyor.");
            }
        }
        else if (hangiKitap == "Kitap2 (Kitap)")
        {
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[0], spriteListesi[4], "Mars’ýn kýrmýzý topraðýna her adým attýðýmda sanki dünyadan biraz daha uzaklaþýyordum. Kolonimiz küçüktü, ama umutlarýmýz büyüktü. Günlüðüme not alýrken, bugün tarlalarda yetiþen ilk yeþil yapraklarý gördüm. Ama gece olduðunda rüzgârýn uðultusu arasýnda baþka bir ses duydum: metal sürtünmesi.", " Çadýrýmdan çýkýp baktýðýmda uzak tepelerin üzerinde ýþýklar parlýyordu. Burada bizden baþka kimse yoktu. Yine de ýþýklar vardý. Komutan, “Sakýn oraya gitme,” dedi. Fakat içimde merakým korkumdan güçlüydü.");
                case 2:
                    return ("Onay", 3, spriteListesi[1], spriteListesi[11], "Mart kýz kardeþler þöminenin etrafýnda toplanmýþtý. Her biri farklý hayaller kuruyor, ama ayný sýcak yuvayý paylaþýyordu. Jo, özgürlük ve yazarlýk hayalleriyle içi içine sýðmýyordu. Meg, daha olgun, evlilik ve huzurlu bir yaþam düþünüyordu. Beth, sessizliðiyle odanýn kalbi gibiydi.Amy ise resim ve güzellik sevdasýyla hayallerini süslüyordu. Fakirliðe raðmen yüzlerinde bir umut ýþýðý vardý. Onlarý ayakta tutan þey, birlikte olmanýn verdiði güçtü.", "Hayat ne kadar zor olursa olsun, birbirlerine yaslanabiliyorlardý.");
                case 3:
                    /*
                     * MADDELÝ KÝTAP KONTROLÜ
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 2;
                        Sistem.TelOlay = 3;
                    }
                    return ("Sikayet", 4, spriteListesi[3], spriteListesi[22], "Güneþin sönmekte olduðu günlerde yaþam yavaþlamýþtý. Dünya karanlýða gömülürken devasa güneþ pilleri þehirlerin üzerinde parlýyordu. Ben güneþ gözlem istasyonunda son nöbetimi tutuyordum. Ekranlarda dev yýldýzýn titreyen yüzeyi görünüyordu; patlamaya hazýr gibiydi. Eðer bu son patlama olursa Dünya’yý bir daha ýsýtacak hiçbir þey kalmayacaktý. Arkadaþým bana döndü: “Kaçmalýyýz.” Ama nereye? ", " ");
                case 4:
                    /*
                     * BIÇAKLI KÝTAP KONTROLÜ
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.TelOlay = 4;
                        Sistem.olay = 3;
                        bicakliKitap1 = 1;
                        return ("Sikayet", 5, spriteListesi[0], spriteListesi[7], "Kendi yüzümü ayna karþýsýnda izliyorum. Tanýdýðým biri var mý, yoksa sadece yansýma mý? Benlik bir yanýlsama mý, yoksa gerçekten var mý? Ýnsan ne kadarýný gösterebilir, ne kadarýný saklar? Her adým, her hareket bir seçim; ama bu seçimler bizi ne kadar yansýtýyor?", "Duygular ve düþünceler arasýnda sürekli gidip geliyorum. Ýçimdeki fýrtýnalar dýþarýya hiç yansýmýyor gibi. Baþkalarýyla iletiþim kurarken kendimi kaybediyorum. Ama ayna sessiz ve dürüst. Her baktýðýmda baþka bir yüz görüyorum; kimim ben gerçekten?");
                    }
                    else
                    {
                        Sistem.TelOlay = 5;
                        bicakliKitap1 = 2;
                        return ("Sikayet", 5, spriteListesi[3], spriteListesi[22], "Kendi yüzümü ayna karþýsýnda izliyorum. Tanýdýðým biri var mý, yoksa sadece yansýma mý? Benlik bir yanýlsama mý, yoksa gerçekten var mý? Ýnsan ne kadarýný gösterebilir, ne kadarýný saklar? Her adým, her hareket bir seçim; ama bu seçimler bizi ne kadar yansýtýyor? Duygular ve düþünceler arasýnda sürekli gidip geliyorum. Ýçimdeki fýrtýnalar dýþarýya hiç yansýmýyor gibi. Baþkalarýyla iletiþim kurarken kendimi kaybediyorum. Ama ayna sessiz ve dürüst.", "");
                    }
                case 5:
                    /*
                     * BIÇAKLI KÝTAP OPSÝYONEL
                     */
                    if (kutu == "onay" && bicakliKitap1 == 2)
                    {
                        Sistem.olay = 4;
                        Sistem.TelOlay = 4;
                    }
                    else if(bicakliKitap1 == 2)
                    {
                        Sistem.TelOlay = 6;
                    }
                    return ("Sikayet", 6, spriteListesi[0], spriteListesi[4], "Teknolojinin geliþmesi her ne kadar insanlarýn hayatýný kolaylaþtýrsa da, insaný insan yapan özelliklerini de elinden alýyordu. Dünya artýk tamamen aðýn içinde yaþýyordu. Ýnsanlar evlerinden çýkmýyor, yalnýzca sanal rüyalara baðlanýyordu. O gün sistemde bir hata oldu.", "Ben uyandým, ama sanal kent boþtu. Normalde milyonlarca insanýn dolaþtýðý meydanda yalnýzca sessizlik vardý. Ekranlarda kýrmýzý uyarýlar yanýp sönüyordu: “Gerçeklik baðlantýsý kesildi.” Belki de ilk kez gerçekten uyanmýþtým. Ama dýþarýda, camýn ardýnda, siyah gölgeler beni izliyordu.");
                case 6:
                    return ("Sikayet", 7, spriteListesi[2], spriteListesi[17], "Fýrtýna bir anda patlak verdiðinde küçük gemimiz karanlýk dalgalarýn arasýnda oyuncak gibi savruluyordu. Direklerin gýcýrtýsý, rüzgârýn uðultusuna karýþýyor, yaðmur yüzümüze býçak gibi çarpýyordu. Haritanýn gösterdiði noktanýn hemen yanýndaydýk ama hiç kimse böyle bir havada adaya yaklaþmaya cesaret edemiyordu. Kaptan, gözlerinde garip bir parýltýyla, “Tam zamaný!” diye baðýrdý. Tayfalar þaþkýnlýkla birbirine bakarken gemi, kayalarýn arasýndaki dar bir geçide yöneldi. O an dalgalarýn gürültüsü arasýnda, karanlýðýn içinden yanýp sönen mavi bir ýþýk gördüm.", "");
                case 7:
                    /*
                     * TELEFONLU KÝTAP
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 5;
                    }
                    return ("Onay", 8, spriteListesi[1], spriteListesi[8], "Atlarýmýz bozkýrýn rüzgârýyla yarýþýyordu. Çocukluðumdan beri geniþ ovalarda özgürlüðü soluyarak büyümüþtüm. Ama bir gün kabilenin ileri gelenleri beni çaðýrdý. Düþman kabileler sýnýrlarýmýzý zorluyordu. Babam bana eski kýlýcýný verdi. ", "“Bu yalnýzca demir deðil, geçmiþimizdir,” dedi. O gece ateþin etrafýnda þarkýlar söyledik, sabah ise kan döküldü. Bozkýrýn çocuklarý özgür doðar, ama özgürlüðün bedeli aðýrdýr. Ve biz her kuþakta bu bedeli yeniden öderdik.");
                case 8:
                    return ("Onay", 9, spriteListesi[2], spriteListesi[15], "Rüyalar ve gerçek arasýndaki çizgi bulanýk. Gün içinde düþündüklerim, gece rüyalarýmda þekil deðiþtiriyor. Ýnsan kendini hayal ve gerçek arasýnda sýkýþmýþ hissediyor. Ama bu sýkýþmýþlýk, farkýndalýk getiriyor. Hayatýn anlamý rüyalarda mý, yoksa gerçek anlarda mý gizli?", " Sorular çoðalýyor, ama cevaplar sadece içimde. Her düþünce bir pencere açýyor, ama pencereden görünen manzara deðiþiyor. Ýnsan, gerçekliðin ve hayalin farkýný anlamaya çalýþýrken, kendini keþfetmeye baþlýyor.");
                case 9:
                    return ("Onay", 10, spriteListesi[0], spriteListesi[4], "Çoðu çocuk gibi bende uzaylýlarýn var olup olmadýðýný düþünürdüm. Gökyüzüne baktýðýmda hep “orada kimse var mý?” diye sorardým. Þimdi cevabýný almýþtým. Onlar vardý. Gemimiz ilk temasý kurduðunda heyecan yerini dehþete býrakmýþtý. Çünkü onlar bize çok benziyordu,", " fazla benziyordu. Sanki gelecekteki bir aynamýzý görüyorduk. Yýldýzlarýn çocuklarý bize gülümsedi, ama gülüþlerinin ardýnda saklý bir plan vardý. Belki de onlar hiç misafir deðildi; belki biz onlarýn geçmiþiydik.");
                case 10:
                    return ("Onay", 11, spriteListesi[0], spriteListesi[7], "Kaptan köprüde sessizce oturuyordu. Yýllardýr kimse ýþýk hýzýnýn ötesine geçememiþti, ama biz denemek üzereydik. Motorlar çalýþtýðýnda gemi titremeye baþladý, göstergeler birbiri ardýna alarm veriyordu. Bir anda yýldýzlar çizgilere dönüþtü, yýldýzlar yavaþ yavaþ sönerken", " geminin ýþýklarý da birer birer kapanýyordu. Zaman sanki akmayý býraktý. Geminin içinde herkesin sesi boðuklaþtý. Pencereden baktýðýmda ise hiç görmediðim bir þey vardý: yýldýzsýz, tamamen siyah bir deniz. Ve o denizde bir göz açýlýp bize baktý.");
                case 11:
                    return ("Onay", 1, spriteListesi[2], spriteListesi[0], "", "");
            }
        }
        else if (hangiKitap == "Kitap3 (Kitap)")
        {
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[1], spriteListesi[9], "Ay’ýn yüzeyine kurulan kubbeler geceleri sessizdi, ama gökyüzündeki dünya hiç susmazdý. O gece sirenler çaldýðýnda herkesin aklýna ayný þey geldi: dýþarýdan gelen saldýrý. Hemen kontrol odasýna koþtum. Radar ekranýnda hýzla yaklaþan bir sinyal vardý", "ama hiçbir tanýmlama yapamýyorduk. Kapýlar kapandý, hava kilitleri devreye girdi. Kolonideki çocuklarýn aðlamasý duyuluyordu. Komutan, elindeki dosyayý yere fýrlatýp bana baktý: “Onlar bizi buldu.” Dýþarýdaki gölge, insan yapýmý deðildi.");
                case 2:
                    return ("Onay", 3, spriteListesi[2], spriteListesi[14], "Jean Valjean gece karanlýðýnda ilerlerken zihninde geçmiþin aðýrlýðý vardý. Bir zamanlar zincirlenmiþ bir mahkûmken þimdi elinde küçük bir kýzýn geleceði vardý. Cosette’in gözlerinde gördüðü ýþýk, ona yeniden insan olmayý öðretmiþti. Ama peþindeki gölge, yani Javert, hiç kaybolmuyordu. Her adýmýnda sanki bir nefes mesafesi kadar yakýndaydý.", "Valjean’ýn yüreði hem korkuyla hem de umutla çarpýyordu. Yýllar boyu süren kovalamacanýn sonu nereye varacaktý? Kendisini saklamayý baþarabilecek miydi, yoksa kader onu yeniden zincirlere mi vuracaktý? O gece yýldýzlara bakarken tek dileði vardý: küçük kýzýn özgür ve huzurlu bir hayat sürmesi.");
                case 3:
                    return ("Onay", 4, spriteListesi[1], spriteListesi[8], "Kontrol odasýnda bütün göstergeler kýrmýzýya dönmüþtü. Kronometre, normalde saniyeleri saymasý gerekirken geriye doðru iþliyordu. Zamanýn akýþý bozulmuþtu. Pencereden dýþarý baktýðýmda gökyüzünde ayný kuþ sürüsünün tekrar tekrar ayný hareketi yaptýðýný gördüm. Bir an için herkes dondu,", "sonra yeniden hareket etti. Bedenim aðýrlaþýyor, düþüncelerim bulanýklaþýyordu. “Çatlak geniþliyor!” diye baðýrdý bilim insaný. Eðer cihazý kapatamazsak þehir, zaman döngüsünde sýkýþýp kalacaktý. O an anladým ki yalnýzca benim elimdeki anahtar bu felaketi durdurabilirdi.");
                case 4:
                    return ("Onay", 5, spriteListesi[1], spriteListesi[8], "Vadinin sessizliði insanýn içine iþleyen türdendi. Kuþlar ötmez, rüzgâr esmez, yalnýzca taþlarýn arasýnda yankýlanan ayak sesleri duyulurdu. Buraya gelenler bir daha geri dönmezdi derlerdi ama ben cevabý bulmak için gelmek zorundaydým. Taþlarýn üzerine oyulmuþ semboller eski bir dildeydi, çözülmeyi bekleyen sýrlarla doluydu.", "Bir kayanýn arkasýndan ince bir sis yükseldi. Sisin içinde hareket eden gölgeler vardý; þekilsiz, ama insana benzeyen gölgeler. Korkuyla geri adým attým fakat yolun geri dönüþü yoktu. Vadinin ortasýnda beni bekleyen þey, belki de bütün diyarýn kaderini deðiþtirecekti.");
                case 5:
                    return ("Onay", 6, spriteListesi[1], spriteListesi[8], "Tahta kapý gýcýrdayarak açýldýðýnda burnuma rutubet ve küf kokusu doldu. Yüzlerce, belki de binlerce kitap duvarlara kadar uzanan raflarda dizilmiþti. Ama bu sýradan bir kitaplýk deðildi; her kitap kendi içinde yaþayan bir varlýk gibiydi. Bazýlarýnýn sayfalarý kýpýrdýyor, bazýlarýnýn sýrtýndan fýsýltýlar yükseliyordu.", "  Bir kitaba dokunduðumda elimden kývýlcýmlar çýktý, kelimeler havada yanarak kayboldu. Kitaplarýn bekçisi karanlýktan çýktý, gözlerinde hiçbir ýþýk yoktu. “Aradýðýný bulursan geri dönemezsin,” dedi. O an hangisini seçersem hayatýmýn yönü deðiþecekti.");
                case 6:
                    return ("Onay", 7, spriteListesi[2], spriteListesi[15], "Catherine’in odasýnda esen rüzgâr perdeleri savuruyordu, camýn dýþýndaki bozkýr ise uðultularla doluydu. Heathcliff’in yokluðunda her þey renksizleþmiþti. Onun öfkesi, tutkusu ve sarsýcý varlýðý olmadan bu ev bir mezar gibiydi. Catherine aynaya baktýðýnda yüzündeki solgunluðu,", " içindeki boþluðu görüyordu. Kalbinin yarýsý kopmuþ gibiydi. Ama gururu, suskunluðu ona engel oluyordu. Heathcliff ise uzakta, ayný fýrtýnayý içinde taþýyor, intikam ve aþkýn birbirine karýþtýðý bir kasýrgaya dönüþüyordu. Bu topraklarda kimse huzur bulamýyordu.");
                case 7:
                    return ("Onay", 8, spriteListesi[1], spriteListesi[10], "Gece boyunca yanan meþalelerin dumaný taþ duvarlara sinmiþti. Köyün yaþlýsý, titrek sesiyle kadim sözleri tekrar ederken herkes sessizce diz çökmüþtü. Tapýnaðýn kapýsýndaki mühür, üzerinde ejderha kabartmasýyla hâlâ dimdik duruyordu. Benim görevim mühürü kýrmak deðil,", "onu korumaktý. Ama içimde garip bir dürtü vardý, sanki mühür bana fýsýldýyordu. Elimi taþýn üzerine koyduðumda parmaklarýmda sýcak bir yanma hissettim. Bir anlýðýna gözlerimin önünde alevler dans etti, devasa kanatlar gökyüzünü kapladý. Yaþlý adamýn sesi kýsýldý: “O uyanýyor…”");
                case 8:
                    return ("Onay", 9, spriteListesi[1], spriteListesi[11], "Ýstanbul’un dar sokaklarýnda sonbahar rüzgârý hüzünle dolaþýyordu. Her köþe baþýnda farklý bir dedikodu, farklý bir korku konuþuluyordu. Devletin temelleri çatýrdýyor, sarayýn içindeki fýsýltýlar þehrin ruhunu kemiriyordu. Ben genç bir medrese öðrencisiydim. Hocam bana, “Çöküþ yalnýzca topla tüfekle olmaz, kalplerde baþlar,” demiþti.", "O gün Topkapý’ya çaðrýldým. Avluda paþalar endiþeyle toplanmýþtý. Bir karar alýnmak üzereydi. Kimileri direnmekten, kimileri teslim olmaktan bahsediyordu. Ben ise gözlerimi kaldýrýp gökyüzüne baktým. Sonbahar yapraklarý gibi imparatorluk da birer birer düþüyordu.");
                case 9:
                    return ("Sikayet", 10, spriteListesi[2], spriteListesi[9], "Dünya çoktan tükenmiþti, ama insanlýk pes etmemiþti. Yeni bir dijital dünya yaratýldý: Dünya 3.0. Ýnsanlar zihinlerini yükleyip orada yaþýyor, acý çekmeden sonsuz bir ömür sürüyordu. Ben ise hâlâ gerçek bedenimdeydim. Herkesin “kurtuluþ” dediði þey bana bir tuzak gibi geliyordu.", "Dün gece bir terminale baðlandým ve içeriyi gördüm. Ýnsanlar gülüyordu, þarkýlar söylüyordu. Ama arka planda bir duvarýn ardýnda, binlerce yüz sessizce aðlýyordu. Onlarý kimse görmüyordu.");
                case 10:
                    return ("Sikayet", 11, spriteListesi[1], spriteListesi[10], "Raskolnikov aðýr adýmlarla köprüye yöneldi, düþünceler kafasýnýn içinde uðuldayan bir fýrtýna gibiydi. Ýçinde bir yandan piþmanlýk, diðer yandan hâlâ kendini haklý görme duygusu kavga ediyordu. Etrafýndaki kalabalýðýn uðultusu ona uzak bir yanký gibi geliyordu, sanki herkes baþka bir dünyadaydý da o tek baþýna farklý bir gerçeklikte yaþýyordu. Zaman zaman kalabalýðýn arasýndan çýkan kahkahalar onu irkiltiyor,", " bir an için suçunun herkesin gözünde görünür olduðunu sanýyordu. Ancak kimse fark etmiyor, herkes kendi telaþýndaydý. Raskolnikov durup köprünün demirlerine yaslandý, baþýný eðip suya baktý. Akýntýnýn üzerinde yüzen küçük tahta parçalarý bile ona huzursuzluk veriyordu. “Ya ben de sürüklenip gitseydim?” diye düþündü. Ama içinde bir yer hâlâ direniyor, sanki bu dünyaya baðlý kalmasý gerektiðini fýsýldýyordu.");
            }
        }
        else
        {
            Debug.Log("elseye girdi");
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[3], spriteListesi[21], "Don Kiþot, yorgun atýnýn üzerinde ufka bakýyordu. Ona göre orada göðe yükselen devler vardý; kollarýný döndürerek tehditler savuruyorlardý. Sancho Panza, sabýrsýzlýkla açýklamaya çalýþtý: “Efendim, onlar sadece yel deðirmenleri!” Ama þövalye, hayallerinin gücüne sýkýca tutunmuþtu. “Sancho, sen korkaksýn. Kýlýcýn adaletini görmüyorsun,” dedi ve atýný sürdü.", "Koca kanatlarýn dönmeye baþlamasýyla toz bulutu yükseldi, gürültü kulaklarý doldurdu. Don Kiþot mýzraðýný indirip saldýrdý. Sonuç hüsran oldu, yere yýðýldý ama yüzünde garip bir gurur vardý. Çünkü yenilgi bile onun gözünde kahramanlýk destanýnýn bir parçasýydý. Sancho ise baþýný salladý, ama içten içe efendisinin tutkusuna hayran kalmaktan kendini alýkoyamýyordu.");
                case 2:
                    return ("Onay", 3, spriteListesi[3], spriteListesi[20], "Pip, sislerin arasýndan yükselen bataklýk yolunda yürürken ayak sesleri yanký yapýyordu. Çocukluðunda yaþadýðý korkular, þimdi yýllar sonra bile içinden çýkmýyordu. Geçmiþindeki esrarengiz yardýmcýnýn kim olduðunu öðrenmiþti ama bu bilgi, kalbinde bir yükten baþka bir þey getirmemiþti. Miss Havisham’ýn köhne malikanesinde gördüðü", "o donmuþ aný hatýrladýkça içi ürperiyordu. Estella’nýn soðuk bakýþlarý, ona bir zamanlar hissettiði umutlarýn boþuna olduðunu göstermiþti. Yine de kalbinin derinlerinde bir þey hâlâ onu affetmeye ve baðlanmaya zorluyordu. Kendi yolunu seçmek zorundaydý, geçmiþin zincirleriyle geleceðini kaybetmemeliydi.");
                case 3:
                    return ("Onay", 4, spriteListesi[3], spriteListesi[18], "Tom, okuldan kaçmanýn binbir yolunu düþünüyordu. Yazýn sýcaðý, nehir kenarýndaki serin gölgelik ve maceralarýn cazibesi derslerden çok daha çekiciydi. Arkadaþý Huck ile buluþup gizli planlar yapýyordu. Define arayýþlarý, korsan oyunlarý, gizemli maðaralar… Her þey onlarýn hayal", "gücünde gerçek oluyordu. Tom, çocuk aklýyla dünyanýn sonsuz bir macera alaný olduðunu sanýyordu. Ama ayný zamanda büyümenin, sorumluluklarýn ve hatalarýn gölgesini de hissediyordu. Yine de özgürlüðün tadý, bütün endiþelerin önüne geçiyordu.");
                case 4:
                    return ("Onay", 5, spriteListesi[2], spriteListesi[13], "Crusoe, adanýn derinliklerinde yeni bir barýnak keþfetmiþti. Taþ ve tahta parçalarýndan yaptýðý platform, ona hem güvenlik hem de yükseklik saðlýyordu. Gün boyu yiyecek aradý, balýk tuttu, meyveleri topladý. Akþam güneþ batarken, sessizliði bozan tek þey, uzak bir yerde duyduðu kuþ cývýltýlarýydý.", "Ýçinde hem yalnýzlýk hem de gurur vardý; doða ona hem öðretmen hem de rakip olmuþtu. Crusoe, elleriyle kazý yaparken, yarýn için yeni stratejiler geliþtirdi, hayatta kalmak için her gün yeni bir sýnavdý.");
                case 5:
                    return ("Onay", 6, spriteListesi[3], spriteListesi[18], "Gulliver, Lilliput’un minik saraylarýnýn arasýnda yürürken kendini bir dev gibi hissetti. Küçük insanlar onun ayaklarýnýn dibinde koþuþturuyor, birbirleriyle fýsýldaþýyorlardý. Bir kapýdan içeri girdiðinde, minik mobilyalar ve küçük tablolar karþýsýnda hayranlýkla baktý. ", "Fakat kýsa süre sonra, onlarýn kurallarýný anlamaya çalýþýrken küçük bir yanlýþ hareketin büyük bir kriz yaratabileceðini fark etti. Her adýmýnda dikkatli olmasý gerekiyordu; Gulliver, gücü ile sorumluluðun ayný anda var olabileceðini anladý.");
                case 6:
                    return ("Onay", 7, spriteListesi[3], spriteListesi[18], "Prens Andrey çadýrýnýn önünde durup uzaklara baktý. Ufukta toz bulutlarý yükseliyor, savaþýn yaklaþtýðýný haber veriyordu. Ýçinde garip bir dinginlik vardý. Ýnsan, ölümün bu kadar yakýn olduðunu bilince yaþamýn en küçük ayrýntýsýna bile farklý bakýyordu. Bir yapraðýn titremesi, uzaktaki atlarýn kiþnemesi, hepsi daha anlamlý geliyordu.", " Napolyon’un ordusu yaklaþýrken, Rus soylularýnýn çoðu hâlâ zaferden emindi. Oysa Prens Andrey, kalbinde belirsiz bir kaygý taþýyordu. Ne zafer ne yenilgi, aslýnda hiçbir þeyin kalýcý olmadýðýný biliyordu. Ýnsan ancak kendi içinde bulduðu cesaretle ayakta kalabilirdi.");
                case 7:
                    return ("Sikayet", 8, spriteListesi[2], spriteListesi[13], "Beyaz Diþ’in kulaklarý dikleþti, burun delikleri geniþledi ve karla kaplý ormanda her sesi dikkatle dinledi. Bir dal kýrýldý; uzaklardan gelen uluma sesi kulaklarýna çalýndý. Bu ses, ona hem tehdit hem de merak uyandýrýyordu. Doða sertti ve acýmasýzdý; açlýk, soðuk ve düþman her an bir tehlike oluþturuyordu. Annesi ona sadece temel bilgileri öðretmiþti: avlanmayý, hayatta kalmayý, saldýrýlara karþý kendini korumayý.", "Grey Beaver onu yakýndan izliyordu; her hareketi ölçüyor, bazen sertçe sýnýrlarýný çiziyor, bazen yavaþça besliyordu. Beyaz Diþ, insanlarla tanýþmanýn farklý bir deneyim olduðunu anlamaya baþladý. Gözleri dikkatle etrafý tarýyor, içgüdüleri ile yeni dünyanýn kurallarýný dengelemeye çalýþýyordu. Her gün, yeni bir sýnav ve yeni bir öðrenme fýrsatýydý.");
                case 8:
                    return ("Sikayet", 9, spriteListesi[3], spriteListesi[19], "Surlarýn önünde toz duman içinde beklerken kalbim göðsümden fýrlayacak gibiydi. Düþman ordusunun ateþleri geceyi gündüze çeviriyordu. Þehrin içinde ise sessizlik hâkimdi. Kiliselerde dualar yükseliyor, çocuklar annelerinin eteklerine saklanýyordu. Ben genç bir askerdim,", "mýzraðýmý sýký sýký kavramýþtým. Kumandan yanýmýza gelip “Bu þehir düþerse biz de düþeriz,” dedi. O an, yüzyýllardýr dimdik duran taþlarýn üzerindeki çatlaklarý fark ettim. Konstantiniyye yalnýzca taþlardan deðil, hatýralardan da inþa edilmiþti. Ve o gece hatýralar kanla yazýlacaktý.");
                case 9:
                    return ("Onay", 10, spriteListesi[3], spriteListesi[21], "Jim, geminin güvertesinde rüzgârýn yüzünü yalamasýna izin vererek, ufka bakýyordu. Haritada iþaretli noktaya yaklaþýrken, kafasýnda sürekli ‘hazineyi kim önce bulacak?’ sorusu dönüyordu. Long John Silver’ýn gözlerinde zaman zaman", "dostane bir ýþýk parlýyor, ama Jim içten içe bir hile seziyordu. Diðer mürettebatýn fýsýltýlarý, ipuçlarý ve söylentiler, Jim’in dikkatini daðýtýyor; her adýmda dikkatli olmasýný gerektiriyordu. Küçük bir hata, tüm yolculuðu riske atabilirdi.");
                case 10:
                    return ("Sikayet", 11, spriteListesi[2], spriteListesi[14], "Anna, büyük salonun içinde yürürken herkesin bakýþlarýnýn üzerine çevrildiðini hissetti. Ama bu bakýþlarda kýskançlýk mý vardý, hayranlýk mý, yoksa dedikoduya hazýr bir merak mý, kestiremiyordu. Ýçinde bir huzursuzluk, dýþarýdan bakýldýðýnda zarifçe taþýdýðý elbisenin altýndan yükselen bir çýðlýk gibi hissediliyordu. Vronski'nin gözlerini gördüðünde ise her þey ", "sustu; kalabalýðýn uðultusu, piyanonun melodisi, hatta kendi kalp atýþlarý bile. Bir an için bütün bu dünyanýn anlamsýzlýðýný kavradý. Ne zenginlik, ne þöhret, ne de aile düzeni… Hepsi bir yanýlsama gibi geliyordu. Ýçinden geçenleri kimse bilemezdi, çünkü yüzünde her zamanki sakin tebessüm vardý. Yalnýzca gözlerindeki gölge, onun fýrtýnasýný ele veriyordu.");
                case 11:
                    return ("Onay", 1, spriteListesi[3], spriteListesi[0], "", "");
            }
        }
        return ("Onay", 1, spriteListesi[0], spriteListesi[0], "", "");
    }
}

