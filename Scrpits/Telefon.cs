using UnityEngine;
using System;

public class Telefon : MonoBehaviour
{
    int sayac = 0;
    public Karartma karartma;

    public void tlfnBtn()
    {
        sayac++;
        if (sayac == 9)
        {
            string kullan�c� = Environment.UserName;
            if (string.IsNullOrEmpty(kullan�c�))
            {
                TelSahne.tamMetin = "Dikkatini �l�mek i�in yapt���m�z testi ba�ar�yla ge�tin.Seni daha �st d�zey bir g�revde g�rmekten memnuniyet duyar�z.Tebrikler Memur";
            }
            else
            {
                TelSahne.tamMetin = "Dikkatini �l�mek i�in yapt���m�z testi ba�ar�yla ge�tin. Seni daha �st d�zey bir g�revde g�rmekten memnuniyet duyar�z. Tebrikler " + kullan�c�;
            }
            TelSahne.Final = 1;
            karartma.Karart();
        }
    }
}
