using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryingDogCon : MonoBehaviour
{
    private Animator animator;
    public ScoreTextController score;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(score.isTarget){

            blastAnimation();
        }
    }

    public void blastAnimation(){
        animator.SetInteger("state", 1);
              
    }
}
