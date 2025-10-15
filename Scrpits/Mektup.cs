using UnityEngine;

public class Mektup : MonoBehaviour
{
    public enum HedefKutu {Onay, Sikayet, Imha };
    [TextArea] public string mesaj;
    public HedefKutu hedefKutu;
    public int olay;
}
