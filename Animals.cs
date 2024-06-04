using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject animal;


    void Start()
    {
        animal.SetActive(false);

        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        if(Random.Range(1, 100) > 31)
        {
            animal.SetActive(true);
            animal.transform.position = new Vector2(-1.11f, -0.41f);
            StartCoroutine(Wait2());
        }
        else
        {
            StartCoroutine(Wait());
        }
    }

    public IEnumerator Wait2()
    {
        yield return new WaitForSeconds(10);

        StartCoroutine(Wait());

        animal.transform.position = new Vector2(100, 100);


    }


}
