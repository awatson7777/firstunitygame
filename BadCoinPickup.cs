using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCoinPickup : MonoBehaviour {

    public int pointsToRemove;

    //public AudioSource BadCoin;


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMove>() == null)
        return;

        Score.RemovePoints(pointsToRemove); // removes points once the bad coin is picked
        //BadCoin.Play();
        Destroy(gameObject); //  makes the coin disappear.
    }

}
