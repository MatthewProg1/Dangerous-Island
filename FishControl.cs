using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishControl : MonoBehaviour
{

    bool right;
    bool left;
    bool up;
    bool down;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.Translate(Vector3.right * 4 * Time.deltaTime);
        }

        if (left)
        {
            transform.Translate(Vector3.left * 4 * Time.deltaTime);
        }

        if (up)
        {
            transform.Translate(Vector3.up * 4 * Time.deltaTime);
        }

        if (down)
        {
            transform.Translate(Vector3.down * 4 * Time.deltaTime);
        }
    }

    public void OnLeft()
    {
        left = true;
        right = false;
        up = false;
        down = false;
    }

    public void OnRight()
    {
        left = false;
        right = true;
        up = false;
        down = false;
    }

    public void OnUp()
    {
        left = false;
        right = false;
        up = true;
        down = false;
    }

    public void OnDown()
    {
        left = false;
        right = false;
        up = false;
        down = true;
    }

    public void OnUpTouch()
    {
        left = false;
        right = false;
        up = false;
        down = false;
    }
}
