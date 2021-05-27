using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    public int health;
    public int dread;
    public Text state;
    public bool isHaveItem;
    public int oldDread;


    private void Start()
    {
        state.text = "Здоровье: " + health + "\n" + "Ужас: " + dread;
        oldDread = dread;
    }

    private void Update()
    {
        float lighRange = ((float)(150 - dread)) / 10;
        if(lighRange > 15)
        {
            GameObject.Find("Player/PlayerSeeLight").GetComponent<Light>().range = 15;
        }
        else if(lighRange < 5)
        {
            GameObject.Find("Player/PlayerSeeLight").GetComponent<Light>().range = 6;
        }
        else
        {
            GameObject.Find("Player/PlayerSeeLight").GetComponent<Light>().range = lighRange;
        }
        state.text = "Здоровье: " + health + "\n" + "Ужас: " + dread;
        if(health <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
