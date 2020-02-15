using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        score = 0; // score's intial value is '0'
    }

    void Update()
    {
        if (score < 0)
            score = 0; // score does not go under '0'

        text.text = "" + score; // adds what I change the 'score' int to.
    }

    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void RemovePoints(int pointsToRemove)
    {
        score -= pointsToRemove;
    }
}
