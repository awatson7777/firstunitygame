using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCoinPickup : MonoBehaviour {

    public int pointsToAdd;

    //AudioSource mGoodCoin;

   /* void Start()
    {
       mGoodCoin = GetComponents<AudioSource>()[1];
       mGoodCoin.playOnAwake = false;
    */

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMove>() == null) // once the colliders 'collide' with each other it calls the following:

            //mGoodCoin.Play();
        return;

        Score.AddPoints(pointsToAdd); // adds the points to the score value

        Destroy(gameObject); // makes the collided object disappear
    }

}
