using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerController : MonoBehaviour
{
    public GameObject timeText;
    public string nextSceneName;
    public float transitionTime = 10f;
    
    private float elapsedTime = 0f;
    private static bool timerflg = false;
    // Update is called once per frame
    void Update()
    {
        if(timerflg)
        {
         elapsedTime += Time.deltaTime;

         UpdatetimeText();

         if (elapsedTime >= transitionTime)
         {
            Game.EndGame();
         }

        }
       
        
    }

    private void UpdatetimeText()
    {
        this.timeText.GetComponent<TextMeshProUGUI>().text = "Time:" + elapsedTime.ToString("F2") + " Sec";
    }
    public  static void SetTime()
    {
        timerflg= true;
    }
}
