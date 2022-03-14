using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime;
    }
}
