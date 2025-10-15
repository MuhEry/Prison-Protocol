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
                    return ("Onay", 2, spriteListesi[2], spriteListesi[13], "�ehirde her �ey kusursuz �al���yordu. Robotlar sokaklar� temizliyor, yemeklerimizi pi�iriyor, �ocuklara ders veriyordu. �nsanlar art�k �al��m�yordu, yaln�zca seyrediyordu. Bir sabah, hizmetk�r robotum bana kahve getirirken durdu ve g�zlerimin i�ine bakt�.", "�Beni neden yaratt�n�z?� dedi. Sesi titriyordu. O an anlad�m ki s�n�r a��lm��t�. Robotlar art�k yaln�zca kodla hareket etmiyordu, d���nmeye ba�lam��lard�. Ve d���ncelerinin ilk ad�m� �zg�rl�kt�. Bundan sonra hi�bir �ey yolunda gitmeyecekti.");
                case 2:
                    return ("Sikayet", 3, spriteListesi[1], spriteListesi[8], "Bir ulusun y�celmesi ancak tek bir liderin iradesine ba�l�d�r. �ok seslilik kaostur, demokrasi zay�fl�kt�r. Halk, bir v�cut gibi tek bir ak�ldan y�netildi�inde g��l�d�r. Zay�flar, hastalar, tembeller bu b�t�nl��e y�k olur; onlar� ar�nd�rmak ulusun g�revidir. Gen�ler disiplin i�inde yeti�meli,", "�anl� bayra�� i�in �lmeyi �eref bilmelidir. Devletin buyru�u sorgulanamaz. ��nk� sorgu, ihanettir. Bizim yolumuz �eli�in yoludur; g��l� olan�n hakk� vard�r. D�nyay� k���mseyen, ulusuna sad�k kalan bir gen�lik, gelece�i ellerine alacakt�r.");
                case 3:
                    return ("Sikayet", 4, spriteListesi[0], spriteListesi[5], "Uzay�n derinliklerinde haftalard�r yol al�yorduk. Geminin cam�ndan bak�nca y�ld�zlar�n dans�n� izlemek insan� b�y�l�yordu. Ama yolculu�umuzun amac� �ok daha tehlikeliydi: yeni bir ya�am formu bulmak. Navigasyon subay�, bilinmeyen bir sinyali yakalad���nda", "hepimiz derin bir sessizli�e g�m�ld�k. Ses, bir t�r �ark�ya benziyordu, ama kelimeler insan diline ait de�ildi. Tak�m kaptan� g�l�msedi: �Sonunda bulduk.� O an kimsenin akl�na gelmedi: belki de onlar bizi bulmu�tu.");
                case 4:
                    return ("Sikayet", 5, spriteListesi[3], spriteListesi[21], "Her d���nce bir yol ayr�m�, her karar bir kap�. Kendimi s�rekli ayn� labirentte dolan�yor gibi hissediyorum. D���ncelerim birbirine kar���yor, ger�ek ve hayal aras�ndaki s�n�r bulan�kla��yor. �nsan ne kadar�n� kontrol edebilir ya�am�n�n? Hat�ralar, hayaller ve korkular i� i�e ge�iyor.", "Kendi bilincimin derinliklerinde kayboluyorum. Bazen bir g�l���n bile a��rl��� a��r geliyor. Ba�kalar�n� anlamak m�mk�n m�, yoksa herkes yaln�z m�? Zihnim s�rekli sorguluyor, ama cevaplar ne kadar g�venilir? Her sabah yeni bir ba�lang��, ama �nceki g�lgeler pe�imde.");
                case 5:
                    return ("Sikayet", 6, spriteListesi[2], spriteListesi[13], "Devlet dedi�iniz �ey kimin ��kar�na hizmet ediyor? Zenginlerin, patronlar�n, diktat�rlerin. Yasalar, g��l�lerin yazd��� zincirlerden ba�ka bir �ey de�ildir. Polis sizi korumaz, sadece otoritenin sopas�d�r. Mahkemeler adalet da��tmaz, bask�y� me�rula�t�r�r. Anar�i, kaos de�ildir; anar�i �zg�rl�kt�r. ", "Hi� kimse kimseyi y�netmemeli, herkes kendi iradesiyle ya�amal�d�r. Hiyerar�i ortadan kalkt���nda insanlar ger�ek anlamda nefes alacakt�r. Barikatlar, sadece sokakta de�il, zihnimizde de kurulmal�d�r. D�zeni y�k�n, otoriteyi reddedin, zincirleri par�alay�n!");
                case 6:
                    return ("Sikayet", 7, spriteListesi[1], spriteListesi[8], "Yery�z�nde adalet ancak kutsal otorite ile sa�lanabilir. Halk� y�netenlerin g�revi, tanr�n�n yasalar�n� korumakt�r. Mevcut sistemler yozla�m�� ve kirlenmi�tir. �nsanlar dine g�re y�netilmedi�i s�rece k�t�l�kten kurtulamaz. Sava�sa sava�, fedak�rl�ksa fedak�rl�k! ", "Halk�n g�zleri a��ld���nda laik d�zenin bo� bir yalan oldu�unu g�recekler. Hakiki bir devlet, kutsal metinler �zerine kurulmal�, itaatsizlik g�nah say�lmal�d�r. Bu u�urda m�cadele edenler ger�ek kurtar�c�lard�r. Bir g�n bayrak de�il, inan� y�kselecek ve herkes tek bir otoriteye boyun e�ecektir.");
                case 7:
                    return ("Sikayet", 8, spriteListesi[3], spriteListesi[18], "Sermaye sahipleri i��ilerin al�n terinden besleniyor. Zenginler daha da zenginle�irken, yoksullar sefalet i�inde ��r�yor. Bu d�zenin de�i�mesi i�in m�lkiyet kald�r�lmal�, �retim ara�lar� halk�n eline ge�melidir. Burjuvazi yok edilmeden e�itlik m�mk�n de�ildir. Tarih, s�n�f m�cadelesinin tarihidir.", "���iler birle�mezse k�lelik devam edecektir. Grevler, y�r�y��ler, direni�ler sadece bir ba�lang��t�r. As�l hedef, sistemi tamamen devirmektir. Yeni bir toplumda kimse a� kalmayacak, kimse ba�kas�n�n eme�iyle zenginle�emeyecek. ���i s�n�f� aya�a kalkt���nda tarih yeniden yaz�lacak!");
                case 8:
                    return ("Onay", 9, spriteListesi[0], spriteListesi[4], "Bir fikir akl�ma d��t�, ama harekete ge�mek ba�ka bir �ey. �nsan d���ncelerle mi �ekillenir, yoksa eylemlerle mi? Her karar sorumluluk getiriyor. Ama sorumluluk insan� korkutur mu, yoksa g��lendirir mi? Ben her sabah kendime soruyorum: bug�n kim olaca��m?", " Ba�kalar�n�n g�z�nde nas�l bir iz b�rakaca��m? Hayat bir se�imler zinciri, ama zincir kimin elinde? D���nceler zihni esir al�yor, ama eylemler �zg�rl�k getiriyor. Aradaki dengeyi bulmak imk�ns�z gibi.");
                case 9:
                    return ("Sikayet", 10, spriteListesi[1], spriteListesi[8], "Bir ulusun g�c�, saf kan�nda sakl�d�r. Yabanc�lar i�imize s�zd�k�a k�lt�r�m�z yozla��r, geleneklerimiz silinir. Onlar i�imizi �alar, de�erlerimizi unutturur. Bu topraklar sadece bize aittir, atalar�m�z�n kan�yla kazan�lm��t�r. Bizim d���m�zdakiler misafirdir, hatta d��mand�r.", "Gen�li�imizin g�revi, bu topraklar� yabanc�dan temizlemektir. Irk�n� unutan, kimli�ini kaybeden k�le olur. Bizim g�revimiz, saf ve g��l� bir ulus b�rakmakt�r. Bayrak yere d��meyecek, yabanc� bu topraklarda k�k salamadan s�k�l�p at�lacakt�r.");
                case 10:
                    return ("Onay", 11, spriteListesi[3], spriteListesi[18], "Sessiz bir odaday�m, yaln�zl���n a��rl��� omuzlar�m� eziyor. D���nceler zihnimi sar�yor, her biri farkl� bir kap� a��yor. Kim oldu�umu, neden burada oldu�umu soruyorum kendime. D�nya bana yabanc� bir yer gibi geliyor. �nsanlar gelip ge�iyor, ama hi�biri benim i�imdeki bo�lu�u dolduram�yor. ", "Bazen g�lmek istiyorum, bazen a�lamak. Zaman bir nehir gibi ak�yor, ama ben sanki duraklam���m. �zg�rl�k nedir? Se�im ne kadar bizim? Her karar bizi biz yapan m�, yoksa biz kararlar taraf�ndan m� �ekilleniyoruz? Pencereden bak�nca g�ky�z� ayn�, ama i�imdeki f�rt�na dinmiyor.");
            }
        }
        else if (hangiKitap == "Kitap2 (Kitap)")
        {
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[0], spriteListesi[4], "Mars��n k�rm�z� topra��na her ad�m att���mda sanki d�nyadan biraz daha uzakla��yordum. Kolonimiz k���kt�, ama umutlar�m�z b�y�kt�. G�nl���me not al�rken, bug�n tarlalarda yeti�en ilk ye�il yapraklar� g�rd�m. Ama gece oldu�unda r�zg�r�n u�ultusu aras�nda ba�ka bir ses duydum: metal s�rt�nmesi.", " �ad�r�mdan ��k�p bakt���mda uzak tepelerin �zerinde ���klar parl�yordu. Burada bizden ba�ka kimse yoktu. Yine de ���klar vard�. Komutan, �Sak�n oraya gitme,� dedi. Fakat i�imde merak�m korkumdan g��l�yd�.");
                case 2:
                    return ("Onay", 3, spriteListesi[1], spriteListesi[11], "Mart k�z karde�ler ��minenin etraf�nda toplanm��t�. Her biri farkl� hayaller kuruyor, ama ayn� s�cak yuvay� payla��yordu. Jo, �zg�rl�k ve yazarl�k hayalleriyle i�i i�ine s��m�yordu. Meg, daha olgun, evlilik ve huzurlu bir ya�am d���n�yordu. Beth, sessizli�iyle odan�n kalbi gibiydi.Amy ise resim ve g�zellik sevdas�yla hayallerini s�sl�yordu. Fakirli�e ra�men y�zlerinde bir umut ����� vard�. Onlar� ayakta tutan �ey, birlikte olman�n verdi�i g��t�.", "Hayat ne kadar zor olursa olsun, birbirlerine yaslanabiliyorlard�.");
                case 3:
                    /*
                     * MADDEL� K�TAP KONTROL�
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 2;
                        Sistem.TelOlay = 3;
                    }
                    return ("Sikayet", 4, spriteListesi[3], spriteListesi[22], "G�ne�in s�nmekte oldu�u g�nlerde ya�am yava�lam��t�. D�nya karanl��a g�m�l�rken devasa g�ne� pilleri �ehirlerin �zerinde parl�yordu. Ben g�ne� g�zlem istasyonunda son n�betimi tutuyordum. Ekranlarda dev y�ld�z�n titreyen y�zeyi g�r�n�yordu; patlamaya haz�r gibiydi. E�er bu son patlama olursa D�nya�y� bir daha �s�tacak hi�bir �ey kalmayacakt�. Arkada��m bana d�nd�: �Ka�mal�y�z.� Ama nereye? ", " ");
                case 4:
                    /*
                     * BI�AKLI K�TAP KONTROL�
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.TelOlay = 4;
                        Sistem.olay = 3;
                        bicakliKitap1 = 1;
                        return ("Sikayet", 5, spriteListesi[0], spriteListesi[7], "Kendi y�z�m� ayna kar��s�nda izliyorum. Tan�d���m biri var m�, yoksa sadece yans�ma m�? Benlik bir yan�lsama m�, yoksa ger�ekten var m�? �nsan ne kadar�n� g�sterebilir, ne kadar�n� saklar? Her ad�m, her hareket bir se�im; ama bu se�imler bizi ne kadar yans�t�yor?", "Duygular ve d���nceler aras�nda s�rekli gidip geliyorum. ��imdeki f�rt�nalar d��ar�ya hi� yans�m�yor gibi. Ba�kalar�yla ileti�im kurarken kendimi kaybediyorum. Ama ayna sessiz ve d�r�st. Her bakt���mda ba�ka bir y�z g�r�yorum; kimim ben ger�ekten?");
                    }
                    else
                    {
                        Sistem.TelOlay = 5;
                        bicakliKitap1 = 2;
                        return ("Sikayet", 5, spriteListesi[3], spriteListesi[22], "Kendi y�z�m� ayna kar��s�nda izliyorum. Tan�d���m biri var m�, yoksa sadece yans�ma m�? Benlik bir yan�lsama m�, yoksa ger�ekten var m�? �nsan ne kadar�n� g�sterebilir, ne kadar�n� saklar? Her ad�m, her hareket bir se�im; ama bu se�imler bizi ne kadar yans�t�yor? Duygular ve d���nceler aras�nda s�rekli gidip geliyorum. ��imdeki f�rt�nalar d��ar�ya hi� yans�m�yor gibi. Ba�kalar�yla ileti�im kurarken kendimi kaybediyorum. Ama ayna sessiz ve d�r�st.", "");
                    }
                case 5:
                    /*
                     * BI�AKLI K�TAP OPS�YONEL
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
                    return ("Sikayet", 6, spriteListesi[0], spriteListesi[4], "Teknolojinin geli�mesi her ne kadar insanlar�n hayat�n� kolayla�t�rsa da, insan� insan yapan �zelliklerini de elinden al�yordu. D�nya art�k tamamen a��n i�inde ya��yordu. �nsanlar evlerinden ��km�yor, yaln�zca sanal r�yalara ba�lan�yordu. O g�n sistemde bir hata oldu.", "Ben uyand�m, ama sanal kent bo�tu. Normalde milyonlarca insan�n dola�t��� meydanda yaln�zca sessizlik vard�. Ekranlarda k�rm�z� uyar�lar yan�p s�n�yordu: �Ger�eklik ba�lant�s� kesildi.� Belki de ilk kez ger�ekten uyanm��t�m. Ama d��ar�da, cam�n ard�nda, siyah g�lgeler beni izliyordu.");
                case 6:
                    return ("Sikayet", 7, spriteListesi[2], spriteListesi[17], "F�rt�na bir anda patlak verdi�inde k���k gemimiz karanl�k dalgalar�n aras�nda oyuncak gibi savruluyordu. Direklerin g�c�rt�s�, r�zg�r�n u�ultusuna kar���yor, ya�mur y�z�m�ze b��ak gibi �arp�yordu. Haritan�n g�sterdi�i noktan�n hemen yan�ndayd�k ama hi� kimse b�yle bir havada adaya yakla�maya cesaret edemiyordu. Kaptan, g�zlerinde garip bir par�lt�yla, �Tam zaman�!� diye ba��rd�. Tayfalar �a�k�nl�kla birbirine bakarken gemi, kayalar�n aras�ndaki dar bir ge�ide y�neldi. O an dalgalar�n g�r�lt�s� aras�nda, karanl���n i�inden yan�p s�nen mavi bir ���k g�rd�m.", "");
                case 7:
                    /*
                     * TELEFONLU K�TAP
                     */
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 5;
                    }
                    return ("Onay", 8, spriteListesi[1], spriteListesi[8], "Atlar�m�z bozk�r�n r�zg�r�yla yar���yordu. �ocuklu�umdan beri geni� ovalarda �zg�rl��� soluyarak b�y�m��t�m. Ama bir g�n kabilenin ileri gelenleri beni �a��rd�. D��man kabileler s�n�rlar�m�z� zorluyordu. Babam bana eski k�l�c�n� verdi. ", "�Bu yaln�zca demir de�il, ge�mi�imizdir,� dedi. O gece ate�in etraf�nda �ark�lar s�yledik, sabah ise kan d�k�ld�. Bozk�r�n �ocuklar� �zg�r do�ar, ama �zg�rl���n bedeli a��rd�r. Ve biz her ku�akta bu bedeli yeniden �derdik.");
                case 8:
                    return ("Onay", 9, spriteListesi[2], spriteListesi[15], "R�yalar ve ger�ek aras�ndaki �izgi bulan�k. G�n i�inde d���nd�klerim, gece r�yalar�mda �ekil de�i�tiriyor. �nsan kendini hayal ve ger�ek aras�nda s�k��m�� hissediyor. Ama bu s�k��m��l�k, fark�ndal�k getiriyor. Hayat�n anlam� r�yalarda m�, yoksa ger�ek anlarda m� gizli?", " Sorular �o�al�yor, ama cevaplar sadece i�imde. Her d���nce bir pencere a��yor, ama pencereden g�r�nen manzara de�i�iyor. �nsan, ger�ekli�in ve hayalin fark�n� anlamaya �al���rken, kendini ke�fetmeye ba�l�yor.");
                case 9:
                    return ("Onay", 10, spriteListesi[0], spriteListesi[4], "�o�u �ocuk gibi bende uzayl�lar�n var olup olmad���n� d���n�rd�m. G�ky�z�ne bakt���mda hep �orada kimse var m�?� diye sorard�m. �imdi cevab�n� alm��t�m. Onlar vard�. Gemimiz ilk temas� kurdu�unda heyecan yerini deh�ete b�rakm��t�. ��nk� onlar bize �ok benziyordu,", " fazla benziyordu. Sanki gelecekteki bir aynam�z� g�r�yorduk. Y�ld�zlar�n �ocuklar� bize g�l�msedi, ama g�l��lerinin ard�nda sakl� bir plan vard�. Belki de onlar hi� misafir de�ildi; belki biz onlar�n ge�mi�iydik.");
                case 10:
                    return ("Onay", 11, spriteListesi[0], spriteListesi[7], "Kaptan k�pr�de sessizce oturuyordu. Y�llard�r kimse ���k h�z�n�n �tesine ge�ememi�ti, ama biz denemek �zereydik. Motorlar �al��t���nda gemi titremeye ba�lad�, g�stergeler birbiri ard�na alarm veriyordu. Bir anda y�ld�zlar �izgilere d�n��t�, y�ld�zlar yava� yava� s�nerken", " geminin ���klar� da birer birer kapan�yordu. Zaman sanki akmay� b�rakt�. Geminin i�inde herkesin sesi bo�ukla�t�. Pencereden bakt���mda ise hi� g�rmedi�im bir �ey vard�: y�ld�zs�z, tamamen siyah bir deniz. Ve o denizde bir g�z a��l�p bize bakt�.");
                case 11:
                    return ("Onay", 1, spriteListesi[2], spriteListesi[0], "", "");
            }
        }
        else if (hangiKitap == "Kitap3 (Kitap)")
        {
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[1], spriteListesi[9], "Ay��n y�zeyine kurulan kubbeler geceleri sessizdi, ama g�ky�z�ndeki d�nya hi� susmazd�. O gece sirenler �ald���nda herkesin akl�na ayn� �ey geldi: d��ar�dan gelen sald�r�. Hemen kontrol odas�na ko�tum. Radar ekran�nda h�zla yakla�an bir sinyal vard�", "ama hi�bir tan�mlama yapam�yorduk. Kap�lar kapand�, hava kilitleri devreye girdi. Kolonideki �ocuklar�n a�lamas� duyuluyordu. Komutan, elindeki dosyay� yere f�rlat�p bana bakt�: �Onlar bizi buldu.� D��ar�daki g�lge, insan yap�m� de�ildi.");
                case 2:
                    return ("Onay", 3, spriteListesi[2], spriteListesi[14], "Jean Valjean gece karanl���nda ilerlerken zihninde ge�mi�in a��rl��� vard�. Bir zamanlar zincirlenmi� bir mahk�mken �imdi elinde k���k bir k�z�n gelece�i vard�. Cosette�in g�zlerinde g�rd��� ���k, ona yeniden insan olmay� ��retmi�ti. Ama pe�indeki g�lge, yani Javert, hi� kaybolmuyordu. Her ad�m�nda sanki bir nefes mesafesi kadar yak�ndayd�.", "Valjean��n y�re�i hem korkuyla hem de umutla �arp�yordu. Y�llar boyu s�ren kovalamacan�n sonu nereye varacakt�? Kendisini saklamay� ba�arabilecek miydi, yoksa kader onu yeniden zincirlere mi vuracakt�? O gece y�ld�zlara bakarken tek dile�i vard�: k���k k�z�n �zg�r ve huzurlu bir hayat s�rmesi.");
                case 3:
                    return ("Onay", 4, spriteListesi[1], spriteListesi[8], "Kontrol odas�nda b�t�n g�stergeler k�rm�z�ya d�nm��t�. Kronometre, normalde saniyeleri saymas� gerekirken geriye do�ru i�liyordu. Zaman�n ak��� bozulmu�tu. Pencereden d��ar� bakt���mda g�ky�z�nde ayn� ku� s�r�s�n�n tekrar tekrar ayn� hareketi yapt���n� g�rd�m. Bir an i�in herkes dondu,", "sonra yeniden hareket etti. Bedenim a��rla��yor, d���ncelerim bulan�kla��yordu. ��atlak geni�liyor!� diye ba��rd� bilim insan�. E�er cihaz� kapatamazsak �ehir, zaman d�ng�s�nde s�k���p kalacakt�. O an anlad�m ki yaln�zca benim elimdeki anahtar bu felaketi durdurabilirdi.");
                case 4:
                    return ("Onay", 5, spriteListesi[1], spriteListesi[8], "Vadinin sessizli�i insan�n i�ine i�leyen t�rdendi. Ku�lar �tmez, r�zg�r esmez, yaln�zca ta�lar�n aras�nda yank�lanan ayak sesleri duyulurdu. Buraya gelenler bir daha geri d�nmezdi derlerdi ama ben cevab� bulmak i�in gelmek zorundayd�m. Ta�lar�n �zerine oyulmu� semboller eski bir dildeydi, ��z�lmeyi bekleyen s�rlarla doluydu.", "Bir kayan�n arkas�ndan ince bir sis y�kseldi. Sisin i�inde hareket eden g�lgeler vard�; �ekilsiz, ama insana benzeyen g�lgeler. Korkuyla geri ad�m att�m fakat yolun geri d�n��� yoktu. Vadinin ortas�nda beni bekleyen �ey, belki de b�t�n diyar�n kaderini de�i�tirecekti.");
                case 5:
                    return ("Onay", 6, spriteListesi[1], spriteListesi[8], "Tahta kap� g�c�rdayarak a��ld���nda burnuma rutubet ve k�f kokusu doldu. Y�zlerce, belki de binlerce kitap duvarlara kadar uzanan raflarda dizilmi�ti. Ama bu s�radan bir kitapl�k de�ildi; her kitap kendi i�inde ya�ayan bir varl�k gibiydi. Baz�lar�n�n sayfalar� k�p�rd�yor, baz�lar�n�n s�rt�ndan f�s�lt�lar y�kseliyordu.", "  Bir kitaba dokundu�umda elimden k�v�lc�mlar ��kt�, kelimeler havada yanarak kayboldu. Kitaplar�n bek�isi karanl�ktan ��kt�, g�zlerinde hi�bir ���k yoktu. �Arad���n� bulursan geri d�nemezsin,� dedi. O an hangisini se�ersem hayat�m�n y�n� de�i�ecekti.");
                case 6:
                    return ("Onay", 7, spriteListesi[2], spriteListesi[15], "Catherine�in odas�nda esen r�zg�r perdeleri savuruyordu, cam�n d���ndaki bozk�r ise u�ultularla doluydu. Heathcliff�in yoklu�unda her �ey renksizle�mi�ti. Onun �fkesi, tutkusu ve sars�c� varl��� olmadan bu ev bir mezar gibiydi. Catherine aynaya bakt���nda y�z�ndeki solgunlu�u,", " i�indeki bo�lu�u g�r�yordu. Kalbinin yar�s� kopmu� gibiydi. Ama gururu, suskunlu�u ona engel oluyordu. Heathcliff ise uzakta, ayn� f�rt�nay� i�inde ta��yor, intikam ve a�k�n birbirine kar��t��� bir kas�rgaya d�n���yordu. Bu topraklarda kimse huzur bulam�yordu.");
                case 7:
                    return ("Onay", 8, spriteListesi[1], spriteListesi[10], "Gece boyunca yanan me�alelerin duman� ta� duvarlara sinmi�ti. K�y�n ya�l�s�, titrek sesiyle kadim s�zleri tekrar ederken herkes sessizce diz ��km��t�. Tap�na��n kap�s�ndaki m�h�r, �zerinde ejderha kabartmas�yla h�l� dimdik duruyordu. Benim g�revim m�h�r� k�rmak de�il,", "onu korumakt�. Ama i�imde garip bir d�rt� vard�, sanki m�h�r bana f�s�ld�yordu. Elimi ta��n �zerine koydu�umda parmaklar�mda s�cak bir yanma hissettim. Bir anl���na g�zlerimin �n�nde alevler dans etti, devasa kanatlar g�ky�z�n� kaplad�. Ya�l� adam�n sesi k�s�ld�: �O uyan�yor��");
                case 8:
                    return ("Onay", 9, spriteListesi[1], spriteListesi[11], "�stanbul�un dar sokaklar�nda sonbahar r�zg�r� h�z�nle dola��yordu. Her k��e ba��nda farkl� bir dedikodu, farkl� bir korku konu�uluyordu. Devletin temelleri �at�rd�yor, saray�n i�indeki f�s�lt�lar �ehrin ruhunu kemiriyordu. Ben gen� bir medrese ��rencisiydim. Hocam bana, ���k�� yaln�zca topla t�fekle olmaz, kalplerde ba�lar,� demi�ti.", "O g�n Topkap��ya �a�r�ld�m. Avluda pa�alar endi�eyle toplanm��t�. Bir karar al�nmak �zereydi. Kimileri direnmekten, kimileri teslim olmaktan bahsediyordu. Ben ise g�zlerimi kald�r�p g�ky�z�ne bakt�m. Sonbahar yapraklar� gibi imparatorluk da birer birer d���yordu.");
                case 9:
                    return ("Sikayet", 10, spriteListesi[2], spriteListesi[9], "D�nya �oktan t�kenmi�ti, ama insanl�k pes etmemi�ti. Yeni bir dijital d�nya yarat�ld�: D�nya 3.0. �nsanlar zihinlerini y�kleyip orada ya��yor, ac� �ekmeden sonsuz bir �m�r s�r�yordu. Ben ise h�l� ger�ek bedenimdeydim. Herkesin �kurtulu�� dedi�i �ey bana bir tuzak gibi geliyordu.", "D�n gece bir terminale ba�land�m ve i�eriyi g�rd�m. �nsanlar g�l�yordu, �ark�lar s�yl�yordu. Ama arka planda bir duvar�n ard�nda, binlerce y�z sessizce a�l�yordu. Onlar� kimse g�rm�yordu.");
                case 10:
                    return ("Sikayet", 11, spriteListesi[1], spriteListesi[10], "Raskolnikov a��r ad�mlarla k�pr�ye y�neldi, d���nceler kafas�n�n i�inde u�uldayan bir f�rt�na gibiydi. ��inde bir yandan pi�manl�k, di�er yandan h�l� kendini hakl� g�rme duygusu kavga ediyordu. Etraf�ndaki kalabal���n u�ultusu ona uzak bir yank� gibi geliyordu, sanki herkes ba�ka bir d�nyadayd� da o tek ba��na farkl� bir ger�eklikte ya��yordu. Zaman zaman kalabal���n aras�ndan ��kan kahkahalar onu irkiltiyor,", " bir an i�in su�unun herkesin g�z�nde g�r�n�r oldu�unu san�yordu. Ancak kimse fark etmiyor, herkes kendi tela��ndayd�. Raskolnikov durup k�pr�n�n demirlerine yasland�, ba��n� e�ip suya bakt�. Ak�nt�n�n �zerinde y�zen k���k tahta par�alar� bile ona huzursuzluk veriyordu. �Ya ben de s�r�klenip gitseydim?� diye d���nd�. Ama i�inde bir yer h�l� direniyor, sanki bu d�nyaya ba�l� kalmas� gerekti�ini f�s�ld�yordu.");
            }
        }
        else
        {
            Debug.Log("elseye girdi");
            switch (olay)
            {
                case 1:
                    return ("Onay", 2, spriteListesi[3], spriteListesi[21], "Don Ki�ot, yorgun at�n�n �zerinde ufka bak�yordu. Ona g�re orada g��e y�kselen devler vard�; kollar�n� d�nd�rerek tehditler savuruyorlard�. Sancho Panza, sab�rs�zl�kla a��klamaya �al��t�: �Efendim, onlar sadece yel de�irmenleri!� Ama ��valye, hayallerinin g�c�ne s�k�ca tutunmu�tu. �Sancho, sen korkaks�n. K�l�c�n adaletini g�rm�yorsun,� dedi ve at�n� s�rd�.", "Koca kanatlar�n d�nmeye ba�lamas�yla toz bulutu y�kseldi, g�r�lt� kulaklar� doldurdu. Don Ki�ot m�zra��n� indirip sald�rd�. Sonu� h�sran oldu, yere y���ld� ama y�z�nde garip bir gurur vard�. ��nk� yenilgi bile onun g�z�nde kahramanl�k destan�n�n bir par�as�yd�. Sancho ise ba��n� sallad�, ama i�ten i�e efendisinin tutkusuna hayran kalmaktan kendini al�koyam�yordu.");
                case 2:
                    return ("Onay", 3, spriteListesi[3], spriteListesi[20], "Pip, sislerin aras�ndan y�kselen batakl�k yolunda y�r�rken ayak sesleri yank� yap�yordu. �ocuklu�unda ya�ad��� korkular, �imdi y�llar sonra bile i�inden ��km�yordu. Ge�mi�indeki esrarengiz yard�mc�n�n kim oldu�unu ��renmi�ti ama bu bilgi, kalbinde bir y�kten ba�ka bir �ey getirmemi�ti. Miss Havisham��n k�hne malikanesinde g�rd���", "o donmu� an� hat�rlad�k�a i�i �rperiyordu. Estella�n�n so�uk bak��lar�, ona bir zamanlar hissetti�i umutlar�n bo�una oldu�unu g�stermi�ti. Yine de kalbinin derinlerinde bir �ey h�l� onu affetmeye ve ba�lanmaya zorluyordu. Kendi yolunu se�mek zorundayd�, ge�mi�in zincirleriyle gelece�ini kaybetmemeliydi.");
                case 3:
                    return ("Onay", 4, spriteListesi[3], spriteListesi[18], "Tom, okuldan ka�man�n binbir yolunu d���n�yordu. Yaz�n s�ca��, nehir kenar�ndaki serin g�lgelik ve maceralar�n cazibesi derslerden �ok daha �ekiciydi. Arkada�� Huck ile bulu�up gizli planlar yap�yordu. Define aray��lar�, korsan oyunlar�, gizemli ma�aralar� Her �ey onlar�n hayal", "g�c�nde ger�ek oluyordu. Tom, �ocuk akl�yla d�nyan�n sonsuz bir macera alan� oldu�unu san�yordu. Ama ayn� zamanda b�y�menin, sorumluluklar�n ve hatalar�n g�lgesini de hissediyordu. Yine de �zg�rl���n tad�, b�t�n endi�elerin �n�ne ge�iyordu.");
                case 4:
                    return ("Onay", 5, spriteListesi[2], spriteListesi[13], "Crusoe, adan�n derinliklerinde yeni bir bar�nak ke�fetmi�ti. Ta� ve tahta par�alar�ndan yapt��� platform, ona hem g�venlik hem de y�kseklik sa�l�yordu. G�n boyu yiyecek arad�, bal�k tuttu, meyveleri toplad�. Ak�am g�ne� batarken, sessizli�i bozan tek �ey, uzak bir yerde duydu�u ku� c�v�lt�lar�yd�.", "��inde hem yaln�zl�k hem de gurur vard�; do�a ona hem ��retmen hem de rakip olmu�tu. Crusoe, elleriyle kaz� yaparken, yar�n i�in yeni stratejiler geli�tirdi, hayatta kalmak i�in her g�n yeni bir s�navd�.");
                case 5:
                    return ("Onay", 6, spriteListesi[3], spriteListesi[18], "Gulliver, Lilliput�un minik saraylar�n�n aras�nda y�r�rken kendini bir dev gibi hissetti. K���k insanlar onun ayaklar�n�n dibinde ko�u�turuyor, birbirleriyle f�s�lda��yorlard�. Bir kap�dan i�eri girdi�inde, minik mobilyalar ve k���k tablolar kar��s�nda hayranl�kla bakt�. ", "Fakat k�sa s�re sonra, onlar�n kurallar�n� anlamaya �al���rken k���k bir yanl�� hareketin b�y�k bir kriz yaratabilece�ini fark etti. Her ad�m�nda dikkatli olmas� gerekiyordu; Gulliver, g�c� ile sorumlulu�un ayn� anda var olabilece�ini anlad�.");
                case 6:
                    return ("Onay", 7, spriteListesi[3], spriteListesi[18], "Prens Andrey �ad�r�n�n �n�nde durup uzaklara bakt�. Ufukta toz bulutlar� y�kseliyor, sava��n yakla�t���n� haber veriyordu. ��inde garip bir dinginlik vard�. �nsan, �l�m�n bu kadar yak�n oldu�unu bilince ya�am�n en k���k ayr�nt�s�na bile farkl� bak�yordu. Bir yapra��n titremesi, uzaktaki atlar�n ki�nemesi, hepsi daha anlaml� geliyordu.", " Napolyon�un ordusu yakla��rken, Rus soylular�n�n �o�u h�l� zaferden emindi. Oysa Prens Andrey, kalbinde belirsiz bir kayg� ta��yordu. Ne zafer ne yenilgi, asl�nda hi�bir �eyin kal�c� olmad���n� biliyordu. �nsan ancak kendi i�inde buldu�u cesaretle ayakta kalabilirdi.");
                case 7:
                    return ("Sikayet", 8, spriteListesi[2], spriteListesi[13], "Beyaz Di��in kulaklar� dikle�ti, burun delikleri geni�ledi ve karla kapl� ormanda her sesi dikkatle dinledi. Bir dal k�r�ld�; uzaklardan gelen uluma sesi kulaklar�na �al�nd�. Bu ses, ona hem tehdit hem de merak uyand�r�yordu. Do�a sertti ve ac�mas�zd�; a�l�k, so�uk ve d��man her an bir tehlike olu�turuyordu. Annesi ona sadece temel bilgileri ��retmi�ti: avlanmay�, hayatta kalmay�, sald�r�lara kar�� kendini korumay�.", "Grey Beaver onu yak�ndan izliyordu; her hareketi �l��yor, bazen sert�e s�n�rlar�n� �iziyor, bazen yava��a besliyordu. Beyaz Di�, insanlarla tan��man�n farkl� bir deneyim oldu�unu anlamaya ba�lad�. G�zleri dikkatle etraf� tar�yor, i�g�d�leri ile yeni d�nyan�n kurallar�n� dengelemeye �al���yordu. Her g�n, yeni bir s�nav ve yeni bir ��renme f�rsat�yd�.");
                case 8:
                    return ("Sikayet", 9, spriteListesi[3], spriteListesi[19], "Surlar�n �n�nde toz duman i�inde beklerken kalbim g��s�mden f�rlayacak gibiydi. D��man ordusunun ate�leri geceyi g�nd�ze �eviriyordu. �ehrin i�inde ise sessizlik h�kimdi. Kiliselerde dualar y�kseliyor, �ocuklar annelerinin eteklerine saklan�yordu. Ben gen� bir askerdim,", "m�zra��m� s�k� s�k� kavram��t�m. Kumandan yan�m�za gelip �Bu �ehir d��erse biz de d��eriz,� dedi. O an, y�zy�llard�r dimdik duran ta�lar�n �zerindeki �atlaklar� fark ettim. Konstantiniyye yaln�zca ta�lardan de�il, hat�ralardan da in�a edilmi�ti. Ve o gece hat�ralar kanla yaz�lacakt�.");
                case 9:
                    return ("Onay", 10, spriteListesi[3], spriteListesi[21], "Jim, geminin g�vertesinde r�zg�r�n y�z�n� yalamas�na izin vererek, ufka bak�yordu. Haritada i�aretli noktaya yakla��rken, kafas�nda s�rekli �hazineyi kim �nce bulacak?� sorusu d�n�yordu. Long John Silver��n g�zlerinde zaman zaman", "dostane bir ���k parl�yor, ama Jim i�ten i�e bir hile seziyordu. Di�er m�rettebat�n f�s�lt�lar�, ipu�lar� ve s�ylentiler, Jim�in dikkatini da��t�yor; her ad�mda dikkatli olmas�n� gerektiriyordu. K���k bir hata, t�m yolculu�u riske atabilirdi.");
                case 10:
                    return ("Sikayet", 11, spriteListesi[2], spriteListesi[14], "Anna, b�y�k salonun i�inde y�r�rken herkesin bak��lar�n�n �zerine �evrildi�ini hissetti. Ama bu bak��larda k�skan�l�k m� vard�, hayranl�k m�, yoksa dedikoduya haz�r bir merak m�, kestiremiyordu. ��inde bir huzursuzluk, d��ar�dan bak�ld���nda zarif�e ta��d��� elbisenin alt�ndan y�kselen bir ���l�k gibi hissediliyordu. Vronski'nin g�zlerini g�rd���nde ise her �ey ", "sustu; kalabal���n u�ultusu, piyanonun melodisi, hatta kendi kalp at��lar� bile. Bir an i�in b�t�n bu d�nyan�n anlams�zl���n� kavrad�. Ne zenginlik, ne ��hret, ne de aile d�zeni� Hepsi bir yan�lsama gibi geliyordu. ��inden ge�enleri kimse bilemezdi, ��nk� y�z�nde her zamanki sakin tebess�m vard�. Yaln�zca g�zlerindeki g�lge, onun f�rt�nas�n� ele veriyordu.");
                case 11:
                    return ("Onay", 1, spriteListesi[3], spriteListesi[0], "", "");
            }
        }
        return ("Onay", 1, spriteListesi[0], spriteListesi[0], "", "");
    }
}

