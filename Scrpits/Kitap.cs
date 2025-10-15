using UnityEngine;
using UnityEngine.UI;

public class Kitap : MonoBehaviour
{
    public enum HedefKutu { Onay, Sikayet };
    public enum Renk { Mavi, Ye�il, Gri, K�rm�z�};
    public enum Sembol { H, X, K, Yok};

    public HedefKutu hedefKutu;
    public Sprite kitapAcik;
    public int olay;
    [TextArea] public string sayfa1;
    [TextArea] public string sayfa2;
}
