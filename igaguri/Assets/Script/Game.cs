using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SceneDate;

public class Game : MonoBehaviour
{

    public static Game Instance { get; private set; }
    public int score { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //�X�^�[�g���\�b�h
    public  static void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }

    //�G���h���\�b�h
    public static void EndGame()
    {
        //�l�������X�R�A�ƃ��U���g��ʂ֑J��
        SceneData.score = Score_Script.instance.GetCurrentScore();

        SceneManager.LoadScene("Result");
    }
}
