using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public GameObject light;
    public GameObject sand;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Day());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator Day()
    {
        sand.transform.position = new Vector3(39.97f, sand.transform.position.y, sand.transform.position.z);
        yield return new WaitForSeconds(14);
        StartCoroutine(Day2());
     
    }

    public IEnumerator Day2()
    {
     

        for (int i = 0; i < 40; i++)
        {
            light.transform.Rotate(1, 0, 0);
            yield return new WaitForSeconds(0.025f);
        }
       
        StartCoroutine(Night());

    }

    public IEnumerator Night()
    {
        sand.transform.position = new Vector3(13.91f, sand.transform.position.y, sand.transform.position.z);
        yield return new WaitForSeconds(14);
        light.transform.Rotate(-20, 0, 0);
        StartCoroutine(Night2());
        
    }

    public IEnumerator Night2()
    {
        for (int i = 0; i < 40; i++)
        {
            light.transform.Rotate(-1, 0, 0);
            yield return new WaitForSeconds(0.025f);
        }

        StartCoroutine(Day());
    }
}
