using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{

    public Text pointsText;
    public int points;

    void Start()
    {
        pointsText.text = "Спасенные игрушки: 0";
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Спасенные игрушки: " + points;        
    }
}
