using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CanvasOnlineOff : MonoBehaviour
{
    // Start is called before the first frame update

  

    
    public GameObject part1;
    public GameObject part2;

    PhotonView view1;
    PhotonView view2;
    PhotonView view3;



    CreateFreeServer createFreeServer;

    void Start()
    {
        view1 = part1.GetComponent<PhotonView>();
        view2 = part2.GetComponent<PhotonView>();
        view3 = GetComponent<PhotonView>();


        createFreeServer = GameObject.FindObjectOfType<CreateFreeServer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (view1.IsMine && view2.IsMine && view3.IsMine)
        {
            Debug.Log("DDD");
            
        }
    }
}
