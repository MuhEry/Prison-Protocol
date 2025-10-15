using UnityEngine;
using UnityEngine.EventSystems;

public class EventKontrol : MonoBehaviour
{
    void Awake()
    {
        // Devre d��� objeleri de dahil ederek sahnedeki t�m EventSystem bile�enlerini bul
        EventSystem[] allEventSystems = Resources.FindObjectsOfTypeAll<EventSystem>();

        // E�er birden fazla varsa, ilk d���ndakileri kapat
        if (allEventSystems.Length > 1)
        {
            for (int i = 1; i < allEventSystems.Length; i++)
            {
                allEventSystems[i].gameObject.SetActive(false);
                Debug.Log("Fazladan EventSystem devre d��� b�rak�ld�: " + allEventSystems[i].name);
            }
        }
    }
}
