using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
[Serializable]
[CreateAssetMenu(fileName = "Item", menuName="CreateItem")]
public class ItemData : ScriptableObject {
 
	public enum KindOfItem {
		OnlyText,
		UseItem
	}
 
	//　アイテムの種類
	[SerializeField]
	private KindOfItem kindOfItem;
	//　アイテムのアイコン
	[SerializeField]
	private Sprite icon;
	//　オブジェクトのid
	[SerializeField]
	private int id;
	//　オブジェクトの名前
	[SerializeField]
	private string itemName;
	//　アイテムの名前
	[SerializeField]
	private string Name;
	//　アイテムの情報
	[SerializeField]
	private string text;
	[SerializeField]
	private string text2;
	[SerializeField]
	private string text3;
	[SerializeField]
	private string text4;
	[SerializeField]
	private string text5;
	[SerializeField]
	private string text6;
	[SerializeField]
	private string text7;
	[SerializeField]
	private string text8;
	[SerializeField]
	private string text9;
	[SerializeField]
	private string text10;
 
	public KindOfItem GetKindOfItem() {
		return kindOfItem;
	}
 
	public Sprite GetIcon() {
		return icon;
	}

	public int GetId() {
		return id;
	}
 
	public string GetItemName() {
		return itemName;
	}

	public string GetName() {
		return Name;
	}
 
	public string GetText() {
		return text;
	}

	public string GetText2() {
		return text2;
	}

	public string GetText3() {
		return text3;
	}

	public string GetText4() {
		return text4;
	}

	public string GetText5() {
		return text5;
	}

	public string GetText6() {
		return text6;
	}

	public string GetText7() {
		return text7;
	}

	public string GetText8() {
		return text8;
	}

	public string GetText9() {
		return text9;
	}

	public string GetText10() {
		return text10;
	}
}