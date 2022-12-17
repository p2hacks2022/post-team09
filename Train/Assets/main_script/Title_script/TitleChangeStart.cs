using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChangeStart : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;

    public void PressStart()
    {
        
        if (!firstPush)
        {
            
            Initiate.Fade("Start", Color.black, 1.0f);
            firstPush = true;
        }
    }

}
