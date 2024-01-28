using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioSource backgroundMusic; // Arka plandaki müziði çalmak için kullanýlacak ses kaynaðý
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
        // Müziði baþlat
        backgroundMusic.Play();
        PlayerPrefs.SetInt("kontrol", 1);
    }

    public void StopBackgroundMusic()
    {
        // Müziði durdur
        backgroundMusic.Stop();
        PlayerPrefs.SetInt("kontrol", 0);
    }

  
   

}
