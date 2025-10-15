using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAcıcı : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject sesX;
    private bool sesAcıkMı = true;
    public static bool oyunda = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && oyunda)
        {
            // Paneli tersine çevir (aç/kapat)
            Sistem.panel = !Sistem.panel;
            menuPanel.SetActive(Sistem.panel);
        }
    }
    public void MenuKapat()
    {
        Sistem.panel = false;
        menuPanel.SetActive(Sistem.panel);
    }
    public void ses()
    {
        if (sesAcıkMı)
        {
            sesX.SetActive(true);
            sesAcıkMı = false;
            AudioListener.volume = 0f;
        }
        else
        {
            sesX.SetActive(false);
            sesAcıkMı = true;
            AudioListener.volume = 1f;
        }
    }
    public void OyunKapat()
    {
        MenuKapat();
        Debug.Log("Çıkıldı");
        Application.Quit();
    }
    public void MenuDön()
    {
        MenuKapat();
        SceneManager.LoadScene("Menü2", LoadSceneMode.Additive);
    }
}
