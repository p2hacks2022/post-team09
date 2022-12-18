using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    bool isFlag = false;
    int click = 0;
    int objectNumber = 16;
    public GameObject itemExplanationTextPanel;
    public GameObject itemObject;
    public Text itemExplanationText;
    public String itemName;

    //　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;

    // Start is called before the first frame update
    void Start()
    {
        ItemManager.instance.n = objectNumber;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isFlag);
        
        if(isFlag == true){
            if(Input.GetKeyDown(KeyCode.F)){
                itemObject = this.gameObject;
                itemName = itemObject.name;
                itemExplanationText.text = GetItem(itemName).GetText();//sentence(this.text);
                itemExplanationTextPanel.SetActive(true);
                objectNumber = GetItem(itemName).GetId();
                //Debug.Log(objectNumber);
                ItemManager.instance.n = objectNumber;
                ItemManager.instance.itemCountManager++;
                
            }
            if (Input.GetMouseButtonDown(0)){
                click++;
            }

            if(click == 1){
                //Debug.Log(textText.text.Contains(""));
                itemExplanationText.text = GetItem(itemName).GetText2();
                if(itemExplanationText.text == ""){
                    //Debug.Log(textText.text);
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 2){
                itemExplanationText.text = GetItem(itemName).GetText3();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 3){
                itemExplanationText.text = GetItem(itemName).GetText4();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 4){
                itemExplanationText.text = GetItem(itemName).GetText5();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 5){
                itemExplanationText.text = GetItem(itemName).GetText6();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 6){
                itemExplanationText.text = GetItem(itemName).GetText7();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 7){
                itemExplanationText.text = GetItem(itemName).GetText8();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 8){
                itemExplanationText.text = GetItem(itemName).GetText9();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
            }
            if(click == 9){
                itemExplanationText.text = GetItem(itemName).GetText10();
                if(itemExplanationText.text == ""){
                    itemExplanationTextPanel.SetActive(false);
                    itemObject.SetActive(false);
                }
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


	//　名前でアイテムを取得
	public ItemData GetItem(string searchName){
		return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
	}
}
