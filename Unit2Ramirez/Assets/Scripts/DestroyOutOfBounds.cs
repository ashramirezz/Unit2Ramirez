using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = 10;
    

    // Update is called once per frame
    void Update()
    {
        //Destroys gamme objects when out of bounds of the plane/camera
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

        //Dsiplayes "Game Over" on the screen when game ends or player loses
        Debug.Log("Game Over!");
        Destroy(gameObject);
    }
}
