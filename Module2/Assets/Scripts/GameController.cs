using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int mushroomCountTotal = 3;
    public int snailCountTotal = 1;
    public int onionCountTotal = 1;
    private int mushroomCount = 0;
    private int snailCount = 0;
    private int onionCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Mushroom") && mushroomCount != mushroomCountTotal)
        {
            mushroomCount--;
        }
        else if(other.gameObject.CompareTag("Snail"))
        {
            snailCount--;
        }
        else if(other.gameObject.CompareTag("Onion") && onionCount != onionCountTotal)
        {
            onionCount--;
        }

        HasWon();
    }

    
}
