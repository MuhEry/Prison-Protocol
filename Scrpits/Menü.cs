using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Menü : MonoBehaviour
{
    Vector3 ilkPozisyon;
    bool surukleme = false;
    public float x;
    public float y;
    public int buton;
    public static bool sahneAcildiMi = false;
    public static bool oyunDirekt = false;

    void Start()
    {
        ilkPozisyon = transform.position;
    }

    void OnMouseDown()
    {
        if (Sistem.panel) return;
        surukleme = true;
    }

    void OnMouseDrag()
    {
        if (surukleme && !Sistem.panel)
        {
            // Fare pozisyonunu dünya koordinatına çevir
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0; // 2D olduğu için z'yi sıfırla
            transform.position = mousePos;
        }
    }

    void OnMouseUp()
    {
        surukleme = false;

        // Bıraktığımız yerde "Kutu" layer'ında bir collider var mı kontrol et
        Collider2D gidenKutu = Physics2D.OverlapPoint(transform.position, LayerMask.GetMask("Kutu"));

        if (gidenKutu != null)
        {
            Debug.Log("Kutunun içine bırakıldı: " + gidenKutu.name);
            // Burada istediğin fonksiyonu çağır
            KutuyaBirakildi(buton);
            Invoke("GeriGit", 1);
        }
        else
        {
            // Eğer kutuya bırakılmadıysa eski konumuna dönsün
            StartCoroutine(GeriGit());
        }
    }

    void KutuyaBirakildi(int button)
    {
        // 1 çıkış
        // 2 Oyna
        // 3 nasıl oynanır
        // 4 katkı

        switch (button)
        {
            case 1:
                Debug.Log("Çıkıldı");
                Application.Quit();
                break;
            case 2:
                if (sahneAcildiMi && TelSahne.Final == 0)
                {
                    SceneManager.UnloadSceneAsync("Menü2");
                }
                else
                {
                    oyunDirekt = true;
                    TelSahne.Final = 0;
                    string kullanıcı = Environment.UserName;
                    if (string.IsNullOrEmpty(kullanıcı))
                    {
                        TelSahne.tamMetin = "İlk iş gününe hoşgeldin. Duvardaki kağıtta yazan kurallara uyman yeterli. Her hafta kuralları kontrol et. Kolay gelsin memur";
                    }
                    else
                    {
                        TelSahne.tamMetin = "İlk iş gününe hoşgeldin. Duvardaki kağıtta yazan kurallara uyman yeterli. Her hafta kuralları kontrol et. Kolay gelsin " + kullanıcı;
                    }
                    SceneManager.LoadScene("Telefon");
                    sahneAcildiMi = true;
                }
                break;
            case 3:
                SceneManager.LoadScene("Nasıl");
                break;
            case 4:
                SceneManager.LoadScene("Bitti");
                break;
        }
    }

    System.Collections.IEnumerator GeriGit()
    {
        float t = 0;
        Vector3 suankiPoz = transform.position;

        ilkPozisyon = new Vector3(x, y, 0);

        while (t < 1)
        {
            t += Time.deltaTime * 3f;
            transform.position = Vector3.Lerp(suankiPoz, ilkPozisyon, t);
            yield return null;
        }
    }
}
