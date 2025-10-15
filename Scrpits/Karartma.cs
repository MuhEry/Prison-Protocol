using UnityEngine;
using UnityEngine.SceneManagement;

public class Karartma : MonoBehaviour
{
    private Animator Animator;
    private AudioSource sesTel;
    public float sahneGeçiþSüresi;

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
        Animator.SetTrigger("baþla");
        Invoke("SahneGeç", sahneGeçiþSüresi);
    }

    private void SahneGeç()
    {
        SceneManager.LoadScene("Telefon", LoadSceneMode.Additive);
        MenuAcýcý.oyunda = false;
    }
}
