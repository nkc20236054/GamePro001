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
        float InputY = UnityEngine.Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(InputY * 0.1f, 0);
        float InputX = UnityEngine.Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0, InputX*0.1f);
        if (InputX == 0)
        { animator.Play("MyChar"); }
        else if (InputX == 1)
        { animator.Play("Left"); }
        else if (InputX == -1)
        { animator.Play("Right"); }
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
