using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] ghosts;
    public Vector3 start;
    public Vector3 startAngel;
    public bool ghostIsAlive = false;
    public bool angelIsAlive = false;

    void spawnGhost()
    {
        start.y = Random.Range(-12, -8);
        int next_enemy = Random.Range(0, 3);  
        Instantiate(ghosts[next_enemy], start, Quaternion.identity);
        ghostIsAlive = true;
    }

    void spawnAngel()
    {
        startAngel.y = Random.Range(-18, -12);
        startAngel.x = Random.Range(-19, 19);
        startAngel.z = -4;
        Instantiate(ghosts[3], startAngel, Quaternion.identity);
        angelIsAlive = true;
    }

    void Update()
    {
        if (!ghostIsAlive)
        {
            spawnGhost();
        }
        if(!angelIsAlive && GameObject.Find("PointsCanvas").GetComponent<PointsManager>().points >= 20)
        {
            spawnAngel();
        }
    }
}
