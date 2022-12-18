using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChangeHow : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;
    [SerializeField] GameObject titleUI;
    [SerializeField] GameObject gameHowUI;
    private void Start()
    {
        gameHowUI.SetActive(false);
    }

    public void PressStart()
    {
        
        if (!firstPush)
        {
            titleUI.SetActive(false); 
            gameHowUI.SetActive(true);
            


            firstPush = true;
        }
    }

}