using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    //��ư�� ������ �ش� ���� ������ �ڵ�(������ ���� ���ȸ�)
    public GameObject Wall,btn1,btn2;
    public bool CHeak_button = false;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (CHeak_button == false)
        {
            btn1.gameObject.GetComponent<Button2>().CHeak_button = true;
            btn2.gameObject.GetComponent<Button2>().CHeak_button = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (CHeak_button == true)
        {
            btn1.gameObject.GetComponent<Button2>().CHeak_button = false;
            btn2.gameObject.GetComponent<Button2>().CHeak_button = false;
        }
    }
    private void Update()
    {
        if (CHeak_button == true)
        {
            Wall.SetActive(false);
        }
        else if (CHeak_button == false)
        {
            Wall.SetActive(true);
        }
    }
}
