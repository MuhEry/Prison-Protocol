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
                    return ("Kimden: Mert Yýldýz (Mahkum #215)\r\nKime: Fatma Yýldýz\r\n\r\nBende sabýrsýzlýkla buluþacaðýmýz günü bekliyorum. Bu lanet yerden kurtulmama sadece bir ay kaldý. Herkese selam söyle, Görüþürüz\r\n", "Imha", 2);
                }
                else
                {
                    return ("Kimden: Mert Yýldýz (Mahkum #215)\r\nKime: Fatma Yýldýz\r\n\r\nUzun zamandýr sizden mektup bekliyorum anne iyi misiniz? Umarým baþýnýza bir þey gelmemiþtir. En kýsa zamanda haber yollayýn.\r\n", "Onay", 3);
                }
            case 2:
                    return ("Kimden: Ýbrahim Taþ\r\nKime: Mert Yýldýz (Mahkum #215)\r\n\r\nDostum sana güzel süprizler hazýrladýk çýktýðýn günü iple çekiyoruz görüþmek üzere.", "Onay", 4);
            case 3:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Fatma Yýldýz\r\nKime: Mert Yýldýz (Mahkum #215)\r\n\r\nCaným oðlum,\r\n\r\nHepimiz iyiyiz merak etme. Önceden mektup yollamýþtýk ama görünen o ki sana ulaþmamýþ. Umarým sende iyisindir. Evine dönmene az kaldý yavrum görüþürüz.", "Onay", 4);
                    }
                    else
                    {
                        return ("Kimden: Ýbrahim Taþ\r\nKime: Mert Yýldýz (Mahkum #215)\r\n\r\nDostum sana güzel süprizler hazýrladýk çýktýðýn günü iple çekiyoruz görüþmek üzere.", "Onay", 4);
                    }
            case 4:
                    return ("Kimden: Ahmet Mavi\r\nKime: Çaðrý Minikkuþ (Mahkum #108)\r\n\r\nSevgili dostum, inþallah keyfin yerindedir. Sana anlattýðým bi kýz vardý ona açýlmaya karar verdim. bana güzel bir þiir yazar mýsýn kýza okumam için. Þimdiden saðolasýn.", "Onay", 6);
            case 6:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Çaðrý Minikkuþ (Mahkum #108)\r\nKime: Ahmet Mavi\r\n\r\nTabii dostum ne demek zaten caným sýkýlýyordu.\r\n\r\nHiç sýkýlmayacaðým bir gösteri\r\nÝçinde kaybolduðum bu gözlerin\r\nAdýný hecelerken geçen geceler\r\nBu özlemin bitmesin mi sence de\r\nÖzlem yangýným kucaðýnda sönsün\r\nve var sana adanacak bir ömrüm\r\nSensiz düþünemiyorum ben kimim?\r\nKabul eder misin olmayý biricik sevgilim", "Onay", 7);
                    }
                    else
                    {
                        return ("Kimden: Çaðrý Minikkuþ (Mahkum #108)\r\nKime: Ahmet Mavi\r\n\r\nDostum sana anlattýðým kýzýn kapýsýna býrakýr mýsýn bunu.\r\n\r\nÖnüme çýkan bütün yokuþlarda Nasip dedim, yürü\r\nGönlüm ateþlerde, git, dokunma asitlerin çürür\r\nYüzeysel bi ezber için fazla sevdim seni\r\nÝyi ki hayatýmda yoksun artýk basitlerin gülü.", "Onay", 8);
                    }
            case 7:
                    return ("Kimden: Ahmet Mavi\r\nKime: Çaðrý Minikkuþ (Mahkum #108)\r\n\r\nTeþekkürler dostum. Kýz kabul etmedi Allah belasýný versin. Neyse senin þiirin gayet güzeldi, saðolasýn.", "Imha", 9);
            case 8:
                    return ("Kimden: Ahmet Mavi\r\nKime: Çaðrý Minikkuþ (Mahkum #108)\r\n\r\nTamam dostum býrakýrým. Benim söylediðim þiiri yollamana gerek kalmadý kýz ayrýldý benden. yinede teþekkürler.", "Onay", 9);
            case 9:
                    return ("Kimden: Hilal Karadað\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nAþkým seni çok özlüyorum. Canýn sýkýlmasýn diye sevdiðin mavi kitabý yolladým. Umarým sana ulaþýr hayatým. hemencecik oku, çok seviyorum seni.", "Onay", 11);
            case 11:
                    return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karadað\r\n\r\nCaným benim, seni çok özledim biliyorum uzaktasýn ama en yakýn zamanda ziyarete gel lütfen.", "Onay", 13);
            // Kitabýn durumuna göre sonradan güncellencek
                case 12:
                    Sistem.TelOlay = 7;
                    return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karadað\r\n\r\nAþkým yolladýðýn “kitabý” malesef aldýlar.\r\nbol bol mektup yaz seviyorum seni.", "Onay", 14);
            case 13:
                    return ("Kimden: Hilal Karadað\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nAþkým galiba iþler planladýðým gibi gitmedi, neyse haftaya perþembe gibi seni ziyarete gelicem, görüþürüz balým", "Onay", 15);
            case 14:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Hilal Karadað\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nYaa nasý buldular, yapcak biþe yok aským daha mektup yazarak özlem gidermeye çalýþcaz :( Birkaç hafta sonra trenle gelcem ziyaretine aþkým çok özledim seni.", "Onay", 16);
                    }
                    else
                    {
                        return ("Kimden: Hilal Karadað\r\nKime: Eren Turgutlu (Mahkum #211)\r\n\r\nAþkým haber alamadým senden yaziyim dedim bir sorun mu oldu? Herhalde yolladýðým kitap planladýðým gibi gitmedi, neyse balým seviyorum seni mektup yaz en azýndan, öptüm görüþürüz.", "Onay", 16);
                    }
            case 15:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karadað\r\n\r\nGel aþkým çok özledim güzel yüzünü. Sabýrsýzlýkla bekliyorumm. Dikkat et kendine, perþembe görüþürüzz", "Onay", 16);
                    }
                    else
                    {
                        return ("Kimden: Eren Turgutlu (Mahkum #211)\r\nKime: Hilal Karadað\r\n\r\nHilal neden biþe yazmadýn bi sorun mu var?\r\nEndiþeleniyorum bana sýk sýk mektup yaz iyi misin hayatým?? Burada sadece seni düþünerek vakit geçiyorum.", "Onay", 16);
                    }
            case 16:
                    return ("Kimden: Sercan Ýpekçi\r\nKime: Volkan Ayvaz (Mahkum #313)\r\n\r\nSelam dostum, içeride olsan da ritmin hâlâ sokaklarda çalýyor. Moralin bozulmasýn, dýþarý çýktýðýnda hep beraber stüdyoya döneceðiz. Senin sesini kimse susturamaz, bunu unutma.", "Onay", 19);
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
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: Ýmed Semedov\r\n\r\nBana M.yolundaki depodan ürün yollayýn ben çýkmanýn yolunu bulurum. Çýktýðým zaman Zubkov diye biri kalmicak.", "Sikayet", 22);
                    }
                    else
                    {
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: Ýmed Semedov\r\n\r\nÝmed bana M. yolundaki depodan mal yolla ,bir þekilde içeri sokabilirsen buradan çýkabilirim. Dikkat et", "Sikayet", 22);
                    }
            case 22:
                    if (kutu == "Onay")
                    {
                        Sistem.olay = 6;
                        return ("Kimden: Ýmed Semedov\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\nÜrünü yolladýk patron. Umarým miktarý yeterlidir.", "Onay", 23);
                    }
                    else if (kutu == "Sikayet")
                    {
                        Sistem.TelOlay = 2;
                        return ("Kimden: S.S.\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\nPatron, Ýmed yakalandý ve bir depomuzu kaybettik. Kimse kalmadý. Ne yapacaðýmý bilemiyorum.", "Onay", 24);
                    }
                    else
                    {
                        return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: Ýmed Semedov\r\n\r\nÝçeride durumlar kötüleþiyor neden dediðimi yollamadýnýz? Ýþler iyice çýkmaza girdi.", "Onay", 25);
                    }
            case 23:
                    return ("Kimden: Dominic Subkova (Mahkum #003)\r\nKime: Ýmed Semedov\r\n\r\nYapacaðýnýz iþe ... mal yakalanmýþ ve tekrar suçlama açýldý üstüme. Buraya kadarmýþ.", "Onay", 26);
                    // Kitabýn durumuna göre sonradan güncellencek
            case 24:
                    return ("Kimden: Bremer Subkova (Mahkum #004)\r\nKime:  Samed Sbarrov\r\n\r\nAbimi üst düzey bir hapishaneye sevk ettiler.  Elimizden gelen bir þey kalmadý. Buraya kadarmýþ, sende uzaklara git.", "Onay", 26);
            case 25:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Ýmed Semedov\r\nKime: Dominic Subkova (Mahkum #003)\r\n\r\nNe yollamamýz gerek patron, bize herhangi bir bilgi gelmedi.", "Onay", 26);
                    }
                    else
                    {
                        return ("Kimden: Melike Kayaalp\r\nKime: Ýsmail Kayaalp (Mahkum #003)\r\n\r\nÝsmail, senden utanýyorum. Komþularýn yüzüne bakamýyorum. Bari çocuklarýn geleceðini düþünseydin. Yine de ne olursa olsun, dua ediyorum sana.", "Onay", 26);
                    }
            case 26:
                    return ("Kimden: Bahadýr Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nSenin anlattýðýn iþ vardý ya, OLDU. Anlattýðýndan daha da karlý ilerliyor þuan. Ayrýca söylediðin gibi senin arabayý sattým, bu gidiþle sen çýkana kadar daha iyisini alýrýz.", "Onay", 31);
            case 31:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahadýr Bulut\r\n\r\nHelal be sana, gelen parayý da boþa verme iþi büyüt arabayý daha sonra da alýrýz acelesi yok. Benim bir defterim vardý 2. çekmecede, defterde iþle ilgili planlarým vardý okursan belki aklýna bir kaç yeni fikir daha gelir", "Onay", 32);
                    }
                    else
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahadýr Bulut\r\n\r\nDostum iþle ilgili geliþme var mý? En son ziyarete geldiðinde baya heyecanlýydýn bu iþ için. Umarým çalýþmaya baþlamýþsýndýr.", "Onay", 33);
                    }
            case 32:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Bahadýr Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nDefterini buldum baya güzel ipuçlarý varmýþ. Ýþler gayet yolunda gidiyor merak etme. Sen çýktýðýnda iþleri daha da büyütür bir ofis bile açarýz belki.", "Onay", 34);
                    }
                    else
                    {
                        return ("Kimden: Levent Hamit Ton (Mahkum #209)\r\nKime: Bahadýr Bulut\r\n\r\nDostum iþle ilgili geliþme var mý? En son anlattýðýnda baya güzel gidiyordu iþler. Umarým her þey yolundadýr.", "Onay", 34);
                    }
            case 33:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Bahadýr Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nSana bir mektup yollamýþtým ulaþmadý herhalde. Ýþler gayet yolunda gidiyor merak etme. Sen çýktýðýnda iþleri daha da büyütür bir ofis bile açarýz belki. Ayrýca söylediðin gibi senin arabayý satýp parayý iþe yatýrdým.", "Onay", 34);
                    }
                    else
                    {
                        return ("Kimden: Bahadýr Bulut\r\nKime: Levent Hamit Ton (Mahkum #209)\r\n\r\nKardeþim arabayý satmama mý kýzdýn? Sen söylemiþtin böyle bi durumda satabilirsin diye. Merak etme tekrar alýrýz arabaný", "Onay", 34);
                    }
            case 34:
                    return ("Kimden: Adile Çöl\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nBenden haber bekleme artýk. Ben kendi yoluma gidiyorum, kendine iyi bak.", "Onay", 38);
            case 38:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Enes Hoca (Mahkum #187)\r\nKime: Adile Çöl\r\n\r\nNe diyeyim. Hakkýn varsa helal et. Ben içeride kaldým, hayat seni beklemez", "Onay", 39);
                    }
                    else
                    {
                        return ("Kimden: Adile Çöl\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nHiç tepki vermedin. Demek ki söylediklerim doðruymuþ. Bu iþ burada bitti.", "Onay", 40);
                    }
            case 39:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Adile Çöl\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nHelal olsun her þeye raðmen güzel zamanlardý. Allah’a emanet ol, elveda", "Onay", 41);
                    }
                    else
                    {
                        return ("Kimden: Adile Çöl\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nAllah belaný versin baþka biþe demiyorum.", "Imha", 41);
                    }
            case 40:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Enes Hoca (Mahkum #187)\r\nKime: Adile Çöl\r\n\r\nNe tepkisi neyden söz ediyorsun? Neyse ne senin bu triplerinle uðraþamam artýk bana hiç bir þey yazma. Elveda", "Onay", 41);
                    }
                    else
                    {
                        return ("Kimden: Adile Çöl\r\nKime: Enes Hoca (Mahkum #187)\r\n\r\nAllah belaný versin baþka biþe demiyorum.", "Imha", 41);
                    }
            case 41:
                    return ("Kimden: Wanda Silva\r\nKime: Marco Silva (Mahkum #297)\r\n\r\nPresta toda tu atención ahora:\r\nUn burro comía berros y el perro se los robó. El burro lanzó un rebuzno y el perro al barro cayó.\r\n11 12 13 14 96  121 52 22 44 43  21 92 183  31 46 83 202 131", "Imha", 44);
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
                        return ("Kimden: Mustafa Emir Erol\r\nKime: Hüseyin Hamsi (Mahkum #061)\r\n\r\nMesajýný aldým gerekli iþlemleri yaptým, umarým sistem biraz düzelir.", "Onay", 46);
                    }
                    else
                    {
                        return ("Kimden: Elif Ýnci\r\nKime: Selim Ýnci (Mahkum #019)\r\n\r\nCaným babam, sana resim çizdim çok güzel oldu. Çýkýnca sana göstericem. Annemle seni çok özledik, güçlü kal.", "Onay", 46);
                    }
            case 46:
                    return ("Kimden: \r\nKime: Kureyhan (Mahkum #000)\r\n\r\n24121518281181714629518142517 \r\n2112221 22 212 12222", "Imha", 48);
            case 48:
                    return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nYEÞÝL KÝTABI ÝÇERÝ AL MEMUR.\r\n\r\n", "Imha", 49);
            case 49:
                   return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\nYEÞÝL KÝTABI ÝÇERÝ AL.\r\nBU SON UYARIMIZ.", "Imha", 51);
                    // Kitabýn durumuna göre sonradan güncellencek
            case 50:
                    return ("Kimden: Tarýk Yalýlý (Mahkum #101)\r\nKime: Hayri Yalýlý\r\n\r\nOðlum, umarým iyisinizdir. Dükkanda iþler yolunda mý? bi ihtiyacýnýz olursa amcana söyle.", "Onay", 52);
            case 51:
                    return ("Kimden: KKK\r\nKime: Alperen Suphi (Mahkum #296)\r\n\r\n...", "Imha", 52);
                    // Kitabýn durumuna göre sonradan güncellencek
            case 52:
                    return ("Kimden: Haidi Sé\r\nKime: Ellen Mask(Mahkum #270)\r\n\r\nEllen, on lit ton nom dans les journaux tous les jours. Je n'en croyais pas mes yeux quand je t'ai vue accusée de corruption. Tu essayais juste d'empirer les choses. Je te crois, ma chère, et j'espère que tu sortiras bientôt.", "Imha", 55);
            case 55:
                    return ("Kimden: Ömer Ethem Kaya\r\nKime: Alaattin Erkuþ (Mahkum #071)\r\n\r\nDostum paraya ihtiyacýn olduðunu söylesen sana yardým ederdik neden böyle bir iþe bulaþtýn. Neyse ki uzun bir ceza vermediler. çýktýðýnda iþleri yoluna koyacaðýz merak etme", "Onay", 56);
            case 56:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Alaattin Erkuþ (Mahkum #071)\r\nKime: Ömer Ethem Kaya\r\n\r\nYanýmda olduðun için teþekkür ederim. Bende anlamadým böyle bir þey yapmazdým normalde. Anlýk geliþti olaylar kusura bakma, görüþürüz", "Onay", 57);
                    }
                    else
                    {
                        return ("Kimden: Ferit\r\nKime: Sedat Teker (Mahkum #193)\r\n\r\nDinle, benden para isteme. Senin yüzünden zaten baþým belada. Kendi iþine bak. Çýkýnca da bana bulaþma. Hala hayatta olmana þaþýrýyorum.", "Onay", 57);
                    }
            case 57:
                    return ("Kimden: B.\r\nKime: Alper Porsuk (Mahkum #249)\r\n\r\nALLAH BELANI VERSÝN\r\nUMARIM ORADA GEBERÝRSÝN", "Imha", 59);
            case 59:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Alper Porsuk (Mahkum #249)\r\nKime: B.\r\n\r\nNe biçim bi insansýn sen bana yaptýklarýn yetmedi mi hala beddua ediyorsun. Allah senin belaný versin, yaþattýklarýný yaþamadan ölmezsin nankör seni.", "Imha", 60);
                    }
                    else
                    {
                        return ("Kimden: Alper Porsuk (Mahkum #249)\r\nKime: Enes Baþkan\r\n\r\nNaber Enes nasýl gidiyor? Burda baya caným sýkýlýyor zaten hayvanat bahçesi gibi bir yer, her yer çok kirli. Neyse bana biraz kitap yollar mýsýn?", "Imha", 61);
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
                        return ("Kimden: Muhammed Eryaman (Mahkum #022)\r\nKime: Yusuf Efe Bilge\r\n\r\nÇok komiksin yuso, çýkýnca ilk iþ seni dövcem kardeþ. Þaka bi yana burasý çok sýkýcý, insanýn içi daralýyor.", "Onay", 63);
                    }
                    else
                    {
                        return ("Kimden: Bekir Demirkýran\r\nKime: Hamza Çimen (Mahkum #117)\r\n\r\nSunduðumuz yeni kanýtlarla dava devam ediyor en kýsa zamanda haklýlýðýný kanýtlayýp seni oradan kurtarýcaz hiç merak etme.", "Onay", 64);
                    }
            case 63:
                    return ("Kimden: Erçin Rýdvan\r\nKime: Yusuf Baþ (Mahkum #022)\r\n\r\nSen cidden boþ bi adamsýn onu anlamýþ olduk. Bir daha benimle iletiþim bile kurmaya kalkma. Allah cezaný vermiþ zaten, beter ol.", "Imha", 65);
            case 64:
                    return ("Kimden: Erçin Rýdvan\r\nKime: Yusuf Baþ (Mahkum #022)\r\n\r\nSen cidden boþ bi adamsýn onu anlamýþ olduk. Bir daha benimle iletiþim bile kurmaya kalkma. Allah cezaný vermiþ zaten, beter ol.", "Imha", 66);
            case 65:
                    return ("Kimden: Muhammed Eryaman\r\nKime: Yusuf Efe Bilge (Mahkum #310)\r\n\r\nDostuum benle dalga geçiyodun noldu þimdi. Sen yokken bol bol maç yapcaz. Bu arada Mert’e selamlarýmý ilet, görüþürüz", "Onay", 67);
            case 66:
                    return ("Kimden: Muhammed Eryaman\r\nKime: Yusuf Efe Bilge (Mahkum #310)\r\n\r\nBen sana Okanlara bulaþma demiþtim, istediðin oldu mu? Allah akýl fikir versin ne diyim ki iþ iþten geçti daha. Bundan sonra daha mantýklý kararlar ver lütfen", "Onay", 68);
            case 67:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Yusuf Efe Bilge (Mahkum #310)\r\nKime: Muhammed Eryaman\r\n\r\nNasýl beddua ettiysen sen hapisten çýktýn ben girdim :/ Anlattýðýndan on kat sýkýcý burasý. Mert’e selamýný ilettim o da sana selam yolluyor, bu arada yarýn çýkýyomuþ istersen bi görüþün. bay bay", "Onay", 69);
                    }
                    else
                    {
                        return ("Kimden: Ýbrahim Kaya\r\nKime: Eymen Yanýlmaz (Mahkum #084)\r\n\r\nÖmer diye bir genç gelecek içeriye, seni bulmasýný söyledim, çocuða göz kulak ol ", "Onay", 69);
                    }
            case 68:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Yusuf Efe Bilge (Mahkum #310)\r\nKime: Muhammed Eryaman\r\n\r\nHaklýsýn dostum benim hatam. Ben dersimi aldým bundan sonra düzelticem herþeyi Ýnþallah. Görüþürüz", "Onay", 69);
                    }
                    else
                    {
                        return ("Kimden: Ýbrahim Kaya\r\nKime: Eymen Yanýlmaz (Mahkum #084)\r\n\r\nÖmer diye bir genç gelecek içeriye, seni bulmasýný söyledim, çocuða göz kulak ol ", "Onay", 69);
                    }
            case 69:
                    return ("Kimden: Cem Aydoðan\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nDostum durumunu yeni öðrendim Allah sabýr versin. Ýyi misin orda, canýn sýkýlýyordur tabi uðraþacak bir þeyler bul kendine, istersen kitap falan yollayayým okursun. Görüþürüz", "Onay", 72);
            case 72:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Mehmet Baykara (Mahkum #150)\r\nKime: Cem Aydoðan\r\n\r\nTeþekkürler Cem, sýkýlmak yine katlanýlýr da aklýma sürekli o kiþi geliyor. Kafamý oyalamam lazým birkaç kitap iyi olurdu.", "Onay", 73);
                    }
                    else
                    {
                        return ("Kimden: Cem Aydoðan\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nHala kýrgýn mýsýn cidden? Benim suçum deðildi biliyorsun. Yine de sana birkaç kitap yollayacaðým.", "Onay", 74);
                    }
            case 73:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Cem Aydoðan\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nAnlýyorum seni zor bir durum. O kýzý düþünme artýk, her güzel þeyin bir sonu var. Gerçi siz sürekli kavga ediyordunuz ama neyse. Hayýrlýsý buymuþ üzme kendini", "Onay", 75);
                    }
                    else
                    {
                        return ("Kimden: Mehmet Baykara (Mahkum #150)\r\nKime: Cem Aydoðan\r\n\r\nCem ciddiyim bana kitap yolla en azýndan okurken onu düþünmemiþ olurum.", "Onay", 75);
                    }
            case 74:
                    return ("Kimden: Cafer Ballý\r\nKime: Mehmet Baykara (Mahkum #150)\r\n\r\nHocam sizin yokluðunuzda projeyi pek ilerletemedik. Baþka bir iþ bulmam gerekti kusura bakmayýn. Allah kurtarsýn", "Onay", 75);
            case 75:
                    return ("Kimden: Eymen Yanýlmaz (Mahkum #084)\r\nKime: Ýbrahim Kaya\r\n\r\nÖmer’in durumu pek iyi deðil içerde kafayý yiyor bizle konuþmuyor. Birkaç kitap verdik okudu hemen, onun dýþýnda durup duvarý izliyor sadece. Daha çok kitap yolla bari çocuk vakit geçirsin.", "Onay", 78);
            case 78:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Ýbrahim Kaya\r\nKime: Eymen Yanýlmaz (Mahkum #084)\r\n\r\nTamam kitaplarý yolladým. Çok þey yaþadý bu durumda olmasýna þaþýrmýyorum. Ýyi bakýn kendinize  ", "Onay", 79);
                    }
                    else
                    {
                        return ("Kimden: Eymen Yanýlmaz (Mahkum #084)\r\nKime: Ýbrahim Kaya\r\n\r\nDostum ben ciddiyim yeni kitaplar yolla. Çocuðun tek yaþam faaliyeti kitap okumak. Yeni kitaplar lazým.", "Onay", 80);
                    }
            case 79:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Eymen Yanýlmaz (Mahkum #084)\r\nKime: Ýbrahim Kaya\r\n\r\nTeþekkürler en azýndan kitaplarla kendini toparlýyor biraz da olsa. Yakýnda dertlerini de unutacaktýr.", "Onay", 81);
                    }
                    else
                    {
                        return ("Kimden: Wanda Silva\r\nKime: Marco Silva (Mahkum #297)\r\n\r\nMarco, los periódicos te acusan de evasión fiscal, pero sé que la mayoría de los asuntos ni siquiera estaban en tus manos. Caíste en las trampas de tu gerente. Por favor, no te culpes. Te esperamos; esto se acabará.", "Imha", 82);
                    }
            case 80:
                    if (kutu == "Onay")
                    {
                        return ("Kimden: Ýbrahim Kaya\r\nKime: Eymen Yanýlmaz (Mahkum #084)\r\n\r\nTamam kitaplarý yolladým. Çok þey yaþadý bu durumda olmasýna þaþýrmýyorum. Ýyi bakýn kendinize  ", "Onay", 83);
                    }
                    else
                    {
                        return ("Kimden: Avukat Þeyda \r\nKime: Mahmut Selim (Mahkum #234)\r\nSayýn Müvekkilim, dilekçeniz hâlâ inceleme sürecinde. Önümüzdeki hafta içinde karar bekleniyor. Size geliþmeler oldukça bildireceðim. Sabýrlý olmanýz önemli. Saygýlarýmla.", "Onay", 82);
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

