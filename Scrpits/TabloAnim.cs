using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.Video;

public class TabloAnim : MonoBehaviour
{
    public Sistem sistem;
    public VideoPlayer kedi;
    public GameObject kediSahne;
    private Animator tabloAnimator;
    private AudioSource sesKaynak;
    public GameObject buton;
    int tbl = 0;
    public float kediBaslaZaman;
    public float kediBitisZaman;
    void Start()
    {
        tabloAnimator = GetComponent<Animator>();
        sesKaynak = GetComponent<AudioSource>();
    }
    public void tablo()
    {
        tbl++;
        if (tbl == 9)
        {
            sistem.maas += 10;
            Basla();
        }
    }

    public void Basla()
    {
        tabloAnimator.SetTrigger("Baslat");
        sesKaynak.Play();
        Invoke("BaslaAnim", kediBaslaZaman);
        Invoke("BitAnim", kediBitisZaman);
        buton.SetActive(false);
    }

    public void BaslaAnim()
    {
        kediSahne.SetActive(true);
        kedi.Play();
    }
    public void BitAnim()
    {
        kediSahne.SetActive(false);
    }
}
