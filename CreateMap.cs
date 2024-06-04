using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateMap : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tree1;
    public GameObject island1;
    public GameObject most1;
    public GameObject Hosmost1;

    public Transform Spavn;

    public GameObject UIPlayer;
    public GameObject UICreater;

    public GameObject Vrag1;
    public GameObject Vrag2;
    public GameObject Vrag3;
    public GameObject Vrag4;
    public GameObject Vrag5;

    public GameObject Vrag6;
    public GameObject Vrag7;
    public GameObject Vrag8;
    public GameObject Vrag9;
    public GameObject Vrag10;

    public Camera cam1;
    public Camera cam2;

    public bool startGame = false;


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpavnTree1()
    {
        Instantiate(tree1, new Vector3(3, 2, 4), Quaternion.identity);
    }

    public void SpavnIsland1()
    {
        Instantiate(island1, new Vector3(3, 2, 4), Quaternion.identity);
    }
    public void SpavnMost1()
    {
        Instantiate(most1, new Vector3(3, 2, 4), Quaternion.identity);
    }

    public void SpavnHosMost1()
    {
        Instantiate(Hosmost1, new Vector3(3, 2, 4), Quaternion.identity);
    }

    public void StartGame()
    {
        UICreater.SetActive(false);
        UIPlayer.SetActive(true);

        Vrag1.GetComponent<TurnMost2>().enabled = true;
        Vrag2.GetComponent<TurnMost2>().enabled = true;
        Vrag3.GetComponent<TurnMost2>().enabled = true;
        Vrag4.GetComponent<TurnMost2>().enabled = true;
        Vrag5.GetComponent<TurnMost2>().enabled = true;
        Vrag6.GetComponent<TurnMost2>().enabled = true;
        Vrag7.GetComponent<TurnMost2>().enabled = true;
        Vrag8.GetComponent<TurnMost2>().enabled = true;
        Vrag9.GetComponent<TurnMost2>().enabled = true;
        Vrag10.GetComponent<TurnMost2>().enabled = true;

        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);

        startGame = true;
    }







}
