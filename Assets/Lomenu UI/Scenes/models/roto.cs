using UnityEngine;
using System.Collections;

public class roto : MonoBehaviour
{
    public float speed = 20f;


    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
