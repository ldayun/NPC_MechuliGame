using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Fly_DialogueBoxClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) // ��ġ��
    {
        /*if (!Fly_DialogueManager.instance.isTyping) //Ÿ���� ȿ�� �߿� Ŭ�� x
        {
            if(Fly_DialogueManager.instance.getHint)

            Debug.Log("���� ��� ȣ��");
            Fly_DialogueManager.instance.NextSentence();
        }*/
        Fly_DialogueManager.instance.NextSentence();

    }
}
