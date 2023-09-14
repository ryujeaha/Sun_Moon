using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject Option_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public  void OptionClick()
    {
        Time.timeScale = 0.001f;
        Option_UI.SetActive(true);
        
    }

   public void OptionExitClick()
    {
        Time.timeScale = 1f;
        Option_UI.SetActive(false);
    }

    public void Quit_Click()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); 
#endif
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
