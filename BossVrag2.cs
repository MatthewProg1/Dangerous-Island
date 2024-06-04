using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossVrag2 : MonoBehaviour
{
    public int star;
    public int l = 0;
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sword1());
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(star == 1)
        {
            GetComponent<SpriteRenderer>().enabled = true;

            if (l == 0)
            {
                transform.Translate(Vector3.down * 4 * Time.deltaTime);
                transform.Translate(Vector3.right * 10f * Time.deltaTime);
                if (transform.position.y < -3.089)
                {
                    transform.position = new Vector3(x, y, 1);
                }
            }
            if (l == 1)
            {
                transform.Translate(Vector3.down * 4 * Time.deltaTime);
                transform.Translate(Vector3.left * 10f * Time.deltaTime);
                if (transform.position.y < -3.089)
                {
                    transform.position = new Vector3(x, y, 1);
                }
            }


            
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public IEnumerator Sword1()
    {
        star = 0;
        yield return new WaitForSeconds(115);

        star = 1;


        StartCoroutine(Sword2());


    }

    public IEnumerator Sword2()
    {

        yield return new WaitForSeconds(15);

        star = 0;



    }
}
