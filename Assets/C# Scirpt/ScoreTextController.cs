using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System.Threading;

public class ScoreTextController : MonoBehaviour
{
    public int currScore = 0;
    public Text text_; 
    public int targetScore = 300; 
    public bool isTarget;

    public CryingDogCon anim ;

    void Start()
    {
        //currScore = GameObject.Find("Checker").GetComponent<CheckerCon>().Score;
        text_ = this.GetComponent<Text>();
        isTarget = false;
        text_.text = "SCORE: " + currScore.ToString();
    }

    void Update()
    {
        if (currScore >= targetScore)  // 從他那邊取用他的分數 來和targetScore判斷 如果過就換下一個scene
        { 
            
            isTarget = true;
            // anim.blastAnimation(isTarget);
            Thread.Sleep(2000);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//換下一個scene
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(currScore);
        }
    }

    public void AddScoreAndDisplay()
    {
        currScore += 100;// 加分的機制世豪那邊應該有 所以這行可以不用
        text_.text = "SCORE: " + currScore.ToString(); //但顯示分數世豪沒做 所以這個function還是要留
    }

    public void DeductScoreAndDisplay()
    {
        currScore -= 100;
        text_.text = "SCORE: " + currScore.ToString(); 
    }

   //世豪那邊有的是加分機制 但他並沒做顯示出來的文字 所以只要把他的分數抓到這邊用就好了
}

