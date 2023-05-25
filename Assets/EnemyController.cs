using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject Char;

    void Start()
    {
        this.Char = GameObject.Find("MyChar_0");
    }

    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.Char.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d<r1+r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().Decreacetime();
            Destroy(gameObject) ;
        }
    }
}
