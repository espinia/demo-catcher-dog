using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftBound = -20.0f;
    private float lowerBound = -2.0f;

    // Update is called once per frame
    void Update()
    {
		if (transform.position.x < leftBound)
		{
            Destroy(gameObject);
		}
        if (transform.position.y < lowerBound)
        {
            Debug.Log("GAME OVER ");
            Destroy(gameObject);            
            Time.timeScale = 0;
        }
    }
}
