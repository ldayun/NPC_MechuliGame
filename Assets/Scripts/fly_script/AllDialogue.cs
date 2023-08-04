using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AllDialogue : MonoBehaviour
{
    public string[] sentences;
    private Scene scene;
    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("All Dialogue ��ũ��Ʈ ����");

        scene = SceneManager.GetActiveScene();
        if ((scene.name).Equals("fly_MainScene"))
        {
            sentences = new string[] { "���� �� �̷��� �ĸ��� ���ơ�.", "(�����̰� ���ĳ��´�)", "������ ���� ���̾�??",
            "���� �ĸ��� �ʹ� ���ƤФФ�\n�� �� �����ֶ�", "(�´� �����̴� �ĸ��� �������ϴ�\nƯ���� ����������..)",
            "ȭ�� �� �������� ��Ÿ���� �ĸ���\n���� �ð� ���� ��ǥ ������ŭ\n������ ��!","1����� 5��, 2����� 8��,\n" +
            "3����� 10���� ��ǥ ������\n�������"};
        }
        else if ((scene.name).Equals("ClearScene"))
        {
            sentences = new string[] { "��Ҵ١� ���� ���� !!!"};
        }
        else if ((scene.name.Equals("AfterClearScene")))
        {
            sentences = new string[] { "��Ʈ�� �����!", "���� �� ������!!" };
        }

        DialogueManager.instance.Ondialogue(sentences);
        Debug.Log("���޿Ϸ�");
    }

    // Update is called once per frame
    void Update()
    {
    }
}