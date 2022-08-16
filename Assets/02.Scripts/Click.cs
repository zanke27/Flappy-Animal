using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject player = null;

    private Rigidbody2D rb2D = null;

    public float jumpPower = 10f;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rb2D.velocity.y >= 0)
            {
                rb2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            }
            else
            {
                rb2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }     
        }
    }
}
