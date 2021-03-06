﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picture : MonoBehaviour
{
    [SerializeField] private Game.Color.MyColor myColor;
    [SerializeField] private Game.Color.MyColor checkColor;
    public Game.Color Color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myColor = Color.myColor;
        ChangeColor();
    }
    public void ChangeColor()
    {
        if(transform.tag == "Enemy")
        {
            if(myColor == Game.Color.MyColor.NOCOLOR)
            {
                transform.parent.transform.Find("after").gameObject.SetActive(true);
                transform.gameObject.SetActive(false);
            }
        }
        switch (myColor)
        {
            case Game.Color.MyColor.RED:
                transform.GetComponent<Image>().color = UnityEngine.Color.red;
                break;
            case Game.Color.MyColor.ORANGE:
                transform.GetComponent<Image>().color = Game.Color.Orange;
                break;
            case Game.Color.MyColor.PURPLE:
                transform.GetComponent<Image>().color = Game.Color.Purple;
                break;
            case Game.Color.MyColor.CYAN:
                transform.GetComponent<Image>().color = UnityEngine.Color.cyan;
                break;
            case Game.Color.MyColor.BLUE:
                transform.GetComponent<Image>().color = UnityEngine.Color.blue;
                break;
            case Game.Color.MyColor.YELLOW:
                transform.GetComponent<Image>().color = UnityEngine.Color.yellow;
                break;
            case Game.Color.MyColor.GREEN:
                transform.GetComponent<Image>().color = UnityEngine.Color.green;
                break;
            case Game.Color.MyColor.BLACK:
                transform.GetComponent<Image>().color = UnityEngine.Color.gray;
                break;
            case Game.Color.MyColor.WHITE:
                transform.GetComponent<Image>().color = UnityEngine.Color.white;
                break;
            case Game.Color.MyColor.NOCOLOR:
                transform.GetComponent<Image>().color = UnityEngine.Color.gray;
                break;
            default:
                break;
        }
    }
}
