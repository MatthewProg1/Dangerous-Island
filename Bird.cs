using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    int turn = 0;

    public bool start { get; set; }


    public GameObject bird;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Birdss());
    }

    // Update is called once per frame
    void Update()
    {
        if(turn == 1)
        {
            if (transform.position.x > 10.99)
            {
                transform.position = new Vector3(-15.23f, -3.74f, 0);
                turn = 0;

                StartCoroutine(Birdss());
            }
            else
            {
                transform.Translate(Vector3.right * 3 * Time.deltaTime);
              
            }

            

      
        }
        else
        {

            bird.SetActive(true);
            transform.position = new Vector3(-15.23f, -3.74f, 0);


         
        }
    }




    public IEnumerator Birdss()
    {
        yield return new WaitForSeconds(20);
        turn = 1;


        StartCoroutine(Wait());
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.5f);

        if(Random.Range(1, 10) < 3)
        {
            bird.SetActive(false);
        }

        start = true;

        StartCoroutine(Wait2());
    }

    public IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2.5f);

        start = false;
    }
}
