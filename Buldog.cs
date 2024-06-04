using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buldog : MonoBehaviour
{

    public Transform player;

    public Transform playerLeft;
    public Transform playerRight;

    public Transform verx;

    public int moveYes = 1;

    public Joystick joy;


    public float speed = 2f;

    public int x;

    public int choosePet;

    public float povorot;

    public Sprite buldog;
    public Sprite tulen;
    public Sprite bat;

    public string chitKode;
    




    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        

        choosePet = PlayerPrefs.GetInt("SaveChoosePet");
        chitKode = PlayerPrefs.GetString("SaveChit");

        if(chitKode == "FreeBuldog228Hammer2020Lol")
        {
            choosePet = 1;
        }



        if(choosePet == 1)
        {
            povorot = 0.2f;
            GetComponent<SpriteRenderer>().sprite = buldog;
            StartCoroutine(Run());
        }
        if (choosePet == 2)
        {
            povorot = 0.3f;
            GetComponent<SpriteRenderer>().sprite = tulen;
        }

        if (choosePet == 3 || choosePet == 0)
        {
            povorot = 0;
            speed = 0;
            transform.position = new Vector3(100, 100, 0);
            
        }

        if (choosePet == 4)
        {
            povorot = 0.2f;
            GetComponent<SpriteRenderer>().sprite = bat;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveYes == 1 )
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

            if (player != verx)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }

        



        if (moveYes == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if(joy.Horizontal > 0)
        {
            transform.localScale = new Vector3(povorot, povorot, 1);

            if (player != verx)
            {

                player = playerLeft;
            }
        }

        if (joy.Horizontal < 0)
        {
            transform.localScale = new Vector3(-povorot, povorot,  1);

            if (player != verx)
            {

                player = playerRight;
            }
           

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            moveYes = 0;
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "Vrag")
        {
            moveYes = 1;
            player = playerLeft;
            StartCoroutine(Run());
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moveYes = 1;
        }
    }

    public IEnumerator Run()
    {

        yield return new WaitForSeconds(4);
        x = 0;
        x = Random.Range(1, 20);

        if(x < 7)
        {
            player = verx;
            moveYes = 2;
            GetComponent<BoxCollider2D>().enabled = true;

        }
        else
        {
            moveYes = 1;
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Run());
        }
    }
}


