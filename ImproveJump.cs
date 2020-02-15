using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImproveJump : MonoBehaviour {

    public float fallMultiplier = 2.5f;
    public float lowJumpMultipier = 2f;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime; // smoothens out the fall by making it quicker.
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultipier - 1) * Time.deltaTime; // smoothens out the jump by affecting the gravity the jumps have on the player by essentiall not allowing the player to float briefly once a jump is performed.
        }
    }
}