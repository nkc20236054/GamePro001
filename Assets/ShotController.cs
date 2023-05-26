using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
     void Update()
    {
        transform.position += new Vector3(2f*Time.deltaTime, 0, 0);
    }
}
