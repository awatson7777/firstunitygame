using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlat : MonoBehaviour {



public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == null)
        {
            Debug.DrawRay(groundDetection.position, Vector2.down * distance, Color.red); //drawRay is a clever way of testing as it shows the lines that are doing the detecting for the colliders around them.
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0); // this causes the enemies to travel back and forth on the platform as long as the groundDetection detects a collider.
                movingRight = true; 
            }
        }
        else
        {
            Debug.DrawRay(groundDetection.position, Vector2.down * distance, Color.green);
        }
    }
}
