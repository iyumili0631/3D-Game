using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCon : MonoBehaviour
{
    public float speed = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (transform.position.x > 5)
            Destroy(gameObject);
    }
}
