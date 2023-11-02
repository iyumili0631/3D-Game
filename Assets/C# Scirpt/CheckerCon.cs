using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerCon : MonoBehaviour
{
    private int size = 4;
    int stage = 0;
    bool Finish = false;
    // Start is called before the first frame update
    public Vector3 InitPos;
    bool Kill = false;
    public ScoreTextController scoreTextController;

    void Update()
    {
    // player finish the game
        if (stage == size)                                  
        {
            Finish = true;
            AddScore();
            GameObject.Find("SpawnerManager").GetComponent<SpawnerManager>().Regene();
            Finish = false;
            this.transform.position = InitPos;
            stage = 0;
            Kill = false;
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "cubes")
        {
            other.GetComponent<item>().SetOn();
        }
        if (Kill == true)
        {
            Destroy(other.gameObject);
            this.transform.Translate(2.0f, 0f, 0f);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "cubes")
        {
            stage++;
        }
    }

    public void AddScore()
    {
        if (Finish)
        {
            scoreTextController.AddScoreAndDisplay();
        }
        
    }

    public void Kill_All()
    {
        this.transform.Translate(2.0f, 0f, 0f);
        Kill = true;
        scoreTextController.DeductScoreAndDisplay();
    }
}
