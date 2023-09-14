using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiMicScript : MonoBehaviour
{
    public GameObject btn1,btn2;
    public bool i,j = false;
    public GameObject Guard;
    private void Update()
    {
        if(i == true && j == true)
        {
            Guard.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.tag == "P1btn")
        {
            if (collision.gameObject.tag == "P1")
            {
                i = true;
                if(GameObject.Find("Down_button_2").GetComponent<GiMicScript>().j == true)
                {
                    j = true;
                }
            }
        }
        if (this.gameObject.tag == "P2btn")
        {
            if (collision.gameObject.tag == "P2")
            {
                j = true;
                if (GameObject.Find("Down_button_1").GetComponent<GiMicScript>().i == true)
                {
                    i = true;
                }
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (this.gameObject.tag == "P1btn")
        {
            if (collision.gameObject.tag == "P1")
            {
                i = false;
            }
        }
        if (this.gameObject.tag == "P2btn")
        {
            if (collision.gameObject.tag == "P2")
            {
                j = false;
            }
        }
    }
}
