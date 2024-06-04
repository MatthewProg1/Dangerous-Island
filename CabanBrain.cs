using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabanBrain : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 target;

    public float speed = 0.5f;


    void Start()
    {
        target = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
      transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


        if(transform.position == target)
        {
            target = GetRandomPosition();
        }
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-1.01f, 1.51f);
        float y = Random.Range(-2.25f, -0.2f);

        if(x > 0)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 1);
        }
        if(x < 0)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 1);
        }

        return new Vector3(x, y, transform.position.z);



        //-1.01f, 1.51f
    }
}
