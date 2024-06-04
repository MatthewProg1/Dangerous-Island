using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CreateGuildMenu : MonoBehaviour
{
    // Start is called before the first frame update

    float x = 0;
    float y = 0;
    float z = 0;

    string guild;

    public MenuManager menu;

    public Text text;

  

    public Image im1;



    private void OnEnable()
    {
        x = UnityEngine.Random.Range(0, 1f);
        y = UnityEngine.Random.Range(0, 1f);
        z = UnityEngine.Random.Range(0, 1f);

        x = (float) Math.Round(x, 2);
        y = (float) Math.Round(y, 2);
        z = (float) Math.Round(z, 2);

        guild = x.ToString() + y.ToString() + z.ToString();
        text.text = guild;
        im1.color = new Color(x, y, z);
    
    }

    public void CreteGuild()
    {
        guild = x.ToString() + y.ToString() + z.ToString();
        PlayerPrefs.SetFloat("SaveNewGuildX", x);
        PlayerPrefs.SetFloat("SaveNewGuildY", y);
        PlayerPrefs.SetFloat("SaveNewGuildZ", z);
        menu.Guldia();
    }



    // Update is called once per frame
    void Update()
    {
       

        //string str = x.ToString();
        //Debug.Log(str[1]);
    }
}
