using UnityEngine;
using UnityEngine.EventSystems;

public class EventKontrol : MonoBehaviour
{
    void Awake()
    {
        // Devre dýþý objeleri de dahil ederek sahnedeki tüm EventSystem bileþenlerini bul
        EventSystem[] allEventSystems = Resources.FindObjectsOfTypeAll<EventSystem>();

        // Eðer birden fazla varsa, ilk dýþýndakileri kapat
        if (allEventSystems.Length > 1)
        {
            for (int i = 1; i < allEventSystems.Length; i++)
            {
                allEventSystems[i].gameObject.SetActive(false);
                Debug.Log("Fazladan EventSystem devre dýþý býrakýldý: " + allEventSystems[i].name);
            }
        }
    }
}
