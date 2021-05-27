using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angel : MonoBehaviour
{
    public bool isActive = false;
    private float timer = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isActive = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Player").GetComponent<PlayerState>().health -= 15;
        GameObject.Find("Player").GetComponent<PlayerState>().dread += 10;
        GameObject.Find("EnemySpawner").GetComponent<Spawner>().angelIsAlive = false;
        Destroy(gameObject);
    }

    private void Update()
    {
        if (isActive)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if(timer >= 0.8f)
            {
                timer = 0;
                GameObject.Find("Player").GetComponent<PlayerState>().health -= 1;
            }
            gameObject.GetComponent<Animator>().Play("AngelAttack");
        }
        else
        {
            timer = 0;
            gameObject.GetComponent<Animator>().Play("AngelFly");
        }

    }
}
