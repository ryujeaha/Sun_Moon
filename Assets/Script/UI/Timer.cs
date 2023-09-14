using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    [SerializeField] float SetTime = 180.0f;
    [SerializeField] Text countDownText;
    void Start()
    {
        countDownText.text = SetTime.ToString();
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(SetTime > 0)
        {
            SetTime -= Time.deltaTime;//실제시간을 빼줍니다 1초가 지날때마다 1초씩.
        }
        else if(SetTime <= 0)
        {
            GameObject Ui = GameObject.Find("Death");
            Ui.GetComponent<Death>().Death_Player();
        }
        countDownText.text = Mathf.Round(SetTime).ToString();
    }
}
