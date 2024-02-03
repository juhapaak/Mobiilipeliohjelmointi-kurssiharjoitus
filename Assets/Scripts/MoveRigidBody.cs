using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace harjoitus
{


    public class MoveRigidBody : MonoBehaviour
    {
        private Rigidbody2D sawRigidbody;
        public Transform targer;
        public float speed = 1f;

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

        }

        void FixedUpdate()
        {
            //Laskee suunnan
            Vector2 direction = ((Vector2)targer.position - sawRigidbody.position).normalized;

            // Uusi sijainti nopeuden ja suunnan perusteella
            Vector2 newPosition = sawRigidbody.position + direction * speed * Time.fixedDeltaTime;

            // Liikuttaa olentoa
            sawRigidbody.MovePosition(newPosition);
        }
    }
}