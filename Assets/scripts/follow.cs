using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    float speedX = 5f;
   
    void Update()
    {
            // Set the camera's position 
            transform.position += new Vector3(speedX,0,0) * Time.deltaTime;
        
    }
}
