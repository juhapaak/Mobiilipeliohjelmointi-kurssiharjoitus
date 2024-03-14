using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace harjoitus
{
    public class CoinScore : MonoBehaviour
    {
        [SerializeField] private int scoreAmount;
         private GameObject _gameManObj;
         private GameManager _gameManager;

        private void Start()
        {
         //   
        }

        public int Score
        {
            get { return scoreAmount; }
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _gameManObj = GameObject.Find("GameManObj");
                _gameManager = _gameManObj.GetComponent<GameManager>();
                _gameManager.AddScore(Score);
                Destroy(gameObject);
            }
            
        }
    }
}
 
 
