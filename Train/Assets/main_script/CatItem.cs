using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatItem : MonoBehaviour
{
    bool isFlag = false;
    public GameObject catButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                catButton.SetActive(true);
            }

        }
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isFlag = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isFlag = false;
    }
}

