using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public  Camera MainCamera;
    public Camera EffectCamera;
    public timerController timer;
    //�ω������鎞��
    public float transitionDuration = 2.0f;
    //�J���������ʒu
    public Vector3 startPosition = new Vector3(0, 10, -10);
    //�J�����̏I���ʒu
    public Vector3 endPosition = new Vector3(0, 5, -9);

    void Start()
    {
       StartCoroutine(CamraTransition() );
        
    }

    // Update is called once per frame
   private IEnumerator CamraTransition()
   {
        MainCamera.enabled = false;
        EffectCamera.enabled = true;
        EffectCamera.transform.position = startPosition;
        float elapeedtime = 0f;
        while(elapeedtime<transitionDuration)
        {
            EffectCamera.transform.position = Vector3.Lerp(startPosition, endPosition, elapeedtime / transitionDuration);
            elapeedtime += Time.deltaTime;
            yield return null;
        }
        //�J�����ɃI�u�W�F�N�g������
        MainCamera.enabled = true;
        //�G�t�F�N�g�̃I�u�W�F�N�g��؂�
        EffectCamera.enabled=false;
            

    }
}
