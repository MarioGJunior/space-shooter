using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    private Rigidbody2D rb;
    private float width;
    private float height;
    private AudioSource sound;

    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private GameObject shot;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        height = Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontalMove, verticalMove) * speed;

        Edges();

        Shoot();

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

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sound.Play();
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    }

}
