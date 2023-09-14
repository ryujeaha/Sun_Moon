using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public GameObject uiGameOver;

    void Start()
    {
        uiGameOver.SetActive(false);
    }

    public void Death_Player()
    {
        StartCoroutine(DeathDelay());
    }
    IEnumerator DeathDelay()
    {
        Time.timeScale = 0;
        uiGameOver.SetActive(true);
        yield return new WaitForSeconds(0.5f);
    }

    public void RePlay1Button()
    {
        LoadingSceneController.LoadScene("Stage1");
    }

    public void RePlay2Button()
    {
        LoadingSceneController.LoadScene("Stage2");
    }
    public void RePlay3Button()
    {
        LoadingSceneController.LoadScene("Stage3");
    }

    public void MainMenuButton()
    {
        LoadingSceneController.LoadScene("Main");
    }

}
