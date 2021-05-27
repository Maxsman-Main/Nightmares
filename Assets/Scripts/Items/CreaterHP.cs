using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterHP : MonoBehaviour
{
    [SerializeField] GameObject hp;
    [SerializeField] Vector3 spawn_point;
    public bool is_active;

    void spawnHeal()
    {
        spawn_point.x = Random.Range(-24, 9);
        spawn_point.y = Random.Range(-10, -13);
        Instantiate(hp, spawn_point, Quaternion.identity);
        is_active = true;
    }

    private void Update()
    {
        if (!is_active)
        {
            spawnHeal();
        }
    }
}
