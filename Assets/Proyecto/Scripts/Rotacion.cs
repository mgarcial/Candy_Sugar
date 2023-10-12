using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float cambioPorSeg = 0.3f;

    Transform tf;

    void Start()
    {
        tf = this.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        tf.Rotate(0,0,cambioPorSeg); 
    }
}
