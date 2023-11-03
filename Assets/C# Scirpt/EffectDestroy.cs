using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroy : MonoBehaviour
{
    public float destroyTimeDelay = 0.5f;

    // Update is called once per frame
    void Start()
    {
        Destroy(this.gameObject, destroyTimeDelay);
    }
}
