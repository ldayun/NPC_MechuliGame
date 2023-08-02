using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Btn;
    public GameObject [] Box;
    public GameObject HintImage;
    public GameObject RuleImage;
    public GameObject [] Hint;

    // Start is called before the first frame update

    private void Awake()
    {
        // Debug.Log(GameObject.Find("MainManager").GetComponent<MainManager>().Hint_Gaegul);
        foreach (GameObject box in Box)
            box.SetActive(false);

    }
    public void HintBtnClick()
    {
        Debug.Log("��Ʈ ��ư Ŭ��");
        Box[0].SetActive(true);
        Debug.Log(Box[0]);
        if (GameObject.Find("MainManager").GetComponent<MainManager>().Hint_Gaegul == true)
        {
            foreach(GameObject obj in Hint) //��Ʈ ȹ�� �� �Ŀ� Ŭ�� �� ��Ʈ�� ���̰�
            {
                obj.SetActive(true);
            }
        }
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
        //MainScene�����̵�
        Close();
        SceneManager.LoadScene("TestScene");

    }

    public void Setting_RetryClick()
    {
        Debug.Log("�� ���� Lv1���� �ٽ� �����ϱ�");
        Close();
        SceneManager.LoadScene("GameScene");
    }

    public void Setting_RuleClick()
    {
        RuleImage.SetActive(true);
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

    public void ShowHint()
    {
        Debug.Log("��ư Ŭ��");
        HintImage.SetActive(true); //AfterclearScene
        Debug.Log("��Ʈ ������");
    }
    
}
