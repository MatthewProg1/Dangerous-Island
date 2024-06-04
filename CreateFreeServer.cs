using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;


public class CreateFreeServer : MonoBehaviourPunCallbacks
{
    public GameObject tree1;
    public GameObject island1;
    public GameObject most1;
    public GameObject Hosmost1;

    public Transform Spavn;


    public GameObject UICreater;
    public GameObject UIPlayer;

    public GameObject SpavnPlayers;


    public bool startGame = false;

    PhotonView view;



    void Start()
    {
        
        view = GetComponent<PhotonView>();

        if (view.IsMine)
        {
     
            UIPlayer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (startGame)
            {
                UIPlayer.SetActive(true);
                UICreater.SetActive(false);


            }
            else
            {
                UICreater.SetActive(true);
                UIPlayer.SetActive(false);

            }
        }
    }

    public void SpavnTree1()
    {
        PhotonNetwork.Instantiate(tree1.name, new Vector3(3, 2, 4), Quaternion.identity);
    }

    public void SpavnIsland1()
    {
        PhotonNetwork.Instantiate(island1.name, new Vector3(3, 2, 4), Quaternion.identity);
    }
    public void SpavnMost1()
    {
        PhotonNetwork.Instantiate(most1.name, new Vector3(3, 2, 4), Quaternion.identity);
    }

    public void SpavnHosMost1()
    {
        PhotonNetwork.Instantiate(Hosmost1.name, new Vector3(3, 2, 4), Quaternion.identity);
    }



    public void StartGame()
    {
        if (view.IsMine)
        {
            PhotonNetwork.Instantiate(SpavnPlayers.name, new Vector3(3, 2, 4), Quaternion.identity);

            RoomOptions roomOptions = new RoomOptions();

            roomOptions.IsVisible = true;

            //UICreater.SetActive(false);
            //UIPlayer.SetActive(true);

            //cam1.gameObject.SetActive(false);
            //cam2.gameObject.SetActive(true);

            startGame = true;
        }
    }







}

