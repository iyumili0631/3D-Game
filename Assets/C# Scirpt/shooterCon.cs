using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterCon : MonoBehaviour
{
    public GameObject[] bullet;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(bullet[0], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bullet[0], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(bullet[0], transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(bullet[0], transform.position, Quaternion.identity);

        }
    }
}
