using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus : MonoBehaviour
{
    public float speed = 1f;
    
    private void Start()
    {
        

    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
       
    }
}
