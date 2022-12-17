using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  
public class ItemButtonText : MonoBehaviour
{
    int itemId = 0;
    int[] itemArray = new int[17];
    public Text buttonName;
    public GameObject itemObject;
    public String itemName;

    //　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;
 
    // Start is called before the first frame update
    void Start()
    {
        //buttonContentText.SetActive(false);

    }
  
    // Update is called once per frame
    void Update()
    {
        //itemName = "hanataba";
        itemArray = ItemManager.instance.array;
        //Debug.Log(itemArray[0]);
        itemName = itemObject.name;
        itemId = GetItem(itemName).GetId();
        //Debug.Log(itemArray[itemId]);
        if(itemArray[itemId] == 0){
            buttonName.text = "";
        }else{
            buttonName.text = GetItem(itemName).GetName();
        }
        
    }

    //　名前でアイテムを取得
	public ItemData GetItem(string searchName){
		return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
	}
}