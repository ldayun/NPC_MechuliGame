using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Choose : MonoBehaviour
{
    // Start is called before the first frame update
    /* void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     }*/
    public static Seq_SoundManager instance;
    public void OnClickButton()
    {
        //Debug.Log(gameObject.name + " Clicked");
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        if (clickObject.name == "YBtn") // Continue
        {
           //
        }
        else if (clickObject.name == "NBtn") // �ƴϾƴ� ������ �� ���� ������ �̵�
        {
            Destroy(instance);
            SceneManager.LoadScene("MainMap_1");
        }
    }
}
