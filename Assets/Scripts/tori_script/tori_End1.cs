using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class tori_End1 : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    public GameObject chuchu3;
    public GameObject tori;
    public Text ScriptText_name;
    public Text ScriptText_dialogue;
    public string[] dialogue
        = { "��Ʈ�� �����!",
            "���� ��� ���� ��Ʈ�� �� ����??",
        };
    public int dialogue_count = 0;

    public void OnPointerDown(PointerEventData data)
    {
        dialogue_count++;
        Debug.Log("dialogue: " + dialogue_count);

        if (dialogue_count == 2)
        {
            Debug.Log("��ȭ ����");
            SceneManager.LoadScene("MainMap_1");
        }

        ScriptText_dialogue.text = dialogue[dialogue_count];

        //�丮 �̹��� Ȱ��ȭ
        if (dialogue_count == 1)
        {
            chuchu3.SetActive(false);
            tori.SetActive(true);
            ScriptText_name.text = "�丮";
        }
    }
}
