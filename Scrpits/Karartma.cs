using UnityEngine;
using UnityEngine.SceneManagement;

public class Karartma : MonoBehaviour
{
    private Animator Animator;
    private AudioSource sesTel;
    public float sahneGe�i�S�resi;

    void Start()
    {
        Animator = GetComponent<Animator>();
        sesTel = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void Karart()
    {
        sesTel.Play();
        Animator.SetTrigger("ba�la");
        Invoke("SahneGe�", sahneGe�i�S�resi);
    }

    private void SahneGe�()
    {
        SceneManager.LoadScene("Telefon", LoadSceneMode.Additive);
        MenuAc�c�.oyunda = false;
    }
}
