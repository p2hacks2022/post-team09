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
	//　アイテムの名前
	[SerializeField]
	private string itemName;
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
 
	public string GetItemName() {
		return itemName;
	}
 
	public string GetText() {
		return text;
	}

	public string GetText2() {
		return text2;
	}

	public string GetText3() {
		return text;
	}

	public string GetText4() {
		return text2;
	}
	public string GetText5() {
		return text;
	}

	public string GetText6() {
		return text2;
	}
	public string GetText7() {
		return text;
	}

	public string GetText8() {
		return text2;
	}
	public string GetText9() {
		return text;
	}

	public string GetText10() {
		return text2;
	}
}