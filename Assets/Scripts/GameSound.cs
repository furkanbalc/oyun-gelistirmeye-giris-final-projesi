using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound : MonoBehaviour
{
    public AudioSource backgroundMusic;
    int kontrol;
    
    void Start()
    {
        kontrol = PlayerPrefs.GetInt("kontrol", 1);
        if (kontrol==0)
        {
            backgroundMusic.Stop();
        }
    }

 
}
