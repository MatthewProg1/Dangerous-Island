using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    AudioSource audio;
    public AudioClip din;

    public int music;
    int first;

    void Start()
    {
        music = PlayerPrefs.GetInt("SaveMusic");
        audio = GetComponent<AudioSource>();

        first = PlayerPrefs.GetInt("SaveFirstM");

        if (first == 0)
        {
            music = 1;
        }

        if (music == 1)
        {


            audio.GetComponent<AudioSource>().volume = 1;


            audio.PlayOneShot(din);
        }
        else
        {
            audio.GetComponent<AudioSource>().volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
