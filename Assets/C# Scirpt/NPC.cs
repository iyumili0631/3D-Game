using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;


public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialougePanel;
    public Text dialougeText;
    //public string[] dialouge;
    public TextAsset textFile;
    private int index;
    public GameObject contButton;
    public imageChanger changer;

    List<string> textList = new List<string>();

    public float wordSpeed;
    public bool isDialouge;
    public bool isDog;

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var lineData = file.text.Split('\n');
        foreach (var line in lineData)
        {
            textList.Add(line);
        }
    }

    void Awake()
    {
        GetTextFromFile(textFile);
        //zeroText();
        changer.UpdateImage();
        //dialougePanel.SetActive(true);
    }

    private void OnEnable()
    {
        /*dialougeText.text = textList[index];
        index++;*/
        isDialouge = false;
        isDog = true;   // 如果第一句話狗說的 這邊就設true 否則設false
        contButton.SetActive(false);
        StartCoroutine(Typing());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && index == textList.Count)
        {
            dialougePanel.SetActive(false);
            index = 0;
            return;
        }

        if (Input.GetKeyDown(KeyCode.W) && isDialouge == false)
        {
            //dialougeText.text = textList[index];
            //index++;
            StartCoroutine(Typing());

            /*if (dialougePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialougePanel.SetActive(true);
                StartCoroutine(Typing());
            }*/
        }
    }

    /*public void zeroText() {

        dialougeText.text = "";
        index = 0;
        dialougePanel.SetActive(false);
    }*/

    IEnumerator Typing()
    {
        isDialouge = true;
        dialougeText.text = "";

        switch (textList[index])
        {
            case "P":
                //show princess image
                isDog = false;
                index++;
                break;
            case "D":
                //show dog image
                isDog = true;
                index++;
                break;

            default:
                break;
        }

        changer.UpdateImage();

        for (int i = 0; i < textList[index].Length; i++)
        {
            dialougeText.text += textList[index][i];
            yield return new WaitForSeconds(wordSpeed);
        }

        if (dialougeText.text == textList[index])
        {
            contButton.SetActive(true);
        }

        isDialouge = false;
        index++;
        
        //char firstChar = dialouge[index][0];

        /*foreach (char letter in dialouge[index].ToCharArray())
        {
            dialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }*/
    }

    public void nextLine()
    {
        contButton.SetActive(false);

        if (isDialouge == false)
        {
            StartCoroutine(Typing());
        }

        if (index == textList.Count)
        {
            dialougePanel.SetActive(false);
            index = 0;
            return;
        }
    }
   //這個腳本跟世豪完全無關 所以不用動

}
