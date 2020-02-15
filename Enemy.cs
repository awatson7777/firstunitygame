using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;

    AudioSource mDeath;

    public GameObject deathEffect;

    /*void Start()
    {
        mDeath = GetComponents<AudioSource>()[1];
        mDeath.playOnAwake = false;
    }*/

    public void TakeDamage(int damage)
    {
        health -= damage; // takes away damage once bullets hits the collider

        if (health <= 0)
        {
            Die();
            //mDeath.Play();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject); // makes the gameObject disappear by replacing it with the death image selected

    }

}