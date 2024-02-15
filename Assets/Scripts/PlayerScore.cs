using UnityEngine;



namespace Mobiiliesimerkki

{

    public class PlayerScore : MonoBehaviour

    {
        private int _score;

        public int Score

        {
            get { return _score; }
            set
            {
                if (value < 0)
                {
                    _score = 0;
                }
                else
                {
                    _score = value;
                }
            }
        }

        public void IncreaseScore(int increment)
        {
            Score += increment;
        }

        private void Start()
        {
            // Initialize score
            Score = 0;
        }



        private void FixedUpdate()

        {
            // Increase score every second
            if (Time.time % 1 == 0)
            {
                IncreaseScore(1);
                Debug.Log(Score);
            }
        }
    }
}