using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SurukleEsya : MonoBehaviour
{
    public GameObject kitapPanel;
    public Image kitapArkaplan;
    public TMP_Text kitapText1;
    public TMP_Text kitapText2;
    public Sistem sistem;
    public KitapKontrol kitapKontrol;
    private string sayfa1; 
    private string sayfa2;
    Kitap kitapScript;

    private SpriteRenderer spriteRenderer;
    Vector3 ilkPozisyon;
    bool surukleme = false;
    float týklamaZamaný;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        kitapScript = GetComponent<Kitap>();
        sayfa1 = kitapScript.sayfa1;
        sayfa2 = kitapScript.sayfa2;
        ilkPozisyon = transform.position;
        if (kitapPanel != null)
            kitapArkaplan.sprite = kitapScript.kitapAcik;
            kitapPanel.SetActive(false);
    }

    void OnMouseDown()
    {
        if (Sistem.panel) return;
        surukleme = true;
        týklamaZamaný = Time.time;
    }

    void OnMouseDrag()
    {
        if (surukleme && !Sistem.panel)
        {
            // Fare pozisyonunu dünya koordinatýna çevir
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0; // 2D olduðu için z'yi sýfýrla
            transform.position = mousePos;
        }
    }

    void OnMouseUp()
    {
        float basiliSure = Time.time - týklamaZamaný;

        if (basiliSure < 0.10f)
        {
            EsyaPaneliAc();
            surukleme = false;
            return; // kutu kontrolüne girme
        }

        surukleme = false;
        string hedef = kitapScript.hedefKutu.ToString();
        Collider2D gidenKutu = Physics2D.OverlapPoint(transform.position, LayerMask.GetMask("KitapKutu"));

        if (gidenKutu != null)
        {
            if (gidenKutu.tag == hedef)
            {
                sistem.HamleDogru();
            }
            else
            {
                sistem.HamleYanlis();
            }
            var yeni = kitapKontrol.Kontrol(kitapScript.olay, gidenKutu.tag, kitapScript.ToString());
            //kitapScript.mesaj = yeni.icerik;
            kitapScript.hedefKutu = (Kitap.HedefKutu)System.Enum.Parse(typeof(Kitap.HedefKutu), yeni.hedefKutu);
            kitapScript.olay = yeni.olay;
            kitapScript.sayfa1 = yeni.sayfa1;
            kitapScript.sayfa2 = yeni.sayfa2;
            kitapScript.kitapAcik = yeni.kitapAcik;
            spriteRenderer.sprite  = yeni.kitapKapak;
            gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(GeriGit());
        }
    }
    void EsyaPaneliAc()
    {
        if (kitapPanel != null && kitapText1 != null && kitapText2 != null)
        {
            kitapArkaplan.sprite = kitapScript.kitapAcik;
            kitapText1.text = kitapScript.sayfa1;
            kitapText2.text = kitapScript.sayfa2;
            kitapPanel.SetActive(true);
            Sistem.panel = true;
        }
    }
    public void EsyaPaneliKapat()
    {
        kitapPanel.SetActive(false);
        Sistem.panel = false;
    }

    System.Collections.IEnumerator GeriGit()
    {
        float t = 0;
        Vector3 suankiPoz = transform.position;
        float x = suankiPoz.x;  
        float y = suankiPoz.y;

        if(suankiPoz.x > 7)
        {
            x = 6;
        }
        else if(suankiPoz.x < 0)
        {
            x = 0;
        }
        if (suankiPoz.y > 0)
        {
            y = 0;
        }
        else if (suankiPoz.y < -3)
        {
            y = -3;
        }
        ilkPozisyon = new Vector3(x, y, 0);

        while (t < 1)
        {        
            t += Time.deltaTime * 3f;
            transform.position = Vector3.Lerp(suankiPoz, ilkPozisyon, t);
            yield return null;
        }
    }
}

