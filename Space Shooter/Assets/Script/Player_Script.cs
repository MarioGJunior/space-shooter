using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    private Rigidbody2D rb;
    private float width;
    private float height;

    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontalMove, verticalMove) * speed;

        Edges();
    }

    private void Edges()
    {
        if (transform.position.x < -width)
        {
            transform.position = new Vector2(width, transform.position.y);
        }
        else if (transform.position.x > width)
        {
            transform.position = new Vector2(-width, transform.position.y);
        }

        if (transform.position.y > 0)
        {
            transform.position = new Vector2(transform.position.x, 0);
        }
        else if (transform.position.y < -4)
        {
            transform.position = new Vector2(transform.position.x, -4);
        }
    }

}
