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
            string kullanýcý = Environment.UserName;
            if (string.IsNullOrEmpty(kullanýcý))
            {
                TelSahne.tamMetin = "Dikkatini ölçmek için yaptýðýmýz testi baþarýyla geçtin.Seni daha üst düzey bir görevde görmekten memnuniyet duyarýz.Tebrikler Memur";
            }
            else
            {
                TelSahne.tamMetin = "Dikkatini ölçmek için yaptýðýmýz testi baþarýyla geçtin. Seni daha üst düzey bir görevde görmekten memnuniyet duyarýz. Tebrikler " + kullanýcý;
            }
            TelSahne.Final = 1;
            karartma.Karart();
        }
    }
}
