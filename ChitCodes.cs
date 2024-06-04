using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChitCodes : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Caban;



    


    public bool ChitOn = false;

    public InputField InputChits;

    public string chitKod;


    void Start()
    {



        chitKod = PlayerPrefs.GetString("SaveChit");

        if (chitKod == "Caban")
        {
            ChitOn = true;
            if (ChitOn == false)
            {
                return;
            }



            for (int i = 0; i < 6; i++)
            {
                Instantiate(Caban, new Vector3(0, -1), Quaternion.identity);
            }

            chitKod = "";
            PlayerPrefs.SetString("SaveChit", chitKod);
            ChitOn = false;

        }

      



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterChits()
    {
        chitKod = InputChits.text;
        PlayerPrefs.SetString("SaveChit", chitKod);
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
