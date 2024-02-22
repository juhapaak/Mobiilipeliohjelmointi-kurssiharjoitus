using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace harjoitus
{


    public class MoveRigidBody : MonoBehaviour
    {
        private Rigidbody2D sawRigidbody;
        [SerializeField] private Transform target;
        [SerializeField] public float speed = 1f;

        private void Awake()
        {
            sawRigidbody = GetComponent<Rigidbody2D>();
        }


        void FixedUpdate()
        {
            //Laskee suunnan
            Vector2 direction = ((Vector2)target.position - sawRigidbody.position).normalized;

            // Uusi sijainti nopeuden ja suunnan perusteella
            Vector2 newPosition = sawRigidbody.position + direction * speed * Time.fixedDeltaTime;

            // Liikuttaa olentoa
            sawRigidbody.MovePosition(newPosition);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Target"))
            {
                Destroy(gameObject);
            }
        }
    }
}