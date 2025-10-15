using System.Collections;
using TMPro;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    [Header("Menü-Kitap Sprite'larý")]
    public GameObject[] menu;
    public GameObject[] Kitaplar;
    public GameObject[] Mektuplar;
    public static bool panel = false;
    public GameObject haftaPanel;
    public GameObject mektupPanel;

    [Header("Deðiþkenler")]
    public int hafta = 1;
    public double hata = -1;
    public double aileÝhmali = 0;
    public double ilacÝhmali = 0;
    public int sayac = 0;
    private int para = 0;
    private int paraDegisim = 0;
    private int birikim = 0;
    public int maas = 0;

    [Header("Statik Deðiþkenler")]
    public static int TelOlay;
    public static int kritikHata;
    public static int olay = 0;
    
    [Header("Sonradan Güncellenen Ýçerikler")]
    public Mektup mektup1;
    public Mektup mektup2;
    public Mektup mektup3;
    public Mektup mektup4;
    public Kitap kitap;
    public Sprite maddeliKitapSprite;

    [Header("Kural Mektubu")]
    public TMP_Text kurallar;
    public GameObject SX;
    public GameObject SH;
    public GameObject SK;

    [Header("Ara Sahne")]
    public Karartma karartma;
    public Kural kural;
    public Surukle surukle;
    public SurukleEsya surukleEsya;
    public MenuAcýcý menuAcýcý;

    public GameObject bacak;
    private Animator bacakAnim;

    public GameObject tblButon;
    public GameObject tlfnButon;

    void Start()
    {
        bacakAnim = bacak.GetComponent<Animator>();
        if (haftaPanel != null)
            haftaPanel.SetActive(false);
    }
    void PanelKapat()
    {
        kural.KuralPanelKapat();
        mektupPanel.SetActive(false);
        surukleEsya.EsyaPaneliKapat();
        menuAcýcý.MenuKapat();
        haftaPanel.SetActive(false);
    }
    public void HamleDogru()
    {
        maas +=5 ;
        Sayac();
    }
    public void HamleYanlis()
    {
        hata++;
        Sayac();
    }
    public void Sayac()
    {
        sayac++;
        if(sayac == 8)
        {
            Debug.Log("Hafta Bitti");
            maas -= 5;
            HaftaSonu();
        }
    }
    public void HaftaSonu()
    {
        menu[10].SetActive(true);
        para = birikim + maas -20;
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + para;
        HaftaKontrol();
        if (kritikHata > 1 || hata > 3)
        {
            PanelKapat();
            // Fazla hata yaptýn
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Yapýlan denetimlerde sorumluluklarýný yerine getirmediðin, kabul edilemiyecek kadar fazla hata yaptýðýn gözlemlendi. Ýþine son verildi";
            karartma.Karart();
        }
        else if (para < 0)
        {
            PanelKapat();
            // Ailene bakacak paran kalmadý
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Görevlilerin ailelerine iyi bakmasý önemli bir beklentidir. Ailenin temel ihtiyaçlarýný karþýlayacak maddi durumu saðlayamadýðýn için iþine son verildi.";
            karartma.Karart();
        }
        else
        {
            haftaPanel.SetActive(true); 
            panel = true;
        }
        menu[0].GetComponent<TMP_Text>().text = "Birikim: " + birikim;
        menu[1].GetComponent<TMP_Text>().text = "Gelir: " + maas;
        switch (hafta) 
        {
            case 1:
                tblButon.SetActive(true);
                break;
                case 2:
                //tblButon.SetActive(false);  easter egg sonradan da eriþilebilcek
                menu[4].SetActive(true);
                aileÝhmali--;
                bacakAnim.speed = 1.3f;
                break;  
                case 3:
                menu[3].SetActive(true);
                menu[5].SetActive(true);
                ilacÝhmali -= 2;
                bacakAnim.speed = .5f;
                break;
                case 4:
                menu[3].SetActive(true);
                ilacÝhmali--;
                bacakAnim.speed = 1.4f;
                break;
                case 5:
                menu[3].SetActive(true);
                ilacÝhmali--;
                bacakAnim.speed = .5f;
                break;
                case 6:
                bacakAnim.speed = 1;
                break;
                case 7:
                menu[6].SetActive(true);
                aileÝhmali--;
                bacakAnim.speed = .5f;
                break;
                case 8:
                menu[7].SetActive(true);
                aileÝhmali--;
                break;
                case 9:
                tlfnButon.SetActive(true);
                menu[7].SetActive(true);
                aileÝhmali--;
                break;
                case 10:
                Debug.Log("OYUNBÝTTÝ");
                menu[7].SetActive(true);
                menu[8].SetActive(true);
                aileÝhmali-=2;
                break;
        }
    }
    public void HaftaYeni()
    {
        PanelKapat();
        if (ilacÝhmali > 1)
        {
            //Kýz öldü
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Görevlilerin ailelerine iyi bakmasý önemli bir beklentidir. Bir Aile ferdinin ihmaller sonucu vefat etmesi kabul edilemez. Ýþine son verildi.";
            karartma.Karart();
        }
        else if (aileÝhmali > 2)
        {
            //Aile ihmal edildi
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Görevlilerin ailelerine iyi bakmasý önemli bir beklentidir. Ailene yeterince önem vermediðini düþündüðümüz için iþine son verildi.";
            karartma.Karart();
        }else if (hafta==10)
        {
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Genel af çýkarýldýðýndan dolayý az sayýda kalan mahkumlarý da baþka bir hapishaneye transfer edip burayý kapatacaðýz. Emeklerin için teþekkürler.";
            karartma.Karart();
        }
        birikim = para + paraDegisim;
        sayac = 0;
        maas = 0;
        hata -= 2.2;
        hafta++;
        paraDegisim = 0;
        Spawner();
        kuralGuncelleme(hafta);
        TelKontrol();
    }
    void TelKontrol()
    {
        if (TelOlay != 0)
        {
            switch(TelOlay)
            {
                case 1: // Hapis þikayet mektubu onaylanýrsa
                    TelSahne.tamMetin = "Dikkatimizi çeken bir durum var.  Üst Makamlara hakkýmýzda þikayet gelmiþ. Bu durum seni zan altýnda býrakýyor. Bir kez daha böyle bir gevþeklik gösterirsen, iþini kaybedersin.";
                    break;
                case 2: // Madde isteði þikayet edilirse
                    TelSahne.tamMetin = "Þikayetin üzerine yürütülen takip sonucunda büyük bir uyuþturucu deposu ele geçirildi. \r\nDikkatin ve baþarýný ödüllendirmek için bu hafta ekstra prim hesabýna yatýrýlcak.";
                    maas += 10;
                    break;
                case 3: // Maddeli kitap onaylanýrsa
                    TelSahne.tamMetin = "Ýçeriye uyuþturucu sokulmuþ ve bir mahkum firar etmiþ. Umarým görevini ciddiyetle yapýyorsundur. Bu iþe karýþan üç gardiyan tespit edildi ve sonlarýnýn iyi olmadýðýný bilmelisin.";
                    break;
                case 4: // Býçak onaylanýrsa
                    TelSahne.tamMetin = "Dün akþam bir mahkum býçaklanarak öldürüldü. Bu türden bir ihmal kabul edilemez. Ýmkanlar kýsýtlý olduðu için sana bir þans daha tanýyoruz. Bir daha olursa iþin biter.";
                    break;
                case 5: // ***SES DEÐÝÞÝMÝ*** Býçak reddedilirse
                    TelSahne.tamMetin = "Caným, son günlerde evimizin önünde arabalar duruyor, bizi gözetliyorlar gibi hissediyorum, çok rahatsýz edici. Ne olduðunu bilmiyorum ama bu mahallede güvende deðiliz.";
                    break;
                case 6: // Ýkinci kez býçak reddedilirse
                    TelSahne.tamMetin = "Ýsteðin üzerine ailen koruma altýna alýndý. Bir süre polisler evinin etrafýný kolaçan edecek. Görevini düzgün yaptýðýn sürece endiþelenmene gerek yok. ";
                    break;
                case 7: // Telefon kabulü
                    TelSahne.tamMetin = "Bir mahkumun üzerinde telefon bulundu. Bunun nasýl içeri girdiðini bilmiyoruz, ancak bazý yöneticilerin gözü senin üzerinde. Bu aralar ekstra dikkatli olmaný tavsiye ederim";
                    break;
            }
            karartma.Karart();
            TelOlay = 0;
        } 
    }
    void kuralGuncelleme(int hafta)
    {
        switch (hafta)
        {
            case 3:
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\nHerhangi bir sembol bulunanlar";
                break;
            case 5:
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\nHerhangi bir sembol bulunanlar\r\nGri kapaklý kitaplar";
                break;
            case 6:
                SX.SetActive(true);
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\nGri kapaklý kitaplar\r\n   sembolü içerenler";
                break;
            case 7:
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\nGri ve mavi kapaklý kitaplar\r\n   sembolü içerenler";
                break;
            case 8:
                SX.SetActive(false);
                SH.SetActive(true);
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\n   sembolü içerenler";
                break;
            case 9:
                SK.SetActive(true);
                kurallar.text = "Ýmha edilmesi gereken mektuplar:\r\nTürkçe dýþýnda içerikler\r\nHakaret, bela, tehdit mesajlarý\r\nHapisle ilgili þikayetler\r\n\r\nÞikayet edilmesi gereken mektuplar:\r\nSuç içerikli þüpheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi içerikler\r\n   ve    sembolü içerenler";
                break;
        }
    }
    public void Spawner()
    {
        float rastgeleKonumXKitap = Random.Range(1f, 2f);
        float rastgeleKonumXMektup = Random.Range(-7f, -6f);
        float rastgeleKonumY = Random.Range(-0.5f, -2.5f);
        for (int i = 0; i < 4; i++)
        {
            Kitaplar[i].SetActive(true);
            Kitaplar[i].transform.position = new Vector3(rastgeleKonumXKitap + (i * 1.5f), rastgeleKonumY, 0f); ;
        }
        for (int i = 0; i < 4; i++)
        {
            Mektuplar[i].SetActive(true);
            Mektuplar[i].transform.position = new Vector3(rastgeleKonumXMektup + (i* 1.3f), rastgeleKonumY, 0f); ;
        }
    }
    private void HaftaKontrol()
    {
        for (int i = 3; i < 9; i++)
        {
            menu[i].SetActive(false);
        }
        menu[11].SetActive(false);
        menu[12].SetActive(false);
        KitapMektupDegisimi();
        olay = 1;
    }
    public void KitapMektupDegisimi()
    {
        switch (olay)
        {
            case 2:
                mektup1.mesaj = "Kimden: Bremer Subkova (Mahkum #004)\r\nKime: Ýmed Semedov\r\n\r\nÜrünü aldýk aferin iyi iþ çýkardýn. Abim yakýnda yanýnýzda olur. Benim için endiþelenmeyin.";
                mektup1.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Onay");
                mektup1.olay = 26;
                break;
            case 3:
                mektup2.mesaj = "Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nAferin, doðru olaný yaptýn memur bey.\r\n";
                mektup2.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Imha");
                mektup2.olay =50;
                break;
            case 4:
                mektup3.mesaj = "Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\n\r\nAferin.";
                mektup3.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Imha");
                mektup3.olay =52;
                break;
            case 5:
                mektup4.mesaj = "Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karadað\r\n\r\nCaným benim teþekkürler kitap için <3\r\nHer okuduðumda seni düþüncem";
                mektup4.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Onay");
                mektup4.olay =12;
                break;
            case 6:
                kitap.hedefKutu = (Kitap.HedefKutu)System.Enum.Parse(typeof(Kitap.HedefKutu), "Sikayet");
                kitap.kitapAcik = maddeliKitapSprite;
                kitap.sayfa2 = "";
                break;
        }
    }

    /*public void AileGiderleri()
    {
        if (menu[10].activeSelf)
        {
            menu[10].SetActive(false);
            paraDegisim += 20;
        }
        else
        {
            menu[10].SetActive(true);
            paraDegisim -= 20;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }*/
    public void Ilaclar()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 5;
            ilacÝhmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 5;
            ilacÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void OkulGiderleri()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 10;
            aileÝhmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 10;
            aileÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Tasýnma()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 25;
            aileÝhmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 25;
            aileÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Komur()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 10;
            aileÝhmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 10;
            aileÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Televizyon()
    {
        if (menu[12].activeSelf)
        {
            menu[12].SetActive(false);
            paraDegisim += 10;
            aileÝhmali++;
        }
        else
        {
            menu[12].SetActive(true);
            paraDegisim -= 10;
            aileÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Buzdolabý()
    {
        if (menu[12].activeSelf)
        {
            menu[12].SetActive(false);
            paraDegisim += 15;
            aileÝhmali++;
        }
        else
        {
            menu[12].SetActive(true);
            paraDegisim -= 15;
            aileÝhmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
}