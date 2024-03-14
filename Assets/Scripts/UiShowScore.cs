using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace harjoitus
{
    public class UiShowScore : MonoBehaviour
    {
        [SerializeField] private TMP_Text scoreIntTMP;
        private int _scoreInt;
        private GameObject _gameManObj;
        private GameManager _gameManager;
        
        // Start is called before the first frame update
        void Start()
        {
            _gameManObj = GameObject.Find("GameManObj");
            _gameManager = _gameManObj.GetComponent<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            _scoreInt = _gameManager.ShowScore;
            scoreIntTMP.SetText(_scoreInt.ToString());
        }
    }
}
