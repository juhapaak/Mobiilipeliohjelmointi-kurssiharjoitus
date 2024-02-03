using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace harjoitus
{

    public class HelloWorld : MonoBehaviour
    {
        private int number;
        private int secondNumber;
        private int result;

        void Start()
        {
            Debug.Log("Hello World!");


            number = 1;
            secondNumber = 0;
            Debug.Log(secondNumber);
            Debug.Log(number);
        }

        // Update is called once per frame
        void Update()
        {
            if (result <= 1000)
            {
                result = number + secondNumber;
                secondNumber = number;
                number = result;
                if (result < 1000)
                {
                    Debug.Log(result);
                }
            }
        }
    }
}