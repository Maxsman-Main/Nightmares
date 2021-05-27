using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlaceOut : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.Find("Player").gameObject.GetComponent<PlayerState>().isHaveItem)
        {
            GameObject.Find("PlayerSprite").GetComponent<Animator>().SetBool("isGetItem", false);
            GameObject.Find("PlayerSprite").GetComponent<Animator>().SetBool("isPutToy", true);
            GameObject.Find("Player").gameObject.GetComponent<PlayerState>().isHaveItem = false;
            GameObject.Find("PointsCanvas").gameObject.GetComponentInChildren<PointsManager>().points += 1;
        }  
    }
}
