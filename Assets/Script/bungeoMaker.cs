using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bungeoMaker
{
    int inside;
    Sprite sprite = (Sprite)Resources.Load("../Image/1.png");

    public void sdf()
    {
        if(sprite != null)
        {
            Debug.Log("있");
        }
        else
        {
            Debug.Log("없");
        }
    }

}
