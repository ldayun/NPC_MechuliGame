using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Main_UIClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Btn;
    public GameObject [] Box;
    public Sprite [] RuleImageArray;
    public GameObject RuleImage;
    public int idx;

    // Start is called before the first frame update

    private void Awake()
    {
        foreach (GameObject box in Box)
            box.SetActive(false);

    }

    private void Update()
    {
        idx = GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex;
        if (idx != -1)
            RuleImage.GetComponent<Image>().sprite = RuleImageArray[idx];
    }
    public void HintBtnClick()
    {
        
    }

    public void SettingBtnClick()
    {
        TimePause();
        Debug.Log("���� ��ư Ŭ��");
        Box[1].SetActive(true);
        Debug.Log(Box[1]);
    }

    public void Setting_ToMainClick()
    {
        Debug.Log("�������� ��ư Ŭ��");
        //MainMap�����̵�
        Close();
        SceneManager.LoadScene("MainMap_1");

    }

    public void Setting_RetryClick()
    {

        Debug.Log("�� ���� Lv1���� �ٽ� �����ϱ�"+idx);
        Close();
        string currentScene = SceneManager.GetActiveScene().name;
        
        if (idx == 0)
        {
            Debug.Log("���� �� unload");
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene("SampleScene_Mieu");

        }
        else if (idx == 2)
            SceneManager.LoadScene("fly_GameScene");
        //SceneManager.LoadScene($"GameScene_{idx}");
    }

    public void Setting_RuleClick()
    {
        Debug.Log("���� ��� ������");
        RuleImage.SetActive(true);

    }

    public void SoundBtnClick()
    {
        
        Debug.Log("�Ҹ� ��ư Ŭ��");
        Box[2].SetActive(true);
        Debug.Log(Box[2]);
    }
    public void Close()
    {
        // RuleImage ?�성???�태??경우 비활?�화 처리
        if (RuleImage.activeSelf)
        {
            RuleImage.SetActive(false);
            return;
        }

        for (int i = 0; i < Box.Length; i++)
        {
            if (Box[i].activeSelf)
            {
                Box[i].SetActive(false);
                TimeStart();
                break; // ?�성?�된 ?�소�?찾았?�면 루프 종료
            }
        }

    }
    
    public void TimePause()
    {
        Time.timeScale = 0;
    }

    public void TimeStart()
    {
        Time.timeScale = 1;
    }
}
