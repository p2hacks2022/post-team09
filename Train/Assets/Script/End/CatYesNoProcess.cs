using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CatYesNoProcess : MonoBehaviour
{
    //int itemCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        //itemCount = ItemManager.instance.itemCountManager;

        YesNoMsg msg = GameObject.Find("CatYesNoPanel").GetComponent<YesNoMsg>();
        
            msg.showMsg("猫を拾いますか?", 
            () => { Initiate.Fade("trueend", Color.black, 1.0f); },
            () => { Initiate.Fade("normalend", Color.black, 1.0f);}); 
    }
}