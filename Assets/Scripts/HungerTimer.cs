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
    public AudioSource hunger;
    public AudioClip hungerGrowl;
    private int growlAmount = 0;
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
            if(timeLeft < maxTime*0.75 && growlAmount == 0)
            {
                hunger.PlayOneShot(hungerGrowl);
                growlAmount++;
            }
            else if(timeLeft < maxTime*0.5 && growlAmount == 1)
            {
                hunger.PlayOneShot(hungerGrowl);
                growlAmount++;
            }
            else if(timeLeft < maxTime*0.25 && growlAmount == 2)
            {
                hunger.PlayOneShot(hungerGrowl);
                growlAmount++;
            }
        }
        else 
        {
           timesUpText.SetActive(true);
           Time.timeScale = 0; 
        }
    }
}
