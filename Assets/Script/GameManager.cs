using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Sprite[] sprites;
    public Dropdown inputinside;
    public InputField inputCount;
    public GameObject mainBungeo;

    public int inside;
    public int count;

    private int posY = 3;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creates()
    {
        count = int.Parse(inputCount.text);

        for(int i = 0; i < count; i++)
        {
            GameObject temp = Instantiate(mainBungeo, new Vector3(-3f + i, posY, 0), transform.rotation);
            temp.GetComponent<Maker>().mainSetting(inputinside.value);
        }
        posY--;

    }
}
