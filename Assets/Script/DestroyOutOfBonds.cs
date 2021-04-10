using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBonds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerbound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerbound)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
        
    }
}
