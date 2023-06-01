using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0;
    float span = 1.0f;
    float delta = 0;

    public void SetParameter(float span)
    {
        this.span = span;
    }

        void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0);
            float px = Random.Range(5f, -5f);
            go.transform.position = new Vector2(10, px);
        }
    }
}
