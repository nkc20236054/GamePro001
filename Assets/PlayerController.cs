using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    Vector3 pos;
    Animator animator;
    void Start()
    {
        Application.targetFrameRate = 60;
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        float InputX = UnityEngine.Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(InputX * 0.3f, 0);
        float InputY = UnityEngine.Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, InputY*0.3f);
        if (InputY > 0.01f)
        { this.animator.SetTrigger("LeftTrigger"); }
        else if (InputY< -0.01f) 
        { this.animator.SetTrigger("RightTrigger"); }
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
