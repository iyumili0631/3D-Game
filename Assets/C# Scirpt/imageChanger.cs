using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageChanger : MonoBehaviour
{
    public Sprite imageDog;
    public Sprite imagePrincess;
    public NPC npc;
    public Image imageComponent;

    void Start()
    {
        imageComponent = GetComponent<Image>();
        //UpdateImage();
    }

    void Update()
    {
        
    }

    // 這個函數用來初始化和更新圖片
    public void UpdateImage()
    {
        if (npc.isDog)
        {
            imageComponent.sprite = imageDog;
        }
        else
        {
            imageComponent.sprite = imagePrincess;
        }
    }
}