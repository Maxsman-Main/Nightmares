using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    private Canvas note;

    // Start is called before the first frame update
    void Start()
    {
        note = gameObject.GetComponent<Canvas>();
        note.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            note.enabled = !note.enabled;
        }
    }
}
