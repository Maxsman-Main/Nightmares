using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSoul : MonoBehaviour
{
    public float speed;
    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    public int damage;
    public int fear;
    public GameObject sprite;
    public bool flag = false;
    float timer = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health -= damage;
        GameObject.Find("Player").gameObject.GetComponent<PlayerState>().dread += fear;
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(gameObject.transform.position.x, 0);
        if (gameObject.transform.position.x < 0)
        {
            moveVelocity = moveInput.normalized * speed * -1;
        }
        timer += Time.deltaTime;
        if(timer > 3f)
        {
            sprite.transform.position = new Vector3(sprite.transform.position.x, Random.Range(-18, -12), transform.position.z);
            timer = 0;
        }
    }

    private void FixedUpdate()
    {
        if (gameObject.transform.position.x > 18)
        {
            sprite.transform.localScale = new Vector3(sprite.transform.localScale.x * -1f, sprite.transform.localScale.y, sprite.transform.localScale.z);
            flag = true;
        }
        else if(gameObject.transform.position.x < -19) 
        {
            sprite.transform.localScale = new Vector3(sprite.transform.localScale.x * -1f, sprite.transform.localScale.y, sprite.transform.localScale.z);
            flag = false;
        }
        if (flag)
        {
            rb.MovePosition(rb.position - moveVelocity * Time.deltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
        }
    }
}
