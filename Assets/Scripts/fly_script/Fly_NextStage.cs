using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_NextStage : MonoBehaviour
{
    public GameObject GameManager;
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Debug.Log("���� Ŭ��");
        GameManager.GetComponent<Fly_GameManager>().NextStage();
    }
}
