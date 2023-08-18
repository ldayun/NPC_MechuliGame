using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tori_End : MonoBehaviour
{
    public GameObject hintTori;
    public GameObject hintGetBtn;
    public GameObject hintBox;
    public GameObject toriHint;

    //��Ʈ ȹ�� ��ư Ŭ����
    public void HintGetButtonClick()
    {
        hintTori.SetActive(false);
        hintBox.SetActive(true);
    }

    //��Ʈ ���� Ŭ����
    public void HintBoxClick()
    {
        toriHint.SetActive(true);
    }

    //��Ʈ Ŭ����
    public void ToriHintClick()
    {
        hintGetBtn.SetActive(false);
        hintBox.SetActive(false);
        toriHint.SetActive(false);
        SceneManager.LoadScene("tori_End1");
    }
}
