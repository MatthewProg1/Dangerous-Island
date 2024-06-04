using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GardinScript : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;


    public Sprite garden;

    public List<GameObject> Slots;

    public int semenaCarrout;


    public int slot1Have;
    public int slot2Have;
    public int slot3Have;
    public int slot4Have;
    public int slot5Have;
    public int slot6Have;
    public int slot7Have;
    public int slot8Have;

    public Text text;

    public int CountFields;


    public Image panel;


    void Start()
    {

        Slots = new List<GameObject>
        {
            {slot1 },
            {slot2 },
            {slot3 },
            {slot4 },
            {slot5 },
            {slot6 },
            {slot7 },
            {slot8 }

    };

        slot1Have = PlayerPrefs.GetInt("SaveSlotField1");
        slot2Have = PlayerPrefs.GetInt("SaveSlotField2");
        slot3Have = PlayerPrefs.GetInt("SaveSlotField3");
        slot4Have = PlayerPrefs.GetInt("SaveSlotField4");
        slot5Have = PlayerPrefs.GetInt("SaveSlotField5");
        slot6Have = PlayerPrefs.GetInt("SaveSlotField6");
        slot7Have = PlayerPrefs.GetInt("SaveSlotField7");
        slot8Have = PlayerPrefs.GetInt("SaveSlotField8");

        if (slot1Have == 1)
        {
            slot1.GetComponent<SpriteRenderer>().sprite = garden;
        }

        if (slot2Have == 1)
        {
            slot2.GetComponent<SpriteRenderer>().sprite = garden;
        }

        if (slot3Have == 1)
        {
            slot3.GetComponent<SpriteRenderer>().sprite = garden;
        }

        if (slot4Have == 1)
        {
            slot4.GetComponent<SpriteRenderer>().sprite = garden;
        }

        if (slot5Have == 1)
        {
            slot5.GetComponent<SpriteRenderer>().sprite = garden;
        }

        if (slot6Have == 1)
        {
            slot6.GetComponent<SpriteRenderer>().sprite = garden;
        }

        semenaCarrout = PlayerPrefs.GetInt("SaveCountSemenaCarrout");
        CountFields = PlayerPrefs.GetInt("SaveCountFields");

        text.text = semenaCarrout + "";


       // CountTree = PlayerPrefs.GetInt("SaveCountTree");

        //CountTree = 0;
        //PlayerPrefs.SetInt("SaveCountTree", CountTree);







        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ChooseTree()
    {
        panel.gameObject.SetActive(true);
    }


    public void CreateTree()
    {
        if (semenaCarrout >= 1)
        {
            semenaCarrout -= 1;
            CountFields++;

            text.text = semenaCarrout + "";

            PlayerPrefs.SetInt("SaveCountSemenaCarrout", semenaCarrout);
            PlayerPrefs.SetInt("SaveCountFields", CountFields);


            for (int i = 0; i < Slots.Count; i++)
            {
                if (Slots[i].GetComponent<SpriteRenderer>().sprite != garden)
                {

                    Slots[i].GetComponent<SpriteRenderer>().sprite = garden;

                    Debug.Log(Slots[i].gameObject.name);

                    switch (Slots[i].gameObject.name)
                    {
                        case "farmGround":
                            slot1Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField1", slot1Have);
                            break;
                        case "farmGround (1)":
                            slot2Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField2", slot2Have);
                            break;
                        case "farmGround (2)":
                            slot3Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField3", slot3Have);
                            break;
                        case "farmGround (3)":
                            slot4Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField4", slot4Have);
                            break;
                        case "farmGround (4)":
                            slot5Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField5", slot5Have);
                            break;
                        case "farmGround (5)":
                            slot6Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField6", slot6Have);
                            break;

                        case "farmGround (6)":
                            slot7Have = 1;
                            PlayerPrefs.SetInt("SaveSlotField7", slot7Have);
                            break;
                        case "farmGround (7)":
                            slot8Have = 1;
                            PlayerPrefs.SetInt("SaveSlot8", slot8Have);
                            break;
                    }

                    break;

                }
                else
                {

                }
            }

            panel.gameObject.SetActive(false);


        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnLeft()
    {
        SceneManager.LoadScene("AnimalFarm");
    }

    public void OnRight()
    {
        SceneManager.LoadScene("Farm");
    }
}
