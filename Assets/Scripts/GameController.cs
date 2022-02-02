using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int mushroomCountTotal = 3;
    public int snailCountTotal = 1;
    public int onionCountTotal = 1;
    private int mushroomCount = 0;
    private int snailCount = 0;
    private int onionCount = 0;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HasWon()
    {
        int itemsNeeded = mushroomCountTotal + onionCountTotal + snailCountTotal;
        int itemsHave = mushroomCount + onionCount + snailCount;
        if(itemsNeeded == itemsHave)
        {
            winText.SetActive(true);
            GameObject.Find("LinearHungerBar").GetComponent<HungerTimer>().enabled = false;
        }
    }

    private void hasUsed(Collider other) 
    {
        other.tag = "Used";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Mushroom") && mushroomCount != mushroomCountTotal)
        {
            mushroomCount++;
            hasUsed(other);
            Debug.Log("hit");
        }
        else if(other.gameObject.CompareTag("Snail") && snailCount != snailCountTotal)
        {
            snailCount++;
            hasUsed(other);
        }
        else if(other.gameObject.CompareTag("Onion") && onionCount != onionCountTotal)
        {
            onionCount++;
            hasUsed(other);
        }

        HasWon();
    }

    
}
