using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelSahne : MonoBehaviour
{
    [Header("Sesler")]
    private Animator animator;
    private AudioSource ses;
    public AudioClip telAc;
    public AudioClip telKapat;
    public AudioClip konusma;
    public AudioClip konusmaKad�n;

    [Header("Genel")]
    public float kapat;
    public static int Final = 0;
    public static int ilk;
    public GameObject metinKutusu;
    public GameObject buton;
    public GameObject OnKarartma;
    public float telAC;
    public float telKAPAT;
    public float KONUSMA;

    [Header("Metin ��eri�i")]
    public TextMeshProUGUI textUI;
    [TextArea] public static string tamMetin;
    /*public*/ float delay;

    void Start()
    {
        buton.SetActive(false);
        Invoke("kapa", kapat);
        animator = GetComponent<Animator>();
        animator.SetTrigger("Giri�");
        ses = GetComponent<AudioSource>();
        Invoke("TelAc", telAC);
        Invoke("Konusma", KONUSMA);
        Invoke("TelKapat", telKAPAT);
    }

    private void kapa()
    {
        OnKarartma.SetActive(false);
    }

    private void TelAc()
    {
        ses.clip = telAc;
        ses.Play();

    }
    private void TelKapat()
    {
        ses.clip = telKapat;
        ses.Play();
    }
    private void Konusma()
    {
        metinKutusu.SetActive(true);
        ses.clip = konusma;
        if (Sistem.TelOlay == 5)
        {
            ses.clip = konusmaKad�n;
        }
        ses.Play();
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        textUI.text = "";
        delay = (float)(6.4 / tamMetin.Length);
        for (int i = 0; i < tamMetin.Length; i++)
        {
            textUI.text += tamMetin[i];
            yield return new WaitForSeconds(delay);
        }
        buton.SetActive(true);
    }
    public void SahneSonu()
    {
        animator.SetTrigger("��k��");
        metinKutusu.SetActive(false);
        Invoke("KarartmaAc", 1);
        buton.SetActive(false);
        if (Final == 1)
        {
            Invoke("Bitti", 2);
        }
        else
        {
            Invoke("SahneGe�", 2);
        }
    }
    public void KarartmaAc()
    {
        OnKarartma.SetActive(true);
    }
    public void SahneGe�()
    {
        MenuAc�c�.oyunda = true;
        if (Men�.oyunDirekt)
        {
            SceneManager.LoadScene("AnaOyun");
            Men�.oyunDirekt = false;
        }
        else
        {
            SceneManager.UnloadSceneAsync("Telefon");
        }
    }
    public void Bitti()
    {
        SceneManager.LoadScene("Bitti");
    }
}
