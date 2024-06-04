using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireControll : MonoBehaviour
{
    // Start is called before the first frame update

    public int hp = 100;
    public Slider slider;

    public GameObject Killer;

    public bool plus = false;

    void Start()
    {
        slider.value = hp;

        Killer.SetActive(false);

        StartCoroutine(Minus());




    }

    // Update is called once per frame
    void Update()
    {
        if( hp <= 0)
        {
            Killer.SetActive(true);
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            plus = true;

            StartCoroutine(Plus());
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            plus = false;

            StartCoroutine(Minus());
        }
    }

    public IEnumerator Plus()
    {
        yield return new WaitForSeconds(1);
        if (hp <= 100)
        {
            hp += 10;
        }
        slider.value = hp;

        if (plus)
        {
            StartCoroutine(Plus());
        }

    }

    public IEnumerator Minus()
    {
        yield return new WaitForSeconds(1);
        hp -= 10;
        slider.value = hp;

        if (plus == false)
        {
            StartCoroutine(Minus());
        }

    }
}
