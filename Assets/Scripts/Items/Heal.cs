using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public int heal_point;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health <= 94)
        {
            GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health += heal_point;
        }
        else
        {
            GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health += 100 - GameObject.Find("Player").gameObject.GetComponent<PlayerState>().health;
        }
        GameObject.Destroy(gameObject);
        GameObject.Find("HCreater").gameObject.GetComponent<CreaterHP>().is_active = false;
    }
}
