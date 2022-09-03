using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 100.0f;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

}
