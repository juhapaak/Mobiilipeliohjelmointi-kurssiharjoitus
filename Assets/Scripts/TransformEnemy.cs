using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace harjoitus
{
	public class TransformEnemy : MonoBehaviour
	{
		private bool righty = true;
		public float speed = 2.0f;
		public float rightest = 1.0f;
		public float leftest = -2.0f;

		// Start is called before the first frame update
		void Start()
		{

		}

		void Update()
		{
			if (righty)
				transform.Translate(Vector2.right * speed * Time.deltaTime);
			else
				transform.Translate(-Vector2.right * speed * Time.deltaTime);

			if (transform.position.x >= rightest)
			{
				righty = false;
			}

			if (transform.position.x <= leftest)
			{
				righty = true;
			}
		}
	}
}