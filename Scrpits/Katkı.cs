using UnityEngine;
using UnityEngine.SceneManagement;

public class Katkı : MonoBehaviour
{

    void Start()
    {
        Invoke("MenuDön", 33);
    }

    public void MenuDön()
    {
        SceneManager.LoadScene("Menü2");
    }
}
