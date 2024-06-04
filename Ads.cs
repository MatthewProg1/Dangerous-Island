using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{

    public string id = "4553997";
    public bool testMode;
    private static Ads ads;
    public int CountShow;



    // Start is called before the first frame update
    void Start()
    {

        CountShow = PlayerPrefs.GetInt("SaveCountShow");

        if(ads == null)
        {
            ads = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Advertisement.Initialize(id, testMode);

        if(CountShow >= 3)
        {
            ShowAd();
            CountShow = 0;
            PlayerPrefs.SetInt("SaveCountShow", CountShow);
            PlayerPrefs.Save();

        }

       // Advertisement.Show("Rewarded_Android");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowAd()
    {
        Advertisement.Show("Rewarded_Android");
       // Debug.Log(CountShow);
    }


}
