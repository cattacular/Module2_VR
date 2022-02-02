using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerTimer : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;
    void Start()
    {
       timesUpText.SetActive(false);
       timeLeft = maxTime;  
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0) 
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else 
        {
           timesUpText.SetActive(true);
           Time.timeScale = 0; 
        }
    }
}
