using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{

    private Rigidbody2D rb;
    private AudioSource sound;

    [SerializeField]
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize - 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Laser")
        {
            sound.Play();
            Score_Script.ScoreUpdate(5);
        }

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(Explosion());
        Destroy(collider.gameObject);
        
    }

    public IEnumerator Explosion()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}
