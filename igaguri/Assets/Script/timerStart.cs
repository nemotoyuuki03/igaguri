using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timerStart : MonoBehaviour
{
    public Button myButton; // Inspector�Ń{�^����ݒ�
    public timerController timerController;

    void Start()
    {
        // �{�^�����N���b�N���ꂽ�Ƃ��̃C�x���g��o�^
        myButton.onClick.AddListener(OnButtonClick);
    }

    // �{�^�����N���b�N���ꂽ�Ƃ��̏���
    public void OnButtonClick()
    {
        timerController.SetTime();
 
    }
}
