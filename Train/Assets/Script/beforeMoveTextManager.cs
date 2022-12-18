using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class beforeMoveTextManager : MonoBehaviour
{
   //Endパネル
   public GameObject endPanelGameObject;

   [SerializeField]
   private Text storyText;

   //EndTextファイルから読み込み
   [SerializeField]
   private string textFile = "Texts/EndText";

   //一文字ずつ追加
   [SerializeField]
   private float captionSpeed = 0.2f;

   private Queue<char> _charQueue;

    /**
    * テキストファイルを読み込む
    */
    private string LoadTextFile(string fname)
    {
        TextAsset textasset = Resources.Load<TextAsset>(fname);
        return textasset.text.Replace("\n", "").Replace("\r", "").Replace(".","\r\n");
    }

   //text内の＆でページ遷移
   private const char SEPARATE_PAGE = '&';
   private Queue<string> _pageQueue;
   
   private string _text = "";
   
    /**
    * 文を1文字ごとに区切り、キューに格納したものを返す
    */
    private Queue<char> SeparateString(string str)
    {
        char[] chars = str.ToCharArray();
        Queue<char> charQueue = new Queue<char>();
        foreach (char c in chars) charQueue.Enqueue(c);
        return charQueue;
    }

    /**
    * 文字列を指定した区切り文字ごとに区切り、キューに格納したものを返す
    */
    private Queue<string> SeparateString(string str, char sep)
    {
        string[] strs = str.Split(sep);
        Queue<string> queue = new Queue<string>();
        foreach (string l in strs) queue.Enqueue(l);
        return queue;
    }

    /**
    * 初期化する
    */
    private void Init()
    {
        _text = LoadTextFile(textFile);
        _pageQueue = SeparateString(_text, SEPARATE_PAGE);
        ShowNextPage();
    }

    /**
    * 次のページを表示する
    */
    private bool ShowNextPage()
    {
        if (_pageQueue.Count <= 0) return false;
        ReadLine(_pageQueue.Dequeue());
        return true;
    }

    /**
    * 1文字を出力する
    */
    private bool OutputChar()
    {
        if (_charQueue.Count <= 0) return false;
        storyText.text += _charQueue.Dequeue();
        return true;
    }

    /**
    * 文字送りするコルーチン
    */
    private IEnumerator ShowChars(float wait)
    {
        while (OutputChar())
            // wait秒だけ待機
            yield return new WaitForSeconds(wait);
        yield break;
    }

    /**
    * 全文を表示する
    */
    private void OutputAllChar()
    {
        StopCoroutine(ShowChars(captionSpeed));
        while (OutputChar()) ;
    }

    private void Start()
    {
        
        Init();
    }
    
    /**
    * クリックしたときの処理
    */
    private void OnClick()
    {
        if (_charQueue.Count > 0) OutputAllChar();
        else
        {
            if (!ShowNextPage())
                
                Initiate.Fade("tyuuou_main 4", Color.black, 1.0f);
        }
    }

    private void Update()
    {
        // 左(=0)クリックされたらOnClickメソッドを呼び出し
        if (Input.GetMouseButtonDown(0)) OnClick();
    }
    
    private void ReadLine(string text)
    {   
        storyText.text = "";
        _charQueue = SeparateString(text);
        StartCoroutine(ShowChars(captionSpeed));
    }
}
