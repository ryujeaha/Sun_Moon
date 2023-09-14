using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int i;
    public bool q, w;
    public void BtnCliack1(int s)//�Ű������� �־��ָ� �ν����� â���� ���ڸ� �ټ� �ִ�.
    {
        SceneManager.LoadScene("Loading");
        i = s;
        SceneMove();
    }

    void SceneMove()
    {
        if (i == 0)
        {
            LoadingSceneController.LoadScene("Main");
        }

        if (i == 1)
        {
            LoadingSceneController.LoadScene("Stage1");
        }
        else if (i == 2)
        {
            LoadingSceneController.LoadScene("Stage2");
        }
        else if (i == 3)
        {
            LoadingSceneController.LoadScene("Stage3");
        }
    }
    void Stage_end()
    {
        i = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "P1")
        {
            q = true;
        }
        if (collision.gameObject.tag == "P2")
        {
            w = true;
        }
    }
    private void Update()
    {
        if( q == true && w == true)
        {
            SceneManager.LoadScene("Loading");
            Stage_end();
            SceneMove();
        }
    }

}
