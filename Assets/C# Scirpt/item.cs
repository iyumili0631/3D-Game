using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public string Name;
    bool match = false;
    bool Allow_To_Getkey = false;
    public GameObject effect;
    private GameObject checkpoint;
    // Update is called once per frame
    void Update()
    {
        if (Allow_To_Getkey == true)
        {
            if (Name == "W" && Input.GetKeyDown(KeyCode.W))
            {
                Match();
            }
            else if (Name == "S" && Input.GetKeyDown(KeyCode.S))
            {
                Match();
            }
            else if (Name == "A" && Input.GetKeyDown(KeyCode.A))
            {
                Match();
            }
            else if (Name == "D" && Input.GetKeyDown(KeyCode.D))
            { 
                Match();
            }
            else if(Input.anyKeyDown && !match)
            {
                Wrong();
            }
        }
    }

    void Match()
    {
        match = true;
        checkpoint = GameObject.Find("Checker");
        Allow_To_Getkey = false;
        checkpoint.transform.Translate(2.0f, 0f, 0f);
        Destroy(gameObject);
//        Instantiate(effect, transform.position, Quaternion.identity);
    }

    public bool ReturnMatch()
    {
        return match;
    }

    public void SetOn()
    {
        Allow_To_Getkey = true;
    }

    public bool ReturnKey()
    {
        return Allow_To_Getkey;
    }

    void Wrong()
    {
        GameObject.Find("Checker").GetComponent<CheckerCon>().Kill_All();
        Destroy(this.gameObject);
    }
}
