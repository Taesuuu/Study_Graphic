using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maker : MonoBehaviour
{
    private int inside;
    public Sprite[] sprites;


    private void Start()
    {

    }

    public void mainSetting(int getinside)
    {
        this.inside = getinside;

        switch (inside)
        {
            case 0:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                break;

            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
                break;

            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
                break;

        }
    }
}
