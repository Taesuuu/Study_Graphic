using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private bungeoMaker bungMaker;

    private void Awake()
    {
        bungMaker = new bungeoMaker();
        
    }

    private void Start()
    {
        bungMaker.sdf();
    }
}
