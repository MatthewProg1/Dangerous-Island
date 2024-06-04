using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOctupus : MonoBehaviour
{

    public GameObject Vaolna1;


    public GameObject Tree;

    public GameObject predyprechdenie;

    public GameObject Player;

    public int Count;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Wait()
    {

        yield return new WaitForSeconds(90);
        GetComponent<SpriteRenderer>().enabled = true;
        StartCoroutine(Attack1());

    }

    public IEnumerator Attack1()
    {
        if (Count < 8)
        {
            Tree.transform.position = Player.transform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), 0);
            Count++;
            yield return new WaitForSeconds(1.75f);
            StartCoroutine(Attack1());
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Tree.transform.position = Player.transform.position + new Vector3(100, 100, 0);
        }
        
    }

    //public IEnumerator Attack2()
    //{
    //    if (Count < 6)
    //    {
    //        if (Count % 2 == 0)
    //        {
    //            predyprechdenie.transform.position = new Vector3(1.17f, -1.645f, predyprechdenie.transform.position.z);
    //        }
    //        else
    //        {
    //            predyprechdenie.transform.position = new Vector3(-0.72f, -1.645f, predyprechdenie.transform.position.z);
    //        }
    //  //      Instantiate(Tree, Player.transform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Player.transform.position.z), Quaternion.identity);

    //        Count++;
    //        yield return new WaitForSeconds(1f);
    //        StartCoroutine(Attack2Fase2());
    //    }
    //    else
    //    {
    //        StartCoroutine(Attack1());
    //    }
       
    //}

    //public IEnumerator Attack2Fase2()
    //{

    //    predyprechdenie.transform.position = new Vector3(100, -1.645f, Vaolna1.transform.position.z);
        
    //   if (Count % 2 == 0)
    //   {
    //        Vaolna1.transform.localScale = new Vector3(1, 1, 1);

    //        Vaolna1.transform.position = new Vector3(3.588f, -2.622f, Vaolna1.transform.position.z);
    //   }
    //    else
    //    {
    //        Vaolna1.transform.localScale = new Vector3(-1, 1, 1);

    //        Vaolna1.transform.position = new Vector3(-3.34f, -2.622f, Vaolna1.transform.position.z);

    //    }
    //        //      Instantiate(Tree, Player.transform.position + new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Player.transform.position.z), Quaternion.identity);

    //        Count++;
    //        yield return new WaitForSeconds(1.5f);
    //        StartCoroutine(Attack2());
        

    //}


}
