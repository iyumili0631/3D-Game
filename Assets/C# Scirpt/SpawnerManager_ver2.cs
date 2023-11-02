using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public item[] cubes;
    public float StandardTime = 0;
    public int size;
    bool gener = true;

    public item[] CubesName;
    public Vector3[] TargetPos;

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        if(gener)
        {
            gener = false;
            for (int i = 0; i < size; ++i)
            {
                int rand = Random.Range(0, cubes.Length);
                Instantiate(cubes[rand], TargetPos[i], Quaternion.identity);
            }
        }
    }

    public void Regene()
    {
        gener = true;
        //Destroy(GameObject.FindGameObjectWithTag("cubes"));
    }
}
