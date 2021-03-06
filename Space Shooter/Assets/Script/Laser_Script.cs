using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Script : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField]
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
