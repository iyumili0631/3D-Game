using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;


public class CryingDogCon : MonoBehaviour
{
    public Animator animator;
    public ScoreTextController score;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(score.isTarget){
        //     blastAnimation();
        // }

    }

    public void blastAnimation(){
        animator.SetBool("isTarget", true);
        //Debug.Log(animator.GetBool("isTarget"));
        //Thread.Sleep(2000);
    }
}
