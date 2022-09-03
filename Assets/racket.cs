using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    public int speed;
    public float hitFactor(Vector2 ballpos, Vector2 racketpos,
        float racketWidth)
    {
        return (ballpos.x - racketpos.x) / racketWidth;

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
