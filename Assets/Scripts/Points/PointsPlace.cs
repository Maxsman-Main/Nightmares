using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPlace : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!GameObject.Find("Player").gameObject.GetComponent<PlayerState>().isHaveItem)
        {
            GameObject.Find("PlayerSprite").GetComponent<Animator>().SetBool("isGetItem", true);
            GameObject.Find("PlayerSprite").GetComponent<Animator>().SetBool("isPutToy", false);
            GameObject.Find("Player").gameObject.GetComponent<PlayerState>().isHaveItem = true; 
        }
    }
}
