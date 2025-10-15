using TMPro;
using UnityEngine;

public class Surukle : MonoBehaviour
{
    public GameObject mektupPanel; // UI Panel referansý
    public TMP_Text mektupText;    // Paneldeki Text (TMP)
    private string mektupIcerigi; 
    Mektup mektup;
    public Sistem sistem;
    public MektupKontrol mektupKontrol;
    public MektupAnim MektupAnim;

    Vector3 ilkPozisyon;
    bool surukleme = false;
    float týklamaZamaný;

    void Start()
    {
        mektup = GetComponent<Mektup>();
        mektupIcerigi = mektup.mesaj;
        ilkPozisyon = transform.position;
        if (mektupPanel != null)
            mektupPanel.SetActive(false);
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

        if (basiliSure < 0.12f)
        {
            PaneliAc();
            surukleme = false;
            return; // kutu kontrolüne girme
        }

        surukleme = false;
        string hedef = mektup.hedefKutu.ToString();
        Collider2D gidenKutu = Physics2D.OverlapPoint(transform.position, LayerMask.GetMask("Kutu"));

        if (gidenKutu != null)
        {
            MektupAnim.Anim(gidenKutu.tag);
            if (gidenKutu.tag == hedef)
            {
                sistem.HamleDogru();
            }
            else
            {
                sistem.HamleYanlis();
            }
            var yeni = mektupKontrol.Kontrol(mektup.olay, gidenKutu.tag);
            mektup.mesaj = yeni.icerik;
            mektup.hedefKutu = (Mektup.HedefKutu)System.Enum.Parse(typeof(Mektup.HedefKutu), yeni.hedefKutu);
            mektup.olay = yeni.olayID;
            gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(GeriGit());
        }
    }

    void PaneliAc()
    {
        if (mektupPanel != null && mektupText != null)
        {
            mektupText.text = mektup.mesaj;
            mektupPanel.SetActive(true);
            Sistem.panel = true;
        }
    }

    System.Collections.IEnumerator GeriGit()
    {
        float t = 0;
        Vector3 suankiPoz = transform.position;
        float x = suankiPoz.x;  
        float y = suankiPoz.y;

        if(suankiPoz.x > 4)
        {
            x = 4;
        }
        else if(suankiPoz.x < -7)
        {
            x = -7;
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

