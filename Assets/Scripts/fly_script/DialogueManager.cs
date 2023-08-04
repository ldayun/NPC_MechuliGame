using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public GameObject arrow;
    public CanvasGroup dialogueGroup;

    public Queue<string> sentences;

    public string currentSentence;

    public float typingSpeed = 0.1f;
    public bool isTyping;
    public int index;
    public bool getHint;
    public GameObject character;
    public Text NameText;
    public Sprite[] changeChar;

    public static DialogueManager instance;

    public Scene scene;

    private void Awake()
    {
        Debug.Log("instance �ʱ�ȭ");
        instance = this;
        Debug.Log("instance �ʱ�ȭ �Ϸ�");
        Debug.Log("ť �ʱ�ȭ");
        sentences = new Queue<string>();
        Debug.Log("ť �ʱ�ȭ �Ϸ�");

        scene = SceneManager.GetActiveScene();
    }

    public void Ondialogue(string[] lines)
    {
        sentences.Clear();
        foreach (string line in lines)
        {
            sentences.Enqueue(line); // ť�� ��� �ֱ�              
        }
        dialogueGroup.alpha = 1; //��ȭâ ����
        dialogueGroup.blocksRaycasts = true; // ���콺 �̺�Ʈ ����

        NextSentence();
    }

    public void NextSentence()
    {
        Debug.Log("���� ���" + sentences.Count);
        // ť �� �� ���� ��� �ҷ�����
        if (sentences.Count != 0)
        {
            Debug.Log(sentences.Count);
            currentSentence = sentences.Dequeue();
            if ((scene.name).Equals("fly_MainScene")) //���ξ� ĳ���� �̹��� ��ü
            {
                if (index % 2 == 1 || index > 4)
                {
                    Debug.Log(index + "�ٲٱ�");
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[1];
                    NameText.text = "������";
                }
                else
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[0];
                    NameText.text = "����";
                }

            }
            else if ((scene.name).Equals("ClearScene")) //Ŭ����� ��Ʈ Ȥ�� true
            {
                Debug.Log("Ŭ�����"+index);
                if (index == 0)
                    getHint = true;
            }
             else if((scene.name.Equals("AfterClearScene")))
            {
                if (index == 1)
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[1];
                    NameText.text = "������";
                }
                else
                {
                    character.GetComponent<SpriteRenderer>().sprite = changeChar[0];
                    NameText.text = "����";
                }
               
            }
           index++;
           //�ڷ�ƾ
           isTyping = true;
           arrow.SetActive(false);
           StartCoroutine(Typing(currentSentence));
        }
        else
        {
            /*dialogueGroup.alpha = 0;
            dialogueGroup.blocksRaycasts = false;*/
            if ((scene.name).Equals("fly_MainScene"))
                SceneManager.LoadScene("fly_GameScene");
            else if ((scene.name).Equals("ClearScene"))
                SceneManager.LoadScene("TestScene");
        }
    }

    //Ÿ����ȿ�� �ڷ�ƾ
    IEnumerator Typing(string line)
    {
        dialogueText.text = "";
        foreach (char letter in line.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed); //�ӵ�����
        }
    }

    private void Update()
    {
        //dialogueText == currentSentence �̸� ��� ���� ��
        if (dialogueText.text.Equals(currentSentence)) //���ξ����� ��ȭ ������ ȭ��ǥ ����
        {
            if(!(scene.name).Equals("ClearScene"))
                arrow.SetActive(true);
            isTyping = false;
            Debug.Log("���� ��");
        }
    }

    /* public void OnPointerDown(PointerEventData eventData) // ��ġ��
     {
         if (!isTyping) //Ÿ���� ȿ�� �߿� Ŭ�� x
         {
             Debug.Log("���� ��� ȣ��");
             NextSentence();
         }
     }*/
}
