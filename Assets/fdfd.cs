using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fdfd : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 10;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
		Movement();
		//lvc
	}

	void Movement()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.up * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 0);
		}

		if (Input.GetKey(KeyCode.Q))
		{
			transform.Translate(Vector2.up * 4f * Time.deltaTime);
			transform.eulerAngles = new Vector2(180, 0);
		}

	}
}
