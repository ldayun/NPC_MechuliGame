using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

    public GameObject success; //UI������Ʈ���� Ȱ��/��Ȱ��ȭ ����
 
    // Update is called once per frame
    void Update()
    {
        if (Finish.goal)
        {
            success.SetActive(true); //UI������Ʈ Ȱ��ȭ
            //result = Mathf.FloorToInt(Timer.timer);
        }
       

    }


}