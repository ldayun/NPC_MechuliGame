using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public GameObject GameManager;
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Debug.Log("���� Ŭ��");
        GameManager.GetComponent<GameManager>().NextStage();
    }
}
