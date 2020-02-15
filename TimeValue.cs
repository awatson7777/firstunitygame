using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Text is included specifically in the UI library.

public class TimeValue : MonoBehaviour {

    public float startingTime;

    private Text theText;

    public GameObject gameOverScreen; 

    public PlayerMove player;

    void Start()
    {
        theText = GetComponent<Text>();

        player = FindObjectOfType<PlayerMove>();
    }

    void Update()
    {

        startingTime -= Time.deltaTime;

        if (startingTime <= 0)
        {
            gameOverScreen.SetActive(true); // displays the gameOverScreen 
            player.gameObject.SetActive(false); // stops the player from being able to control 'good guy'
        }

        theText.text = "" + Mathf.Round (startingTime); // Mathf.Round rounds up the timer digit to the nearest whole number

    }
}
