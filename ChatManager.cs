using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class ChatManager : MonoBehaviour, Photon.Pun.IPunObservable
{
    public PhotonView view;

    public WalkOnline walk;
   

    public GameObject BubblesSpeechObject;

    public Text UpdatingText;

    public Button Send;

    private InputField ChatInputField;

    private bool DisableSend;

    bool send = false;

    


    // Start is called before the first frame update
    private void Awake()
    {
        ChatInputField = GameObject.FindGameObjectWithTag("ChatInputField").GetComponent<InputField>();

        Send = GameObject.FindGameObjectWithTag("Send").GetComponent<Button>();

     

        Send.onClick.AddListener(OnSendText);
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Debug.Log(ChatInputField.text.Length);

            if(!DisableSend)
            {
                if(ChatInputField.text.Length > 0 && send == true)
                {
                    view.RPC("SendMessage", RpcTarget.AllBuffered, ChatInputField.text);

                    if(ChatInputField.text == "GiveMeATable1")
                    {
                        walk.CountTable += 2;
                        walk.tables.text = walk.CountTable + "";
                    }

                    BubblesSpeechObject.SetActive(true);

                    ChatInputField.text = "";

                    DisableSend = true;


                }
            }
        }
    }

    [PunRPC]

    private void SendMessage(string message)
    {
        UpdatingText.text = message;
        StartCoroutine(Remove());
    }

    IEnumerator Remove()
    {
        yield return new WaitForSeconds(3);

        BubblesSpeechObject.SetActive(false);
        DisableSend = false;
        send = false;
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo message)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(BubblesSpeechObject.active);
        }else if (stream.IsReading)
        {
            BubblesSpeechObject.SetActive((bool)stream.ReceiveNext());
        }
    }

    public void OnSendText()
    {
        send = true;
    }

   
}
