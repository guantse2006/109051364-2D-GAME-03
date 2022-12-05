using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
}
