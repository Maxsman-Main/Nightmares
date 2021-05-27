using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostRed : MonoBehaviour
{
    public float speed;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    public int damage;
    public int fear;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health -= damage;
        GameObject.Find("Player").gameObject.GetComponent<PlayerState>().dread += fear;
        Destroy(gameObject);
        GameObject.Find("EnemySpawner").gameObject.GetComponent<Spawner>().ghostIsAlive = false;
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(gameObject.transform.position.x, 0);
        if (gameObject.transform.position.x < 0)
        {
            moveVelocity = moveInput.normalized * speed * -1;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
        if (gameObject.transform.position.x > 37)
        {
            Destroy(gameObject);
            GameObject.Find("EnemySpawner").gameObject.GetComponent<Spawner>().ghostIsAlive = false;
        }
    }
}
