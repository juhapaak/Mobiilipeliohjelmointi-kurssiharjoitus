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
        // Jump
        [SerializeField] private float thrust = 4.0f;

        private bool _canJump;
        //Speed
        [SerializeField] private float _speed = 1.0f;
		
		// Jump gravity
		[SerializeField] private float _gravityScale; // GravityScale 
		[SerializeField] private float _fallingGravityScale; // GravityScale kun tippuu alaspäi
        // Input reader
        private InputReader _inputReader = null;
        
        // collision tsekkausta varten collider
        [SerializeField] private Collider2D _groundCheckColl;

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
            targetRigidbody2D.velocity = new Vector2(targetRigidbody2D.velocity.x, thrust);
            Debug.Log("JUmp");
        }

        private void Update()
        {
            // Gravity 
            if(targetRigidbody2D.velocity.y >= 0)
            {
                targetRigidbody2D.gravityScale = _gravityScale;
            }
            else if (targetRigidbody2D.velocity.y < 0)
            {
                targetRigidbody2D.gravityScale = _fallingGravityScale;
            }
            
            // Lukee inputreaderista syötteen.
            Vector2 movement = _inputReader.Movement;
            // Syöte annetaan Move metodille.
            Move(movement); // siirrä fixed updateen

            // Hyppääminen
            bool isJumping = _inputReader.Jump;
            //Jump(isJumping);
            if (isJumping && _canJump)
            {
                Jump();
                _canJump = false;
            }

        } 
        
        private void OnCollisionEnter2D(Collision2D collision) 
        { 
            if (collision.gameObject.CompareTag("Ground")) 
            { 
                Debug.Log("Collaa");
                _canJump = true;
            } 
        } 
        
    }
}
