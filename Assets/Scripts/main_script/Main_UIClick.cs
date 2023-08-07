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
    public GameObject RuleImage;
    public int idx;

    // Start is called before the first frame update

    private void Awake()
    {
        foreach (GameObject box in Box)
            box.SetActive(false);
        idx = GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex;

    }
    public void HintBtnClick()
    {
        
    }

    public void SettingBtnClick()
    {
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

        Debug.Log("�� ���� Lv1���� �ٽ� �����ϱ�");
        Close();

        if (idx == 0)
            SceneManager.LoadScene("SampleScene_Mieu");
        else if (idx == 2)
            SceneManager.LoadScene("fly_GameScene");
        //SceneManager.LoadScene($"GameScene_{idx}");
    }

    public void Setting_RuleClick()
    {
        Debug.Log("���� ��� ������");
    }

    public void SoundBtnClick()
    {
        Debug.Log("�Ҹ� ��ư Ŭ��");
        Box[2].SetActive(true);
        Debug.Log(Box[2]);
    }
    public void Close()
    {
        if (Box[0].activeSelf)
            Box[0].SetActive(false);
        else if (RuleImage.activeSelf)
            RuleImage.SetActive(false);
        else if (Box[1].activeSelf)
            Box[1].SetActive(false);
        else if (Box[2].activeSelf)
            Box[2].SetActive(false);
    }
    
}
