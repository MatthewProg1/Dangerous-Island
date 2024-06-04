using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnimalsFarm : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public GameObject slot5;
    public GameObject slot6;
    public GameObject slot7;
    public GameObject slot8;
    public GameObject slot9;
    public GameObject slot10;

    public List<GameObject> Slots;

    public int korm;


    //public int slot1Have;
    //public int slot2Have;
    //public int slot3Have;
    //public int slot4Have;
    //public int slot5Have;
    //public int slot6Have;
    //public int slot7Have;
    //public int slot8Have;
    //public int slot9Have;
    //public int slot10Have;

    public Text textCows;
    public Text textKorm;
    public Text textMoney;

    public int CountCows;


    public Image panel;
    public Image panelBuyKorm;
    public Image panelBuyCow;

    public int money;


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
            {slot8 },
            {slot9 },
            {slot10 }

    };

        //slot1Have = PlayerPrefs.GetInt("SaveSlotField1");
        //slot2Have = PlayerPrefs.GetInt("SaveSlotField2");
        //slot3Have = PlayerPrefs.GetInt("SaveSlotField3");
        //slot4Have = PlayerPrefs.GetInt("SaveSlotField4");
        //slot5Have = PlayerPrefs.GetInt("SaveSlotField5");
        //slot6Have = PlayerPrefs.GetInt("SaveSlotField6");
        //slot7Have = PlayerPrefs.GetInt("SaveSlotField7");
        //slot8Have = PlayerPrefs.GetInt("SaveSlotField8");

        CountCows = PlayerPrefs.GetInt("SaveCountCows");

        korm = PlayerPrefs.GetInt("SaveKorm");

        money = PlayerPrefs.GetInt("SaveMoney2");



        if (CountCows == 1)
        {
            slot1.SetActive(true);
        }

        if (CountCows == 2)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
        }

        if (CountCows == 3)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
        }

        if (CountCows == 4)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
        }

        if (CountCows == 5)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
        }

        if (CountCows == 6)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
        }

        if (CountCows == 7)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
        }

        if (CountCows == 8)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);
        }

        if (CountCows == 9)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);
            slot9.SetActive(true);
        }

        if (CountCows == 10)
        {
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);
            slot9.SetActive(true);
            slot10.SetActive(true);
        }

        textCows.text = CountCows + "";
        textMoney.text = money + "";
        textKorm.text = korm + "";


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


    public void CreateCow()
    {
        if (korm >= 1 && CountCows >= 2)
        {
            korm -= 1;
            CountCows++;

            textCows.text = CountCows + "";

            textKorm.text = korm + "";


            PlayerPrefs.SetInt("SaveCountCows", CountCows);
            PlayerPrefs.SetInt("SaveKorm", korm);


            for (int i = 0; i < Slots.Count; i++)
            {
                if (Slots[i].gameObject.active == false)
                {

                    Slots[i].gameObject.SetActive(true);

                    Debug.Log(Slots[i].gameObject.name);

                    //switch (Slots[i].gameObject.name)
                    //{
                    //    case "farmGround":
                    //        slot1Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField1", slot1Have);
                    //        break;
                    //    case "farmGround (1)":
                    //        slot2Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField2", slot2Have);
                    //        break;
                    //    case "farmGround (2)":
                    //        slot3Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField3", slot3Have);
                    //        break;
                    //    case "farmGround (3)":
                    //        slot4Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField4", slot4Have);
                    //        break;
                    //    case "farmGround (4)":
                    //        slot5Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField5", slot5Have);
                    //        break;
                    //    case "farmGround (5)":
                    //        slot6Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField6", slot6Have);
                    //        break;

                    //    case "farmGround (6)":
                    //        slot7Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlotField7", slot7Have);
                    //        break;
                    //    case "farmGround (7)":
                    //        slot8Have = 1;
                    //        PlayerPrefs.SetInt("SaveSlot8", slot8Have);
                    //        break;
                    //}

                    break;

                }
                else
                {

                }
            }

            panel.gameObject.SetActive(false);


        }


    }


    public void BuyCowsFeed()
    {
        if(money >= 8)
        {
            money -= 8;
            korm++;

            textKorm.text = korm + "";
            textMoney.text = money + "";

            PlayerPrefs.SetInt("SaveKorm", korm);
            PlayerPrefs.SetInt("SaveMoney2", money);

        }

        panelBuyKorm.gameObject.SetActive(false);
    }

    

    public void ChooseCowsFeed()
    {
        panelBuyKorm.gameObject.SetActive(true);
    }

    public void BuyCow()
    {
        if (money >= 15)
        {
            money -= 15;
            CountCows++;

            textCows.text = korm + "";
            textMoney.text = money + "";

            PlayerPrefs.SetInt("SaveCountCows", CountCows);
            PlayerPrefs.SetInt("SaveMoney2", money);

            for (int i = 0; i < Slots.Count; i++)
            {
                if (Slots[i].gameObject.active == false)
                {

                    Slots[i].gameObject.SetActive(true);

                    Debug.Log(Slots[i].gameObject.name);

                    break;

                }
                else
                {

                }
            }

        }

        panelBuyCow.gameObject.SetActive(false);
    }



    public void ChooseCow()
    {
        panelBuyCow.gameObject.SetActive(true);
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnLeft()
    {
        SceneManager.LoadScene("Farm");
    }

    public void OnRight()
    {
        SceneManager.LoadScene("garden");
    }
}
