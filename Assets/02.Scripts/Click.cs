using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject player = null;

    private Rigidbody2D rb2D = null;

    [SerializeField] private float jumpPower = 7.5f;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * jumpPower;
            if (rb2D.velocity.y >= 0)
            {
                rb2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }
            else
            {
                rb2D.velocity = Vector2.up * jumpPower;
                //rb2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            }
            if (rb2D.velocity.y > 10)
                rb2D.velocity = new Vector2(rb2D.velocity.x, 10);
        }
    }
}
