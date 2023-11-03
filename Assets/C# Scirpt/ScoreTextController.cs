using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System.Threading;
using System.Threading.Tasks;

public class ScoreTextController : MonoBehaviour
{
    public int currScore = 0;
    public Text text_; 
    public int targetScore = 300; 
    public bool isTarget;

    public CryingDogCon anim ;
    //private Animator animator;

    void Start()
    {
        //currScore = GameObject.Find("Checker").GetComponent<CheckerCon>().Score;
        text_ = this.GetComponent<Text>();
        isTarget = false;
        text_.text =  currScore.ToString();
    }

    void Update()
    {
        if (currScore >= targetScore)  // 從他那邊取用他的分數 來和targetScore判斷 如果過就換下一個scene
        { 

            anim.blastAnimation();
            isTarget = true;
            //Thread.Sleep(2000);
            if(anim.animator.GetCurrentAnimatorStateInfo(0).IsName("Blast")){
                Invoke("nextScene",0.5f);
            }
        }


       // if (isTarget){
       //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//換下一個scene
      //  }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(currScore);
        }
    }

    public void AddScoreAndDisplay()
    {
        currScore += 100;// 加分的機制世豪那邊應該有 所以這行可以不用
        text_.text = currScore.ToString(); //但顯示分數世豪沒做 所以這個function還是要留
    }

    public void DeductScoreAndDisplay()
    {
        currScore -= 100;
        //text_.text =  currScore.ToString(); 
    }

    public void nextScene(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//換下一個scene
    }

   //世豪那邊有的是加分機制 但他並沒做顯示出來的文字 所以只要把他的分數抓到這邊用就好了

//    async System.Threading.Tasks.Task Delay (int iSecond){
//         await System.Threading.Tasks.Task.Delay (iSecond);
//    }
}


