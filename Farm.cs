using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Farm : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;


    public Sprite tree;

    public List<GameObject> Slots;

    public int semena;


    public int slot1Have;
    public int slot2Have;
    public int slot3Have;
    public int slot4Have;
    public int slot5Have;
    public int slot6Have;

    public Text text;

    public int CountTree;











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
            {slot6 }

    };

        slot1Have = PlayerPrefs.GetInt("SaveSlot1");
        slot2Have = PlayerPrefs.GetInt("SaveSlot2");
        slot3Have = PlayerPrefs.GetInt("SaveSlot3");
        slot4Have = PlayerPrefs.GetInt("SaveSlot4");
        slot5Have = PlayerPrefs.GetInt("SaveSlot5");
        slot6Have = PlayerPrefs.GetInt("SaveSlot6");

        if(slot1Have == 1)
        {
            slot1.GetComponent<SpriteRenderer>().sprite = tree;
        }

        if (slot2Have == 1)
        {
            slot2.GetComponent<SpriteRenderer>().sprite = tree;
        }

        if (slot3Have == 1)
        {
            slot3.GetComponent<SpriteRenderer>().sprite = tree;
        }

        if (slot4Have == 1)
        {
            slot4.GetComponent<SpriteRenderer>().sprite = tree;
        }

        if (slot5Have == 1)
        {
            slot5.GetComponent<SpriteRenderer>().sprite = tree;
        }

        if (slot6Have == 1)
        {
            slot6.GetComponent<SpriteRenderer>().sprite = tree;
        }

        semena = PlayerPrefs.GetInt("SaveSemena");

        text.text = semena + "";


        CountTree = PlayerPrefs.GetInt("SaveCountTree");

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
        if(semena >= 1)
        {
            semena -= 1;
            CountTree++;

            text.text = semena + "";

            PlayerPrefs.SetInt("SaveSemena", semena);
            PlayerPrefs.SetInt("SaveCountTree", CountTree);


            for (int i = 0; i < Slots.Count; i++)
            {
                if(Slots[i].GetComponent<SpriteRenderer>().sprite != tree)
                {

                    Slots[i].GetComponent<SpriteRenderer>().sprite = tree;

                    Debug.Log(Slots[i].gameObject.name);

                    switch (Slots[i].gameObject.name)
                    {
                        case "roundtree":
                            slot1Have = 1;
                            PlayerPrefs.SetInt("SaveSlot1", slot1Have);
                            break;
                        case "roundtree (1)":
                            slot2Have = 1;
                            PlayerPrefs.SetInt("SaveSlot2", slot2Have);
                            break;
                        case "roundtree (2)":
                            slot3Have = 1;
                            PlayerPrefs.SetInt("SaveSlot3", slot3Have);
                            break;
                        case "roundtree (3)":
                            slot4Have = 1;
                            PlayerPrefs.SetInt("SaveSlot4", slot4Have);
                            break;
                        case "roundtree (4)":
                            slot5Have = 1;
                            PlayerPrefs.SetInt("SaveSlot5", slot5Have);
                            break;
                        case "roundtree (5)":
                            slot6Have = 1;
                            PlayerPrefs.SetInt("SaveSlot6", slot6Have);
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
        SceneManager.LoadScene("garden");
    }

    public void OnRight()
    {
        SceneManager.LoadScene("AnimalFarm");
    }
}
