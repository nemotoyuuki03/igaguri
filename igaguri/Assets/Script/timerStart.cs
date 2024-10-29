using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerStart : MonoBehaviour
{
    public Button myButton; // Inspectorでボタンを設定
    public timerController timerController;

    void Start()
    {
        // ボタンがクリックされたときのイベントを登録
        myButton.onClick.AddListener(OnButtonClick);
    }

    // ボタンがクリックされたときの処理
    public void OnButtonClick()
    {
        timerController.SetTime();
 
    }
}
