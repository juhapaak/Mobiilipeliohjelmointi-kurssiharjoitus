using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace harjoitus
{
    public class GameManager : MonoBehaviour
    {
        private int _totalScore;

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        public void AddScore(int amount)
        {
            _totalScore = _totalScore + amount;
        }

        public int ShowScore
        {
            get { return _totalScore; }
        }
        
    }
}
