using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 pos;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x * 0.3f, 0, 0);
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, y*0.3f, 0);
        pos = transform.position;
        if (pos.x <= -9)
        {
            pos.x = -9;
            transform.position = pos;
        }
        if (pos.x >= 9)
        {
            pos.x = 9;
            transform.position = pos;
        }
        if (pos.y <= -5)
        {
            pos.y = -5;
            transform.position = pos;
        }
        if (pos.y >= 5)
        {
            pos.y = 5;
            transform.position = pos;
        }
    }
}
