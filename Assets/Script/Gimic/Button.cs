using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //버튼을 누르면 해당 문이 열리는 코드(누르고 있을 동안만)
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
