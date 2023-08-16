using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopStartButton : MonoBehaviour
{
    public HomesDatabase homeDB;
    public void OnMouseDown()
    {
        //PlayerPrefs.SetInt("UnlockedHomesss", 0);
        for (int i = 0; i < 7; i++)
        {
            Homes home300 = homeDB.GetHomes(i);
            home300.homeFlag = 0;
            home300.homeFlag2 = 0;
            Debug.Log("�ʱ�ȭ");

        }
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        // 0.5�� ���� ���
        yield return new WaitForSeconds(0.5f);

        //�ӽ� ����.. ���Ŀ� ���� ȭ�� �ѱ��� ����
        SceneManager.LoadScene("StartScenario");
    }
}

