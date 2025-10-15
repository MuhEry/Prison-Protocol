using System.Collections;
using TMPro;
using UnityEngine;

public class Sistem : MonoBehaviour
{
    [Header("Men�-Kitap Sprite'lar�")]
    public GameObject[] menu;
    public GameObject[] Kitaplar;
    public GameObject[] Mektuplar;
    public static bool panel = false;
    public GameObject haftaPanel;
    public GameObject mektupPanel;

    [Header("De�i�kenler")]
    public int hafta = 1;
    public double hata = -1;
    public double aile�hmali = 0;
    public double ilac�hmali = 0;
    public int sayac = 0;
    private int para = 0;
    private int paraDegisim = 0;
    private int birikim = 0;
    public int maas = 0;

    [Header("Statik De�i�kenler")]
    public static int TelOlay;
    public static int kritikHata;
    public static int olay = 0;
    
    [Header("Sonradan G�ncellenen ��erikler")]
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
    public MenuAc�c� menuAc�c�;

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
        menuAc�c�.MenuKapat();
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
            // Fazla hata yapt�n
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Yap�lan denetimlerde sorumluluklar�n� yerine getirmedi�in, kabul edilemiyecek kadar fazla hata yapt���n g�zlemlendi. ��ine son verildi";
            karartma.Karart();
        }
        else if (para < 0)
        {
            PanelKapat();
            // Ailene bakacak paran kalmad�
            TelSahne.Final = 1;
            TelSahne.tamMetin = "G�revlilerin ailelerine iyi bakmas� �nemli bir beklentidir. Ailenin temel ihtiya�lar�n� kar��layacak maddi durumu sa�layamad���n i�in i�ine son verildi.";
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
                //tblButon.SetActive(false);  easter egg sonradan da eri�ilebilcek
                menu[4].SetActive(true);
                aile�hmali--;
                bacakAnim.speed = 1.3f;
                break;  
                case 3:
                menu[3].SetActive(true);
                menu[5].SetActive(true);
                ilac�hmali -= 2;
                bacakAnim.speed = .5f;
                break;
                case 4:
                menu[3].SetActive(true);
                ilac�hmali--;
                bacakAnim.speed = 1.4f;
                break;
                case 5:
                menu[3].SetActive(true);
                ilac�hmali--;
                bacakAnim.speed = .5f;
                break;
                case 6:
                bacakAnim.speed = 1;
                break;
                case 7:
                menu[6].SetActive(true);
                aile�hmali--;
                bacakAnim.speed = .5f;
                break;
                case 8:
                menu[7].SetActive(true);
                aile�hmali--;
                break;
                case 9:
                tlfnButon.SetActive(true);
                menu[7].SetActive(true);
                aile�hmali--;
                break;
                case 10:
                Debug.Log("OYUNB�TT�");
                menu[7].SetActive(true);
                menu[8].SetActive(true);
                aile�hmali-=2;
                break;
        }
    }
    public void HaftaYeni()
    {
        PanelKapat();
        if (ilac�hmali > 1)
        {
            //K�z �ld�
            TelSahne.Final = 1;
            TelSahne.tamMetin = "G�revlilerin ailelerine iyi bakmas� �nemli bir beklentidir. Bir Aile ferdinin ihmaller sonucu vefat etmesi kabul edilemez. ��ine son verildi.";
            karartma.Karart();
        }
        else if (aile�hmali > 2)
        {
            //Aile ihmal edildi
            TelSahne.Final = 1;
            TelSahne.tamMetin = "G�revlilerin ailelerine iyi bakmas� �nemli bir beklentidir. Ailene yeterince �nem vermedi�ini d���nd���m�z i�in i�ine son verildi.";
            karartma.Karart();
        }else if (hafta==10)
        {
            TelSahne.Final = 1;
            TelSahne.tamMetin = "Genel af ��kar�ld���ndan dolay� az say�da kalan mahkumlar� da ba�ka bir hapishaneye transfer edip buray� kapataca��z. Emeklerin i�in te�ekk�rler.";
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
                case 1: // Hapis �ikayet mektubu onaylan�rsa
                    TelSahne.tamMetin = "Dikkatimizi �eken bir durum var.  �st Makamlara hakk�m�zda �ikayet gelmi�. Bu durum seni zan alt�nda b�rak�yor. Bir kez daha b�yle bir gev�eklik g�sterirsen, i�ini kaybedersin.";
                    break;
                case 2: // Madde iste�i �ikayet edilirse
                    TelSahne.tamMetin = "�ikayetin �zerine y�r�t�len takip sonucunda b�y�k bir uyu�turucu deposu ele ge�irildi. \r\nDikkatin ve ba�ar�n� �d�llendirmek i�in bu hafta ekstra prim hesab�na yat�r�lcak.";
                    maas += 10;
                    break;
                case 3: // Maddeli kitap onaylan�rsa
                    TelSahne.tamMetin = "��eriye uyu�turucu sokulmu� ve bir mahkum firar etmi�. Umar�m g�revini ciddiyetle yap�yorsundur. Bu i�e kar��an �� gardiyan tespit edildi ve sonlar�n�n iyi olmad���n� bilmelisin.";
                    break;
                case 4: // B��ak onaylan�rsa
                    TelSahne.tamMetin = "D�n ak�am bir mahkum b��aklanarak �ld�r�ld�. Bu t�rden bir ihmal kabul edilemez. �mkanlar k�s�tl� oldu�u i�in sana bir �ans daha tan�yoruz. Bir daha olursa i�in biter.";
                    break;
                case 5: // ***SES DE����M�*** B��ak reddedilirse
                    TelSahne.tamMetin = "Can�m, son g�nlerde evimizin �n�nde arabalar duruyor, bizi g�zetliyorlar gibi hissediyorum, �ok rahats�z edici. Ne oldu�unu bilmiyorum ama bu mahallede g�vende de�iliz.";
                    break;
                case 6: // �kinci kez b��ak reddedilirse
                    TelSahne.tamMetin = "�ste�in �zerine ailen koruma alt�na al�nd�. Bir s�re polisler evinin etraf�n� kola�an edecek. G�revini d�zg�n yapt���n s�rece endi�elenmene gerek yok. ";
                    break;
                case 7: // Telefon kabul�
                    TelSahne.tamMetin = "Bir mahkumun �zerinde telefon bulundu. Bunun nas�l i�eri girdi�ini bilmiyoruz, ancak baz� y�neticilerin g�z� senin �zerinde. Bu aralar ekstra dikkatli olman� tavsiye ederim";
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
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\nHerhangi bir sembol bulunanlar";
                break;
            case 5:
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\nHerhangi bir sembol bulunanlar\r\nGri kapakl� kitaplar";
                break;
            case 6:
                SX.SetActive(true);
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\nGri kapakl� kitaplar\r\n   sembol� i�erenler";
                break;
            case 7:
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\nGri ve mavi kapakl� kitaplar\r\n   sembol� i�erenler";
                break;
            case 8:
                SX.SetActive(false);
                SH.SetActive(true);
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\n   sembol� i�erenler";
                break;
            case 9:
                SK.SetActive(true);
                kurallar.text = "�mha edilmesi gereken mektuplar:\r\nT�rk�e d���nda i�erikler\r\nHakaret, bela, tehdit mesajlar�\r\nHapisle ilgili �ikayetler\r\n\r\n�ikayet edilmesi gereken mektuplar:\r\nSu� i�erikli ��pheli mesajlar\r\n\r\nRet verilmesi gereken kitaplar:\r\nSiyasi i�erikler\r\n   ve    sembol� i�erenler";
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
                mektup1.mesaj = "Kimden: Bremer Subkova (Mahkum #004)\r\nKime: �med Semedov\r\n\r\n�r�n� ald�k aferin iyi i� ��kard�n. Abim yak�nda yan�n�zda olur. Benim i�in endi�elenmeyin.";
                mektup1.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Onay");
                mektup1.olay = 26;
                break;
            case 3:
                mektup2.mesaj = "Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nAferin, do�ru olan� yapt�n memur bey.\r\n";
                mektup2.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Imha");
                mektup2.olay =50;
                break;
            case 4:
                mektup3.mesaj = "Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\n\r\nAferin.";
                mektup3.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), "Imha");
                mektup3.olay =52;
                break;
            case 5:
                mektup4.mesaj = "Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karada�\r\n\r\nCan�m benim te�ekk�rler kitap i�in <3\r\nHer okudu�umda seni d���ncem";
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
            ilac�hmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 5;
            ilac�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void OkulGiderleri()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 10;
            aile�hmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 10;
            aile�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Tas�nma()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 25;
            aile�hmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 25;
            aile�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Komur()
    {
        if (menu[11].activeSelf)
        {
            menu[11].SetActive(false);
            paraDegisim += 10;
            aile�hmali++;
        }
        else
        {
            menu[11].SetActive(true);
            paraDegisim -= 10;
            aile�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Televizyon()
    {
        if (menu[12].activeSelf)
        {
            menu[12].SetActive(false);
            paraDegisim += 10;
            aile�hmali++;
        }
        else
        {
            menu[12].SetActive(true);
            paraDegisim -= 10;
            aile�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
    public void Buzdolab�()
    {
        if (menu[12].activeSelf)
        {
            menu[12].SetActive(false);
            paraDegisim += 15;
            aile�hmali++;
        }
        else
        {
            menu[12].SetActive(true);
            paraDegisim -= 15;
            aile�hmali--;
        }
        menu[9].GetComponent<TMP_Text>().text = "Kalan Para: " + (para + paraDegisim);
    }
}