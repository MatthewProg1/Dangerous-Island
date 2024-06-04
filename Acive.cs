using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Acive : MonoBehaviour
{



    public int dieds;

    public Text kills1;
    public Text kills2;
    public Text bro;
    public Text sereb;
    public Text gold;
    public Text betgold;

    public Image k1;
    public Image k2;
    public Image go;
    public Image br;
    public Image se;
    public Image bg;

    public Sprite yes;

    public int score;

    public int b;
    public int s;
    public int g;

    public int bgo;

    public int iz;


    public int HaveKills1;
    public int HaveKills2;








    // Start is called before the first frame update
    void Start()
    {
        dieds = PlayerPrefs.GetInt("SaveKills");
        score = PlayerPrefs.GetInt("SaveScore");
        iz = PlayerPrefs.GetInt("SaveIzy");

        HaveKills1 = PlayerPrefs.GetInt("SaveFirstKill");
        HaveKills2 = PlayerPrefs.GetInt("SaveSecondKill");


        if (dieds >= 6)
        {
            k1.GetComponent<Image>().sprite = yes;

            if(HaveKills1 == 0)
            {
                HaveKills1 = 1;
                iz = iz + 1;
                PlayerPrefs.SetInt("SaveFirstKill", HaveKills1);
                PlayerPrefs.Save();
            }
            
        }

        if (dieds >= 20)
        {
            k2.GetComponent<Image>().sprite = yes;

            if (HaveKills2 == 0)
            {
                HaveKills2 = 1;
                iz = iz + 2;
                PlayerPrefs.SetInt("SaveSecondKill", HaveKills2);
                PlayerPrefs.Save();
            }
        }

        if(b == 1)
        {
            br.GetComponent<Image>().sprite = yes;

            b = 1;
            PlayerPrefs.SetInt("SaveBron", b);
            bro.text = "1/1";
        }

        if (s == 1)
        {
            se.GetComponent<Image>().sprite = yes;

            s = 1;
            PlayerPrefs.SetInt("SaveSeb", s);
            sereb.text = "1/1";
        }

        if (g == 1)
        {
            go.GetComponent<Image>().sprite = yes;

            g = 1;
            PlayerPrefs.SetInt("SaveGold", g);
            gold.text = "1/1";
        }

        if (bgo == 1)
        {
            bg.GetComponent<Image>().sprite = yes;

            bgo = 1;
            PlayerPrefs.SetInt("SaveBetGold", bgo);
            betgold.text = "1/1";
        }

        if (score >= 40 && b == 0)
        {
            br.GetComponent<Image>().sprite = yes;

            

            b = 1;
            PlayerPrefs.SetInt("SaveBron", b);
            PlayerPrefs.Save();

            bro.text = "1/1";
        }

        if (score >= 100 && s == 0)
        {
            se.GetComponent<Image>().sprite = yes;
          

            s = 1;

            PlayerPrefs.SetInt("SaveSeb", s);
       
            PlayerPrefs.Save();
            sereb.text = "1/1";
        }

        if (score >= 150 && g == 0)
        {
            go.GetComponent<Image>().sprite = yes;
        

            g = 1;
            PlayerPrefs.SetInt("SaveGold", g);

       
            PlayerPrefs.Save();
            gold.text = "1/1";
        }

       






    }

    // Update is called once per frame
    void Update()
    {

        dieds = PlayerPrefs.GetInt("SaveKills");

       

        kills1.text = dieds + "/6";
        kills2.text = dieds + "/20";
       



        



    }

    public void OnClcik()
    {
        SceneManager.LoadScene("Menu");
    }
}
