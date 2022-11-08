using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{

    public int clickCounter; //Stores the number given for the user
    [SerializeField] private int randNum;

    // Start is called before the first frame update
    void Start()
    {
        //Initiate clickCounter to 0 and toCheck to false
        clickCounter = 0;
        //Get random number
        randNum = UnityEngine.Random.Range(1,11);
    }

    // Update is called once per frame
    void Update()
    {
        //If pressed add 1 to clickCounter
        if (Input.GetMouseButtonDown(0)) {
            IncreaseScale();
        }
        //If Return pressed
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (HaveIWon()){ 
                Debug.Log($"You gained {clickCounter * 1000} points");
            }
        
        }
    }

    private bool HaveIWon() {
        if (clickCounter == randNum)
        {
            Debug.Log($"Congratulations you win");
            return true;
        }
        else if (clickCounter < randNum)
        {
            Debug.Log($"You were close, you needed {randNum - clickCounter} click more");
        }
        else
        {
            Debug.Log($"YOU LOSE. The Random number was {randNum}");
            transform.localScale = Vector3.zero;
        }

        return false;
    }

    private void IncreaseScale() {
        clickCounter++; //Increase
        transform.localScale += Vector3.one;
    }
}
