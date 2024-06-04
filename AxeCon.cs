using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AxeCon : MonoBehaviour
{

    PhotonView view;

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<Remove>().HpAxe;

        view = GetComponent<PhotonView>();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (view.IsMine)
        {
            if(collision.gameObject.tag == "Vrag" || collision.gameObject.tag == "Player")
            {
                player.GetComponent<WalkOnline>().HpAxe -= 1;

                if (player.GetComponent<WalkOnline>().buyAxe == 0)
                {
                    GetComponent<BoxCollider2D>().enabled = false;
                    GetComponent<SpriteRenderer>().enabled = false;
                }
            }
        }
    }
}
