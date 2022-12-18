using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Initiate.Fade("title3", Color.black, 1.0f);
        }
        
    }
}
