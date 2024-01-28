using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioSource backgroundMusic; // Arka plandaki m�zi�i �almak i�in kullan�lacak ses kayna��
    int kontrol;
    private void Start()
    {
        kontrol = PlayerPrefs.GetInt("kontrol", 1);
        if (kontrol == 0)
        {
            backgroundMusic.Stop();
        }
    }

    public void PlayBackgroundMusic()
    {
        // M�zi�i ba�lat
        backgroundMusic.Play();
        PlayerPrefs.SetInt("kontrol", 1);
    }

    public void StopBackgroundMusic()
    {
        // M�zi�i durdur
        backgroundMusic.Stop();
        PlayerPrefs.SetInt("kontrol", 0);
    }

  
   

}
