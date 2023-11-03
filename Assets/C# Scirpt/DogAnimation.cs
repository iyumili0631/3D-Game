using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class DogAnimation : MonoBehaviour
{
    public bool holdingDown;
    public Animator animator;
    public AnimatorStateInfo info;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey){
            animator.SetInteger("state",1);
            holdingDown = true;
        }
        else if (!Input.anyKeyDown && holdingDown){
            animator.SetInteger("state",0);
            holdingDown = false;
        }
        
    }
}
