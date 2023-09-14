using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GiMicScript_3 : MonoBehaviour
{
    public GameObject Wall, Wall2;
   public bool Cheak_Lever = false;
    public bool Defailt = true;
    public Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Cheak_Lever == false)
        {
            if (collision.gameObject.tag == "P1" || collision.gameObject.tag == "P2")
            {
                Cheak_Lever = true;
                anim.SetBool("Cheak_Lever", true);
                Wall.SetActive(false);
                Wall2.SetActive(true);
            }
        }
        else if (Cheak_Lever == true)
        {
            if (collision.gameObject.tag == "P1" || collision.gameObject.tag == "P2")
            {
                Cheak_Lever = false;
                anim.SetBool("Cheak_Lever", false);
                Wall.SetActive(true);
                Wall2.SetActive(false);
            }
        }
    }

}
