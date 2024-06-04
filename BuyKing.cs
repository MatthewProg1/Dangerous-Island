using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;


public class BuyKing : MonoBehaviour
{
    // Start is called before the first frame update

    int haveKing1;

    public void OnBuyComplete(Product product)
    {
        // Debug.Log("Yes");

        haveKing1 = 1;
        PlayerPrefs.SetInt("SaveKing", haveKing1);
      

        FindObjectOfType<Shop>().OnPurchase();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
