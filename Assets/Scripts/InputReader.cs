using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

namespace harjoitus
{
    public class InputReader : MonoBehaviour
    {
        private Inputs _inputs;

        private Vector2 _movementInput;
        private bool _jumpInput;

        public Vector2 Movement
        {
            get { return _movementInput; }
        }

        public bool Jump
        {
            get { return _jumpInput; }
        }

        private void Awake()
        {
            _inputs = new Inputs();
        }

        private void OnEnable()
        {
            _inputs.Game.Enable();
        }

        private void OnDisable()
        {
            _inputs.Game.Disable();
        }

        // Update is called once per frame
        void Update()
        {
            _movementInput = _inputs.Game.Move.ReadValue<Vector2>();
            //_jumpInput = _inputs.Game.Jump.ReadValue<bool>();

            // Tarkastaa milloin Jump-nappia painetaan tai p‰‰stet‰‰n irti, muuttaa boolia sen mukaan
            _jumpInput = _inputs.Game.Jump.WasPressedThisFrame();
        }
    }
}
