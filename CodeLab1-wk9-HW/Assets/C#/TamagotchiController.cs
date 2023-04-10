using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TamagotchiController : MonoBehaviour
{
    //feed
    //play
    //ignore
    public enum State {HAPPY, HUNGRY, BORED, SAD}
    public Text display;

    private int hungry = 0;
    private int bored = 0;

    // Start is called before the first frame update
    void Start()
    {
        //initialize the state
        State state = State.HAPPY;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
}
