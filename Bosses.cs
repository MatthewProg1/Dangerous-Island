using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bosses : MonoBehaviour
{

    public int Boss;

    public Sprite classic;
    public Sprite Dead;
    public Sprite Elf;
    public Sprite Sand;

    public GameObject knife1;
    public GameObject knife2;

    public GameObject sandAttack;


    public GameObject gost;

    public Transform player;


    int speed = 5;

    int gostsCounter = 5;

    public Animator SandAnim;

    


    // Start is called before the first frame update
    void Start()
    {

    
        RandomChoose();

    }

    // Update is called once per frame
    void Update()
    {
        if (Boss == 1)
        {
            if (knife1.transform.position.x > 10.99f)
            {
                knife1.transform.position = new Vector3(-15.23f, Random.Range(-1.47f, -0.9f), 0);
            }
            else
            {
                knife1.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (knife2.transform.position.x > 10.99)
            { 
                knife2.transform.position = new Vector3(-15.23f, Random.Range(-1.47f, -0.9f), 0);
            }
            else
            {
                knife2.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

          
        }



        
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(15);
        Boss = Random.Range(1, 3);
        RandomChoose();
        
        speed++;
        StartCoroutine(Wait());
    }

    public IEnumerator Gost()
    {
        if (gostsCounter > 0)
        {
            gost.transform.position = new Vector3(-0.01f, -0.31f, 0);
            gost.transform.position = Vector2.MoveTowards(gost.transform.position, player.position, (speed - 4.5f) * Time.deltaTime);
            
            yield return new WaitForSeconds(3);
            gostsCounter--;

            StartCoroutine(Gost());
        }

    }

    public IEnumerator SandAttack()
    {
        sandAttack.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(10);
        sandAttack.GetComponent<Animator>().enabled = false;
        sandAttack.transform.position = new Vector3(100, 100, transform.position.z);
    }

    public void RandomChoose()
    {
        Boss = Random.Range(1, 6);

        if (Boss == 1)
        {
            GetComponent<SpriteRenderer>().sprite = classic;
        }

        if (Boss == 2)
        {
            GetComponent<SpriteRenderer>().sprite = Dead;
            gost.transform.position = new Vector3(-0.01f, -0.31f, 0);
            StartCoroutine(Gost());
        }

        if (Boss == 3)
        {
            GetComponent<SpriteRenderer>().sprite = Elf;
        }

        if (Boss > 3)
        {
            GetComponent<SpriteRenderer>().sprite = Sand;
            StartCoroutine(SandAttack());
        }

        StartCoroutine(Wait());
    }

    

    




}
