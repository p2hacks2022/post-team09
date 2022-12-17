using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChangeProfile : MonoBehaviour
{
    // Start is called before the first frame update
    //private bool firstPush = false;
    [SerializeField] GameObject titleUI;
    [SerializeField] GameObject gameProfileUI;
    private void Start()
    {
        gameProfileUI.SetActive(false);
    }

    public void PressStart()
    {
        
        //if (!firstPush)
        //{
            titleUI.SetActive(false); //‚Í‚¶‚ß‚Í”ñ•\Ž¦
            gameProfileUI.SetActive(true);
            


           // firstPush = true;
        //}
    }

}