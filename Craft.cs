using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour
{
    //public GameObject water;
    //public GameObject redis;
    //public GameObject bowl;

    public GameObject apple;
    public GameObject bottle;
    public GameObject bowl;
    public GameObject pelmen;
    public GameObject semena;
    public GameObject semenaCarrout;


    int random;

    int ApplesCount;
    int bottleCount;
    int bowlsCount;
    int pelmensCount;
    int semenaCount;
    int semenaCorrutCount;

    public int thing;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());

        ApplesCount = PlayerPrefs.GetInt("SaveApples");
        bottleCount = PlayerPrefs.GetInt("SaveBottles");
        bowlsCount = PlayerPrefs.GetInt("SaveBowls");
        pelmensCount = PlayerPrefs.GetInt("SavePelmens");
        semenaCount = PlayerPrefs.GetInt("SaveSemena");
        semenaCorrutCount = PlayerPrefs.GetInt("SaveCountSemenaCarrout");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            if (random == 1)
            {
                transform.position = new Vector3(100, 100, apple.transform.position.z);
                apple.transform.position = new Vector3(100, 100, apple.transform.position.z);

                StartCoroutine(Wait());

                ApplesCount++;

                PlayerPrefs.SetInt("SaveApples", ApplesCount);
            }

            if (random == 2)
            {
                transform.position = new Vector3(100, 100, transform.position.z);
                bottle.transform.position = new Vector3(100, 100, bottle.transform.position.z);

                StartCoroutine(Wait());

                bottleCount++;

                PlayerPrefs.SetInt("SaveBottles", bottleCount);
            }

            if (random == 3)
            {
                transform.position = new Vector3(100, 100, transform.position.z);
                bowl.transform.position = new Vector3(100, 100, bowl.transform.position.z);

                StartCoroutine(Wait());

                bowlsCount++;

                PlayerPrefs.SetInt("SaveBowls", bowlsCount);
            }

            if (random == 4 || random == 5)
            {
                transform.position = new Vector3(100, 100, transform.position.z);
                pelmen.transform.position = new Vector3(100, 100, pelmen.transform.position.z);

                StartCoroutine(Wait());

                pelmensCount++;

                PlayerPrefs.SetInt("SavePelmens", pelmensCount);
            }

            if (random == 6 || random == 7)
            {
                transform.position = new Vector3(100, 100, transform.position.z);
                semena.transform.position = new Vector3(100, 100, pelmen.transform.position.z);

                StartCoroutine(Wait());

                semenaCount++;

                PlayerPrefs.SetInt("SaveSemena", semenaCount);
            }

            if (random == 8)
            {
                transform.position = new Vector3(100, 100, transform.position.z);
                semenaCarrout.transform.position = new Vector3(100, 100, semenaCarrout.transform.position.z);

                StartCoroutine(Wait());

                semenaCorrutCount++;

                PlayerPrefs.SetInt("SaveCountSemenaCarrout", semenaCorrutCount);
            }


        }
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(15);

        random = Random.Range(1, 9);

        if (random == 1)
        {
            
            apple.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }

        if (random == 2)
        {
            bottle.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }

        if (random == 3)
        {
            bowl.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }

        if (random == 4 || random == 5)
        {
            pelmen.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }

        if (random == 6 || random == 7)
        {
            semena.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }

        if (random == 8)
        {
            semenaCarrout.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
            transform.position = new Vector3(-1.07f, -2.53f, transform.position.z);
        }





        //if (random == 1)
        //{
        //    water.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
        //}

        //if (random == 1)
        //{
        //    water.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
        //}
        //if (random == 1)
        //{
        //    water.transform.position = new Vector3(-0.09f, -1.43f, transform.position.z);
        //}




    }
}
