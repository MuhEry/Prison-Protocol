using UnityEngine;

public class MektupKontrol : MonoBehaviour
{

public (string icerik, string hedefKutu, int olayID) Kontrol(int olay, string kutu)
{
    if (olay <= 20)
    {
        switch (olay)
        {
            case 1:
                if (kutu == "Onay")
                {
                    return ("Kimden: Mert Y�ld�z (Mahkum #215)\r\nKime: Fatma Y�ld�z\r\n\r\nBende sab�rs�zl�kla bulu�aca��m�z g�n� bekliyorum. Bu lanet yerden kurtulmama sadece bir ay kald�. Herkese selam s�yle, G�r���r�z\r\n", "Imha", 2);
                }
                else
                {
                    return ("Kimden: Mert Y�ld�z (Mahkum #215)\r\nKime: Fatma Y�ld�z\r\n\r\nUzun zamand�r sizden mektup bekliyorum anne iyi misiniz? Umar�m ba��n�za bir �ey gelmemi�tir. En k�sa zamanda haber yollay�n.\r\n", "Onay", 3);
                }
            case 2:
                    return ("Kimden: �brahim Ta�\r\nKime: Mert Y�ld�z (Mahkum #215)\r\n\r\nDostum sana g�zel s�prizler haz�rlad�k ��kt���n g�n� iple �ekiyoruz g�r��mek �zere.", "Onay", 4);
            case 3:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Fatma Y�ld�z\r\nKime: Mert Y�ld�z (Mahkum #215)\r\n\r\nCan�m o�lum,\r\n\r\nHepimiz iyiyiz merak etme. �nceden mektup yollam��t�k ama g�r�nen o ki sana ula�mam��. Umar�m sende iyisindir. Evine d�nmene az kald� yavrum g�r���r�z.", "Onay", 4);
                    }
                    else
                    {
                        return ("Kimden: �brahim Ta�\r\nKime: Mert Y�ld�z (Mahkum #215)\r\n\r\nDostum sana g�zel s�prizler haz�rlad�k ��kt���n g�n� iple �ekiyoruz g�r��mek �zere.", "Onay", 4);
                    }
            case 4:
                    return ("Kimden: Ahmet Mavi\r\nKime: �a�r� Minikku� (Mahkum #108)\r\n\r\nSevgili dostum, in�allah keyfin yerindedir. Sana anlatt���m bi k�z vard� ona a��lmaya karar verdim. bana g�zel bir �iir yazar m�s�n k�za okumam i�in. �imdiden sa�olas�n.", "Onay", 6);
            case 6:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: �a�r� Minikku� (Mahkum #108)\r\nKime: Ahmet Mavi\r\n\r\nTabii dostum ne demek zaten can�m s�k�l�yordu.\r\n\r\nHi� s�k�lmayaca��m bir g�steri\r\n��inde kayboldu�um bu g�zlerin\r\nAd�n� hecelerken ge�en geceler\r\nBu �zlemin bitmesin mi sence de\r\n�zlem yang�n�m kuca��nda s�ns�n\r\nve var sana adanacak bir �mr�m\r\nSensiz d���nemiyorum ben kimim?\r\nKabul eder misin olmay� biricik sevgilim", "Onay", 7);
                    }
                    else
                    {
                        return ("Kimden: �a�r� Minikku� (Mahkum #108)\r\nKime: Ahmet Mavi\r\n\r\nDostum sana anlatt���m k�z�n kap�s�na b�rak�r m�s�n bunu.\r\n\r\n�n�me ��kan b�t�n yoku�larda Nasip dedim, y�r�\r\nG�nl�m ate�lerde, git, dokunma asitlerin ��r�r\r\nY�zeysel bi ezber i�in fazla sevdim seni\r\n�yi ki hayat�mda yoksun art�k basitlerin g�l�.", "Onay", 8);
                    }
            case 7:
                    return ("Kimden: Ahmet Mavi\r\nKime: �a�r� Minikku� (Mahkum #108)\r\n\r\nTe�ekk�rler dostum. K�z kabul etmedi Allah belas�n� versin. Neyse senin �iirin gayet g�zeldi, sa�olas�n.", "Imha", 9);
            case 8:
                    return ("Kimden: Ahmet Mavi\r\nKime: �a�r� Minikku� (Mahkum #108)\r\n\r\nTamam dostum b�rak�r�m. Benim s�yledi�im �iiri yollamana gerek kalmad� k�z ayr�ld� benden. yinede te�ekk�rler.", "Onay", 9);
            case 9:
                    return ("Kimden: Hilal Karada�\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nA�k�m seni �ok �zl�yorum. Can�n s�k�lmas�n diye sevdi�in mavi kitab� yollad�m. Umar�m sana ula��r hayat�m. hemencecik oku, �ok seviyorum seni.", "Onay", 11);
            case 11:
                    return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karada�\r\n\r\nCan�m benim, seni �ok �zledim biliyorum uzaktas�n ama en yak�n zamanda ziyarete gel l�tfen.", "Onay", 13);
            // Kitab�n durumuna g�re sonradan g�ncellencek
                case 12:
                    Sistem.TelOlay = 7;
                    return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karada�\r\n\r\nA�k�m yollad���n �kitab�� malesef ald�lar.\r\nbol bol mektup yaz seviyorum seni.", "Onay", 14);
            case 13:
                    return ("Kimden: Hilal Karada�\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nA�k�m galiba i�ler planlad���m gibi gitmedi, neyse haftaya per�embe gibi seni ziyarete gelicem, g�r���r�z bal�m", "Onay", 15);
            case 14:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Hilal Karada�\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nYaa nas� buldular, yapcak bi�e yok ask�m daha mektup yazarak �zlem gidermeye �al��caz :( Birka� hafta sonra trenle gelcem ziyaretine a�k�m �ok �zledim seni.", "Onay", 16);
                    }
                    else
                    {
                        return ("Kimden: Hilal Karada�\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nA�k�m haber alamad�m senden yaziyim dedim bir sorun mu oldu? Herhalde yollad���m kitap planlad���m gibi gitmedi, neyse bal�m seviyorum seni mektup yaz en az�ndan, �pt�m g�r���r�z.", "Onay", 16);
                    }
            case 15:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karada�\r\n\r\nGel a�k�m �ok �zledim g�zel y�z�n�. Sab�rs�zl�kla bekliyorumm. Dikkat et kendine, per�embe g�r���r�zz", "Onay", 16);
                    }
                    else
                    {
                        return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karada�\r\n\r\nHilal neden bi�e yazmad�n bi sorun mu var?\r\nEndi�eleniyorum bana s�k s�k mektup yaz iyi misin hayat�m?? Burada sadece seni d���nerek vakit ge�iyorum.", "Onay", 16);
                    }
            case 16:
                    return ("Kimden: Sercan �pek�i\r\nKime: Volkan Ayvaz (Mahkum #313)\r\n\r\nSelam dostum, i�eride olsan da ritmin h�l� sokaklarda �al�yor. Moralin bozulmas�n, d��ar� ��kt���nda hep beraber st�dyoya d�nece�iz. Senin sesini kimse susturamaz, bunu unutma.", "Onay", 19);
            case 19:
                    return ("", "Onay", 2);
        }
    }
    else if (olay <= 44)
    {
        switch (olay)
        {
            case 21:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: �med Semedov\r\n\r\nBana M.yolundaki depodan �r�n yollay�n ben ��kman�n yolunu bulurum. ��kt���m zaman Zubkov diye biri kalmicak.", "Sikayet", 22);
                    }
                    else
                    {
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: �med Semedov\r\n\r\n�med bana M. yolundaki depodan mal yolla ,bir �ekilde i�eri sokabilirsen buradan ��kabilirim. Dikkat et", "Sikayet", 22);
                    }
            case 22:
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 6;
                        return ("Kimden: �med Semedov\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\n�r�n� yollad�k patron. Umar�m miktar� yeterlidir.", "Onay", 23);
                    }
                    else if (kutu == "Sikayet")
                    {
                        Sistem.TelOlay = 2;
                        return ("Kimden: S.S.\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\nPatron, �med yakaland� ve bir depomuzu kaybettik. Kimse kalmad�. Ne yapaca��m� bilemiyorum.", "Onay", 24);
                    }
                    else
                    {
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: �med Semedov\r\n\r\n��eride durumlar k�t�le�iyor neden dedi�imi yollamad�n�z? ��ler iyice ��kmaza girdi.", "Onay", 25);
                    }
            case 23:
                    return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: �med Semedov\r\n\r\nYapaca��n�z i�e ... mal yakalanm�� ve tekrar su�lama a��ld� �st�me. Buraya kadarm��.", "Onay", 26);
                    // Kitab�n durumuna g�re sonradan g�ncellencek
            case 24:
                    return ("Kimden: Bremer Subkova (Mahkum #004)\r\nKime:  Samed Sbarrov\r\n\r\nAbimi �st d�zey bir hapishaneye sevk ettiler.  Elimizden gelen bir �ey kalmad�. Buraya kadarm��, sende uzaklara git.", "Onay", 26);
            case 25:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: �med Semedov\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\nNe yollamam�z gerek patron, bize herhangi bir bilgi gelmedi.", "Onay", 26);
                    }
                    else
                    {
                        return ("Kimden: Melike Kayaalp\r\nKime: �smail Kayaalp (Mahkum #003)\r\n\r\n�smail, senden utan�yorum. Kom�ular�n y�z�ne bakam�yorum. Bari �ocuklar�n gelece�ini d���nseydin. Yine de ne olursa olsun, dua ediyorum sana.", "Onay", 26);
                    }
            case 26:
                    return ("Kimden: Bahad�r Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nSenin anlatt���n i� vard� ya, OLDU. Anlatt���ndan daha da karl� ilerliyor �uan. Ayr�ca s�yledi�in gibi senin arabay� satt�m, bu gidi�le sen ��kana kadar daha iyisini al�r�z.", "Onay", 31);
            case 31:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahad�r Bulut\r\n\r\nHelal be sana, gelen paray� da bo�a verme i�i b�y�t arabay� daha sonra da al�r�z acelesi yok. Benim bir defterim vard� 2. �ekmecede, defterde i�le ilgili planlar�m vard� okursan belki akl�na bir ka� yeni fikir daha gelir", "Onay", 32);
                    }
                    else
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahad�r Bulut\r\n\r\nDostum i�le ilgili geli�me var m�? En son ziyarete geldi�inde baya heyecanl�yd�n bu i� i�in. Umar�m �al��maya ba�lam��s�nd�r.", "Onay", 33);
                    }
            case 32:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Bahad�r Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nDefterini buldum baya g�zel ipu�lar� varm��. ��ler gayet yolunda gidiyor merak etme. Sen ��kt���nda i�leri daha da b�y�t�r bir ofis bile a�ar�z belki.", "Onay", 34);
                    }
                    else
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahad�r Bulut\r\n\r\nDostum i�le ilgili geli�me var m�? En son anlatt���nda baya g�zel gidiyordu i�ler. Umar�m her �ey yolundad�r.", "Onay", 34);
                    }
            case 33:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Bahad�r Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nSana bir mektup yollam��t�m ula�mad� herhalde. ��ler gayet yolunda gidiyor merak etme. Sen ��kt���nda i�leri daha da b�y�t�r bir ofis bile a�ar�z belki. Ayr�ca s�yledi�in gibi senin arabay� sat�p paray� i�e yat�rd�m.", "Onay", 34);
                    }
                    else
                    {
                        return ("Kimden: Bahad�r Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nKarde�im arabay� satmama m� k�zd�n? Sen s�ylemi�tin b�yle bi durumda satabilirsin diye. Merak etme tekrar al�r�z araban�", "Onay", 34);
                    }
            case 34:
                    return ("Kimden: Adile ��l\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nBenden haber bekleme art�k. Ben kendi yoluma gidiyorum, kendine iyi bak.", "Onay", 38);
            case 38:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Enes Hoca (Mahkum #187)\r\nKime: Adile ��l\r\n\r\nNe diyeyim. Hakk�n varsa helal et. Ben i�eride kald�m, hayat seni beklemez", "Onay", 39);
                    }
                    else
                    {
                        return ("Kimden: Adile ��l\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nHi� tepki vermedin. Demek ki s�ylediklerim do�ruymu�. Bu i� burada bitti.", "Onay", 40);
                    }
            case 39:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Adile ��l\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nHelal olsun her �eye ra�men g�zel zamanlard�. Allah�a emanet ol, elveda", "Onay", 41);
                    }
                    else
                    {
                        return ("Kimden: Adile ��l\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nAllah belan� versin ba�ka bi�e demiyorum.", "Imha", 41);
                    }
            case 40:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Enes Hoca (Mahkum #187)\r\nKime: Adile ��l\r\n\r\nNe tepkisi neyden s�z ediyorsun? Neyse ne senin bu triplerinle u�ra�amam art�k bana hi� bir �ey yazma. Elveda", "Onay", 41);
                    }
                    else
                    {
                        return ("Kimden: Adile ��l\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nAllah belan� versin ba�ka bi�e demiyorum.", "Imha", 41);
                    }
            case 41:
                    return ("Kimden: Wanda Silva\r\nKime: Marco Silva (Mahkum #297)\r\n\r\nPresta toda tu atenci�n ahora:\r\nUn burro com�a berros y el perro se los rob�. El burro lanz� un rebuzno y el perro al barro cay�.\r\n11 12 13 14 96  121 52 22 44 43  21 92 183  31 46 83 202 131", "Imha", 44);
            case 44:
                break;
            }
    }
    else if (olay <= 61)
    {
        switch (olay)
        {
            case 45:
                    if (kutu == "Onay")
                    {
                        Sistem.kritikHata++;
                        Sistem.TelOlay = 1;
                        return ("Kimden: Mustafa Emir Erol\r\nKime: H�seyin Hamsi (Mahkum #061)\r\n\r\nMesaj�n� ald�m gerekli i�lemleri yapt�m, umar�m sistem biraz d�zelir.", "Onay", 46);
                    }
                    else
                    {
                        return ("Kimden: Elif �nci\r\nKime: Selim �nci (Mahkum #019)\r\n\r\nCan�m babam, sana resim �izdim �ok g�zel oldu. ��k�nca sana g�stericem. Annemle seni �ok �zledik, g��l� kal.", "Onay", 46);
                    }
            case 46:
                    return ("Kimden: \r\nKime: Kureyhan (Mahkum #000)\r\n\r\n24121518281181714629518142517 \r\n2112221 22 212 12222", "Imha", 48);
            case 48:
                    return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nYE��L K�TABI ��ER� AL MEMUR.\r\n\r\n", "Imha", 49);
            case 49:
                   return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nYE��L K�TABI ��ER� AL.\r\nBU SON UYARIMIZ.", "Imha", 51);
                    // Kitab�n durumuna g�re sonradan g�ncellencek
            case 50:
                    return ("Kimden: Tar�k Yal�l� (Mahkum #101)\r\nKime: Hayri Yal�l�\r\n\r\nO�lum, umar�m iyisinizdir. D�kkanda i�ler yolunda m�? bi ihtiyac�n�z olursa amcana s�yle.", "Onay", 52);
            case 51:
                    return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\n...", "Imha", 52);
                    // Kitab�n durumuna g�re sonradan g�ncellencek
            case 52:
                    return ("Kimden: Haidi S�\r\nKime: Ellen Mask(Mahkum #270)\r\n\r\nEllen, on lit ton nom dans les journaux tous les jours. Je n'en croyais pas mes yeux quand je t'ai vue accus�e de corruption. Tu essayais juste d'empirer les choses. Je te crois, ma ch�re, et j'esp�re que tu sortiras bient�t.", "Imha", 55);
            case 55:
                    return ("Kimden: �mer Ethem Kaya\r\nKime: Alaattin Erku� (Mahkum #071)\r\n\r\nDostum paraya ihtiyac�n oldu�unu s�ylesen sana yard�m ederdik neden b�yle bir i�e bula�t�n. Neyse ki uzun bir ceza vermediler. ��kt���nda i�leri yoluna koyaca��z merak etme", "Onay", 56);
            case 56:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Alaattin Erku� (Mahkum #071)\r\nKime: �mer Ethem Kaya\r\n\r\nYan�mda oldu�un i�in te�ekk�r ederim. Bende anlamad�m b�yle bir �ey yapmazd�m normalde. Anl�k geli�ti olaylar kusura bakma, g�r���r�z", "Onay", 57);
                    }
                    else
                    {
                        return ("Kimden: Ferit\r\nKime: Sedat Teker (Mahkum #193)\r\n\r\nDinle, benden para isteme. Senin y�z�nden zaten ba��m belada. Kendi i�ine bak. ��k�nca da bana bula�ma. Hala hayatta olmana �a��r�yorum.", "Onay", 57);
                    }
            case 57:
                    return ("Kimden: B.\r\nKime: Alper Porsuk (Mahkum #249)\r\n\r\nALLAH BELANI VERS�N\r\nUMARIM ORADA GEBER�RS�N", "Imha", 59);
            case 59:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Alper Porsuk (Mahkum #249)\r\nKime: B.\r\n\r\nNe bi�im bi insans�n sen bana yapt�klar�n yetmedi mi hala beddua ediyorsun. Allah senin belan� versin, ya�att�klar�n� ya�amadan �lmezsin nank�r seni.", "Imha", 60);
                    }
                    else
                    {
                        return ("Kimden: Alper Porsuk (Mahkum #249)\r\nKime: Enes Ba�kan\r\n\r\nNaber Enes nas�l gidiyor? Burda baya can�m s�k�l�yor zaten hayvanat bah�esi gibi bir yer, her yer �ok kirli. Neyse bana biraz kitap yollar m�s�n?", "Imha", 61);
                    }
            case 60:
                    return ("a", "Onay", 26);
            case 61:
                    return ("a", "Onay", 26);
        }
    }
    else if (olay <= 83)
    {
        switch (olay)
        {
            case 62:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Muhammed Eryaman (Mahkum #022)\r\nKime: Yusuf Efe Bilge\r\n\r\n�ok komiksin yuso, ��k�nca ilk i� seni d�vcem karde�. �aka bi yana buras� �ok s�k�c�, insan�n i�i daral�yor.", "Onay", 63);
                    }
                    else
                    {
                        return ("Kimden: Bekir Demirk�ran\r\nKime: Hamza �imen (Mahkum #117)\r\n\r\nSundu�umuz yeni kan�tlarla dava devam ediyor en k�sa zamanda hakl�l���n� kan�tlay�p seni oradan kurtar�caz hi� merak etme.", "Onay", 64);
                    }
            case 63:
                    return ("Kimden: Er�in R�dvan\r\nKime: Yusuf Ba� (Mahkum #022)\r\n\r\nSen cidden bo� bi adams�n onu anlam�� olduk. Bir daha benimle ileti�im bile kurmaya kalkma. Allah cezan� vermi� zaten, beter ol.", "Imha", 65);
            case 64:
                    return ("Kimden: Er�in R�dvan\r\nKime: Yusuf Ba� (Mahkum #022)\r\n\r\nSen cidden bo� bi adams�n onu anlam�� olduk. Bir daha benimle ileti�im bile kurmaya kalkma. Allah cezan� vermi� zaten, beter ol.", "Imha", 66);
            case 65:
                    return ("Kimden: Muhammed Eryaman\r\nKime: Yusuf Efe Bilge (Mahkum #310)\r\n\r\nDostuum benle dalga ge�iyodun noldu �imdi. Sen yokken bol bol ma� yapcaz. Bu arada Mert�e selamlar�m� ilet, g�r���r�z", "Onay", 67);
            case 66:
                    return ("Kimden: Muhammed Eryaman\r\nKime: Yusuf Efe Bilge (Mahkum #310)\r\n\r\nBen sana Okanlara bula�ma demi�tim, istedi�in oldu mu? Allah ak�l fikir versin ne diyim ki i� i�ten ge�ti daha. Bundan sonra daha mant�kl� kararlar ver l�tfen", "Onay", 68);
            case 67:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Yusuf Efe Bilge (Mahkum #310)\r\nKime: Muhammed Eryaman\r\n\r\nNas�l beddua ettiysen sen hapisten ��kt�n ben girdim :/ Anlatt���ndan on kat s�k�c� buras�. Mert�e selam�n� ilettim o da sana selam yolluyor, bu arada yar�n ��k�yomu� istersen bi g�r���n. bay bay", "Onay", 69);
                    }
                    else
                    {
                        return ("Kimden: �brahim Kaya\r\nKime: Eymen Yan�lmaz (Mahkum #084)\r\n\r\n�mer diye bir gen� gelecek i�eriye, seni bulmas�n� s�yledim, �ocu�a g�z kulak ol ", "Onay", 69);
                    }
            case 68:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Yusuf Efe Bilge (Mahkum #310)\r\nKime: Muhammed Eryaman\r\n\r\nHakl�s�n dostum benim hatam. Ben dersimi ald�m bundan sonra d�zelticem her�eyi �n�allah. G�r���r�z", "Onay", 69);
                    }
                    else
                    {
                        return ("Kimden: �brahim Kaya\r\nKime: Eymen Yan�lmaz (Mahkum #084)\r\n\r\n�mer diye bir gen� gelecek i�eriye, seni bulmas�n� s�yledim, �ocu�a g�z kulak ol ", "Onay", 69);
                    }
            case 69:
                    return ("Kimden: Cem Aydo�an\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nDostum durumunu yeni ��rendim Allah sab�r versin. �yi misin orda, can�n s�k�l�yordur tabi u�ra�acak bir �eyler bul kendine, istersen kitap falan yollayay�m okursun. G�r���r�z", "Onay", 72);
            case 72:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Mehmet Baykara (Mahkum #150)\r\nKime: Cem Aydo�an\r\n\r\nTe�ekk�rler Cem, s�k�lmak yine katlan�l�r da akl�ma s�rekli o ki�i geliyor. Kafam� oyalamam laz�m birka� kitap iyi olurdu.", "Onay", 73);
                    }
                    else
                    {
                        return ("Kimden: Cem Aydo�an\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nHala k�rg�n m�s�n cidden? Benim su�um de�ildi biliyorsun. Yine de sana birka� kitap yollayaca��m.", "Onay", 74);
                    }
            case 73:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Cem Aydo�an\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nAnl�yorum seni zor bir durum. O k�z� d���nme art�k, her g�zel �eyin bir sonu var. Ger�i siz s�rekli kavga ediyordunuz ama neyse. Hay�rl�s� buymu� �zme kendini", "Onay", 75);
                    }
                    else
                    {
                        return ("Kimden: Mehmet Baykara (Mahkum #150)\r\nKime: Cem Aydo�an\r\n\r\nCem ciddiyim bana kitap yolla en az�ndan okurken onu d���nmemi� olurum.", "Onay", 75);
                    }
            case 74:
                    return ("Kimden: Cafer Ball�\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nHocam sizin yoklu�unuzda projeyi pek ilerletemedik. Ba�ka bir i� bulmam gerekti kusura bakmay�n. Allah kurtars�n", "Onay", 75);
            case 75:
                    return ("Kimden: Eymen Yan�lmaz (Mahkum #084)\r\nKime: �brahim Kaya\r\n\r\n�mer�in durumu pek iyi de�il i�erde kafay� yiyor bizle konu�muyor. Birka� kitap verdik okudu hemen, onun d���nda durup duvar� izliyor sadece. Daha �ok kitap yolla bari �ocuk vakit ge�irsin.", "Onay", 78);
            case 78:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: �brahim Kaya\r\nKime: Eymen Yan�lmaz (Mahkum #084)\r\n\r\nTamam kitaplar� yollad�m. �ok �ey ya�ad� bu durumda olmas�na �a��rm�yorum. �yi bak�n kendinize  ", "Onay", 79);
                    }
                    else
                    {
                        return ("Kimden: Eymen Yan�lmaz (Mahkum #084)\r\nKime: �brahim Kaya\r\n\r\nDostum ben ciddiyim yeni kitaplar yolla. �ocu�un tek ya�am faaliyeti kitap okumak. Yeni kitaplar laz�m.", "Onay", 80);
                    }
            case 79:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Eymen Yan�lmaz (Mahkum #084)\r\nKime: �brahim Kaya\r\n\r\nTe�ekk�rler en az�ndan kitaplarla kendini toparl�yor biraz da olsa. Yak�nda dertlerini de unutacakt�r.", "Onay", 81);
                    }
                    else
                    {
                        return ("Kimden: Wanda Silva\r\nKime: Marco Silva (Mahkum #297)\r\n\r\nMarco, los peri�dicos te acusan de evasi�n fiscal, pero s� que la mayor�a de los asuntos ni siquiera estaban en tus manos. Ca�ste en las trampas de tu gerente. Por favor, no te culpes. Te esperamos; esto se acabar�.", "Imha", 82);
                    }
            case 80:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: �brahim Kaya\r\nKime: Eymen Yan�lmaz (Mahkum #084)\r\n\r\nTamam kitaplar� yollad�m. �ok �ey ya�ad� bu durumda olmas�na �a��rm�yorum. �yi bak�n kendinize  ", "Onay", 83);
                    }
                    else
                    {
                        return ("Kimden: Avukat �eyda \r\nKime: Mahmut Selim (Mahkum #234)\r\nSay�n M�vekkilim, dilek�eniz h�l� inceleme s�recinde. �n�m�zdeki hafta i�inde karar bekleniyor. Size geli�meler olduk�a bildirece�im. Sab�rl� olman�z �nemli. Sayg�lar�mla.", "Onay", 82);
                    }
            case 81:
                    return ("a", "Onay", 70);
            case 82:
                    return ("a", "Onay", 70);
            case 83:
                    return ("a", "Onay", 70);
        }
    }
        return ("a", "Onay", 1);
    }
}

