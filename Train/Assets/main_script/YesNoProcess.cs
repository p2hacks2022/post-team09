using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class YesNoProcess : MonoBehaviour
{
    int itemCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        itemCount = ItemManager.instance.itemCountManager;

        YesNoMsg msg = GameObject.Find("YesNoMsg").GetComponent<YesNoMsg>();
        if(itemCount != 10)
        {
            msg.showMsg("電車に乗りますか?", 
            () => { Initiate.Fade("current 1", Color.black, 1.0f); },
            () => { }); 
        }else{
            msg.showMsg("電車に乗りますか?", 
            () => { Initiate.Fade("normalcurrent 1", Color.black, 1.0f); },
            () => { });
        }
    }
}
