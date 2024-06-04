using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedBoss : MonoBehaviour
{
    public GameObject dyx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);



    }


}
