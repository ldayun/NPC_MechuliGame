using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrowClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) // ��ġ��
    {
        if (!DialogueManager.instance.isTyping) //Ÿ���� ȿ�� �߿� Ŭ�� x
        {
            if(DialogueManager.instance.getHint)

            Debug.Log("���� ��� ȣ��");
            DialogueManager.instance.NextSentence();
        }
    }
}
