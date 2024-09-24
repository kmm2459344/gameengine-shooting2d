using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TateScroll : MonoBehaviour
{
    private float speed = 6;

    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * speed);

        if (transform.position.y <= -12.8)
        {
            transform.position = new Vector3(0, 25.5f);
        }
    }
}