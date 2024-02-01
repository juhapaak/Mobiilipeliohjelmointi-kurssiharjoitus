using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBody : MonoBehaviour
{
    private Rigidbody2D sawRigidbody;
    private bool righty = true;
    public float speed = 2.0f;
    public float rightest = 1.0f;
    public float leftest = -2.0f;

    private void Awake()
    {
        sawRigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(righty)

            transform.Translate(sawRigidbody.position * Vector2.right * speed * Time.deltaTime);

        else
            transform.Translate(sawRigidbody.position * - Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= rightest)
        {
            righty = false;
        }

        if (transform.position.x <= leftest)
        {
            righty = true;
        }
    }

    void FixedUpdate()
    {

    }
}
