using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    private Vector3 playerVector;
    public int speed;

    PhotonView view;
    PhotonView view2;

    public Camera cam2;

    CreateFreeServer createFreeServer;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "CreateServer")
        {
            view = GetComponent<PhotonView>();
            view2 = cam2.GetComponent<PhotonView>();

            createFreeServer = GameObject.FindObjectOfType<CreateFreeServer>();
        }


    }




    void Update()
    {
        if (SceneManager.GetActiveScene().name == "CreateServer")
        {
            if (view.IsMine && view2.IsMine)
            {
                if (createFreeServer.startGame)
                {
                    cam2.GetComponent<Camera>().enabled = false;

                    GetComponent<Camera>().enabled = true;
                }
                else
                {
                    cam2.GetComponent<Camera>().enabled = true;

                    GetComponent<Camera>().enabled = false;
                }
            }
        }

        playerVector = player.position;

        playerVector.z = -10;
        transform.position = Vector3.Lerp(transform.position, playerVector, speed * Time.deltaTime);
    }
}
