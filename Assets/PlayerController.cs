using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(0 ,2 ,0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(0, -2, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate( -2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate( 2, 0, 0);
        }
    }
}
