using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item : MonoBehaviour
{
    bool isFlag = false;
    int click = 0;
    public GameObject text;
    public Text textText;
    public String itemName;

    //　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFlag == true){
            if(Input.GetKeyDown (KeyCode.F)){
                itemName = this.gameObject.name;
                textText.text = GetItem (itemName).GetText();//sentence(this.text);
                text.SetActive(true);
                
            }
            if (Input.GetMouseButtonDown(0)){
                click++;
            }
/*
            if(click == 1){
                if(textText.text.Contains(2)){
                    text.SetActive(false);
                }
                textText.text = GetItem (itemName).GetText2();
            }
            */
            /*
            if(click == 2){
                if(textText.text.Contains(2)){
                    text.SetActive(false);
                }
                textText.text = GetItem (itemName).GetText3();
            }if(click == 3){
                if(textText.text.Contains(2)){
                    text.SetActive(true);
                }
                textText.text = GetItem (itemName).GetText4();
            }if(click == 4){
                textText.text = GetItem (itemName).GetText5();
                if(textText.text == ""){
                    text.SetActive(false);
                }
            }if(click == 5){
                textText.text = GetItem (itemName).GetText6();
                if(textText.text == null){
                    text.SetActive(false);
                }
            }if(click == 6){
                textText.text = GetItem (itemName).GetText7();
                if(textText.text == null){
                    text.SetActive(false);
                }
            }if(click == 7){
                textText.text = GetItem (itemName).GetText8();
                if(textText.text == null){
                    text.SetActive(false);
                }
            }if(click == 8){
                textText.text = GetItem (itemName).GetText9();
                if(textText.text == null){
                    text.SetActive(false);
                }
            }if(click == 9){
                textText.text = GetItem (itemName).GetText10();
                if(textText.text == null){
                    text.SetActive(false);
                }
            }
            */

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
	public ItemData GetItem(string searchName) {
		return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == searchName);
	}
    
    
    /*
    public GameObject gameObject;

    if(hoge == true)
    {
        gameObject.SetActive(true);
    }
    */
}
