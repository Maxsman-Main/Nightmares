using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    private float timer = 0;
    private bool flag = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        flag = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        flag = false;
    }

    private void Update()
    {
        if (flag)
        {
            timer += Time.deltaTime;
            if (timer >= 0.8f)
            {
                timer = 0;
                if (GameObject.Find("Player").GetComponent<PlayerState>().dread > 0)
                {
                    GameObject.Find("Player").GetComponent<PlayerState>().dread -= 1;
                }
            }
        }
    }
}
