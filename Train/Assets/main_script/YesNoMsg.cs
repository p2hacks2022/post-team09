using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesNoMsg : MonoBehaviour
{
    public Text confirmText;
    public Button yesButton;
    public Button noButton;
    private Action yesAction;
    private Action noAction;

    // メッセージを表示する
    public void showMsg(string _confirmText, Action _yesAction, Action _noAction)
    {
        showMsg(_confirmText, "はい", "いいえ", _yesAction, _noAction);
    }
    public void showMsg(string _confirmText, string _yesButtonText, string _noButtonText, Action _yesAction, Action _noAction)
    {
        // 質問文を表示するテキストに値を設定
        confirmText.text = _confirmText;
        // はいボタンのラベルを設定
        yesButton.GetComponentInChildren<Text>().text = _yesButtonText;
        // いいえボタンのラベルを設定
        noButton.GetComponentInChildren<Text>().text = _noButtonText;
        // アクティブにする（表示する）
        gameObject.SetActive(true);
        // ボタンのアクションを設定
        yesAction = _yesAction;
        noAction = _noAction;
    }

    // はいボタンの処理
    public void onYesClick()
    {
        yesAction.Invoke();
        // 非アクティブにする
        gameObject.SetActive(false);
    }

    // いいえボタンの処理
    public void onNoClick()
    {
        noAction.Invoke();
        // 非アクティブにする
        gameObject.SetActive(false);
    }
} 
