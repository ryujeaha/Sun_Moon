using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiMicScript_2 : MonoBehaviour
{
    public GameObject P1_Wall, P2_Wall;
    public GameObject door;
    public int pId;

    bool onPlayer;

    private void Update()
    {
        if (onPlayer) door.SetActive(false);
        else door.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "P1" && pId == 1)
        {
            onPlayer = true;
        }
        else if (collision.gameObject.tag == "P1" && pId == 2)
        {
            GameObject Ui = GameObject.Find("Death");
            Ui.GetComponent<Death>().Death_Player();
        }

        else if (collision.gameObject.tag == "P2" && pId == 2)
        {
            onPlayer = true;
        }
        else if (collision.gameObject.tag == "P2" && pId == 1)
        {
            GameObject Ui = GameObject.Find("Death");
            Ui.GetComponent<Death>().Death_Player();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "P1" || collision.gameObject.tag == "P2")
        {
            onPlayer = false;
        }
    }

}

