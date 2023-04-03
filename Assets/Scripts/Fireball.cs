using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector2 startingVelocity;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy= collision.collider.GetComponent<Enemy>();
        enemy.Die();
        gm.ScoreUp();
        Destroy(gameObject);
    }
}
