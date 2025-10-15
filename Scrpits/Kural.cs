using TMPro;
using UnityEngine;

public class Kural : MonoBehaviour
{
    public GameObject kuralPanel; 
    public TMP_Text kuralText;

    void Start()
    {
        if (kuralPanel != null)
            KuralPanelKapat();
    }

    public void KuralPanelAc()
    {
        if (kuralPanel != null /*&& kuralText != null*/)
        {
            kuralPanel.SetActive(true);
            Sistem.panel = true;
        }
    }
    public void KuralPanelKapat()
    {
        if (kuralPanel != null /*&& kuralText != null*/)
        {
            kuralPanel.SetActive(false);
            Sistem.panel = false;
        }
    }
}
