using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    public GameObject Success; //���� �̹���
    public GameObject Failure; //���� �̹���
    public GameObject Rabbit; //�䳢 �̹���
    private bool success_state; //�����̹��� Ȱ��ȭ.��Ȱ��ȭ ����
    private bool failure_state; //�����̹��� Ȱ��ȭ.��Ȱ��ȭ ����

    private int game_success_count = 0; //���� ���� ī��Ʈ

    private bool rabbit_state; //�䳢�̹��� Ȱ��ȭ.��Ȱ��ȭ ����
    public GameObject[] Carrot = new GameObject[12]; //����̹���
    private bool carrot_state; //�䳢�̹��� Ȱ��ȭ.��Ȱ��ȭ 
    private int sum = 0; //��� ���� �հ�
    private int game_level = 0; //���� ����
    public GameObject[] level = new GameObject[3]; //�����̹���

    void Start()
    {
        CarrotView();

        //����.���� �̹��� ��Ȱ��ȭ
        success_state = false;
        failure_state = false;
        //�䳢 �̹��� Ȱ��ȭ
        rabbit_state = true;
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        Rabbit.SetActive(rabbit_state);
    }

    //��� ���� ����
    void CarrotView()
    {
        int i = 0;
        int carrotStateNum; //��� Ȱ��.��Ȱ��ȭ ���� ���� ����
        carrot_state = false;

        //��� �ʱ�ȭ(��Ȱ��ȭ)
        for (i = 0; i < 12; i++)
            Carrot[i].SetActive(carrot_state);

        GameLevel();
        Debug.Log("���� ����: " + game_success_count);

        //��� ���� �ʱ�ȭ
        sum = 0;

        for (i = 0; i < 12; i++)
        {
            //��� �������� Ȱ��.��Ȱ��ȭ ����
            carrotStateNum = Random.Range(0, 2);

            //carrotStateNum�� 1�̸� Ȱ��ȭ
            if (carrotStateNum == 1)
                carrot_state = true;

            //0�̸� ��Ȱ��ȭ
            else
                carrot_state = false;

            //��� Ȱ��.��Ȱ��ȭ
            Carrot[i].SetActive(carrot_state);
            //Ȱ��ȭ�� ��� ����
            sum += carrotStateNum;
        }

        //�ܼ� ��� Ȯ��
        Debug.Log("��� ����: " +  sum);
    }


    //¦�� ��ư Ŭ�� ��
    public void EvenButtonClick()
    {
        //��� ������ ¦�����
        if (sum % 2 == 0)
        {
            success_state = true;
            failure_state = false;
            game_success_count++;
        }

        //��� ������ Ȧ�����
        else
        {
            success_state = false;
            failure_state = true;
        }

        //����.���� �̹��� ���
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //�ܼ� ��� Ȯ��
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //���� ���� ����� �� �䳢 �̹��� ���
        Invoke("Start", 3);
    }

    //Ȧ�� ��ư Ŭ�� ��
    public void OddButtonClick()
    {
        //��� ������ Ȧ�����
        if (sum % 2 != 0)
        {
            success_state = true;
            failure_state = false;
            game_success_count++;
        }

        //��� ������ ¦�����
        else
        {
            success_state = false;
            failure_state = true;
        }

        //����.���� �̹��� ���
        rabbit_state = false;
        Rabbit.SetActive(rabbit_state);
        Success.SetActive(success_state);
        Failure.SetActive(failure_state);
        //�ܼ� ��� Ȯ��
        Debug.Log("success_state: " + success_state + " / failure_state: " + failure_state);
        //���� ���� ����� �� �䳢 �̹��� ���
        Invoke("Start", 3);
    }

    //���� ����
    public void GameLevel()
    {
        int i = 0;

        //���� �̹��� Ȱ��ȭ/��Ȱ��ȭ
        for (i = 0; i < 3; i++)
        {
            //���� ������ �ε����� ������ �̹��� Ȱ��ȭ
            if (i == game_level)
                level[i].SetActive(true);
            else
                level[i].SetActive(false);
        }


        game_level++; //���� ���� ī��Ʈ
        Debug.Log("���� ����: " + game_level);

        //���� ����
        if (game_level == 4)
        {
            GameExit();
            Debug.Log("���� ����");
            SceneManager.LoadScene("tori_End");

        }

    }

    //���� ����
    public void GameExit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }


}