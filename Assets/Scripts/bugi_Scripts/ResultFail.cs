using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultFail : MonoBehaviour
{
    //public GameObject success; //UI������Ʈ���� Ȱ��/��Ȱ��ȭ ����
    public GameObject failed; //����
    //int result;

    // Update is called once per frame
    void Update()
    {
        
        if (Fail.failGoal)
        {
            failed.SetActive(true); //UI������Ʈ Ȱ��ȭ
            //result = Mathf.FloorToInt(Timer.timer);
        }

    }


}
