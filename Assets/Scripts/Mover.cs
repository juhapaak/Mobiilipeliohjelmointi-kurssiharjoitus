using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace harjoitus
{
    public class Mover : MonoBehaviour
    {
	// PISTÄ Alaviiva todo
        private Rigidbody2D targetRigidbody2D;

        [SerializeField] private float _speed = 1.0f;

        private InputReader _inputReader = null;
        // Start is called before the first frame update

        private void Awake()
        {
            // Alustetaan komponentit olioiksi.
            _inputReader = GetComponent<InputReader>();
            targetRigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void Move(Vector2 direction)
        {
            // Rigidbodyn tämänhetkinen position.
            Vector2 position = targetRigidbody2D.position;
            // position = nykyinen position + uusi 2d vector * speed * deltatime.
            position += new Vector2(direction.x, 0) * _speed * Time.deltaTime;
            // Liikuttaa rigidbodyn positionin määräämään paikkaan.
            targetRigidbody2D.position = position;
        }

        public void Jump()
        {
            Debug.Log("Jumped!");
        }

        private void Update()
        {
            // Lukee inputreaderista syötteen.
            Vector2 movement = _inputReader.Movement;
            // Syöte annetaan Move metodille.
            Move(movement); // siirrä fixed updateen
            
            // Hyppääminen
            bool isJumping = _inputReader.Jump;
            //Jump(isJumping);
            if(isJumping)
            {
                Jump();
            }
        } 
    }
}
