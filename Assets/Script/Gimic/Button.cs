using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //��ư�� ������ �ش� ���� ������ �ڵ�(������ ���� ���ȸ�)
    public GameObject Wall;
    bool CHeak_button;
    private void OnCollisionStay2D(Collision2D collision)
    {
        CHeak_button = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        CHeak_button = false;
    }
    private void Update()
    {
        if(CHeak_button == true)
        {
            Wall.SetActive(false);
        }
        else if(CHeak_button == false)
        {
            Wall.SetActive(true);
        }
    }
}
