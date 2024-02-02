using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBody : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Vector2 velocity;


    private void Awake()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(1.75f, 1.1f);
    }


    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
    }
}
