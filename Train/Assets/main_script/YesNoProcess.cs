using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class YesNoProcess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        YesNoMsg msg = GameObject.Find("YesNoMsg").GetComponent<YesNoMsg>();
        msg.showMsg("駅に行きますか?", 
            () => {Initiate.Fade("Current", Color.black, 1.0f); },
            () => { });
    }
}
