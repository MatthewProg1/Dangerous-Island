using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss1 : MonoBehaviour
{
    int star = 0;

    public int boss;

    public int beboss;




    // Start is called before the first frame update
    void Start()
    {
    
            StartCoroutine(Sword1());
      
    }

    // Update is called once per frame
    void Update()
    {
       
            if (beboss == 0)
            {
                if (star == 1)
                {
                    if (transform.position.x > 10.99)
                    {
                        transform.position = new Vector3(-15.23f, -1.47f, 0);
                    }
                    else
                    {
                        transform.Translate(Vector3.right * 10 * Time.deltaTime);
                    }
                }
                else
                {
                    transform.position = new Vector3(-15.23f, -1.47f, 0);
                }
            }
            if (beboss == 1)
            {

                if (boss == 1)
                {
                    GetComponent<SpriteRenderer>().enabled = true;
                }
                else
                {
                    GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        
    }

    public IEnumerator Sword1()
    {
        star = 0;
        yield return new WaitForSeconds(115);

        star = 1;
        boss = 1;

        StartCoroutine(Sword2());


    }

    public IEnumerator Sword2()
    {

        yield return new WaitForSeconds(10);

        star = 0;
        boss = 0;


    }
}
