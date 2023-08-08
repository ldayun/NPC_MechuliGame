using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaneulSoundManager : MonoBehaviour
{
    public AudioSource bgm;

    public void Awake()
    {
        var baneulsoundManagers = FindObjectsOfType<BaneulSoundManager>();
        
        if (baneulsoundManagers.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);

        // �ε��� ����
        GameObject.Find("Main_MainManager").GetComponent<Main_MainManager>().gameIndex = 3;

    }
    void Start()
    {
        bgm.Play();
    }
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        // ���̸��� MainMap_1�̸� ���� ������Ʈ �ı�
        /* if (currentSceneName != "BaneulTalk" 
             && currentSceneName != "BaneulEndTalk1" 
             && currentSceneName != "ShopGameScene" 
             && currentSceneName != "ShoppingGetHint"
              && currentSceneName != "ShoppingHintScene"
               && currentSceneName != "ShopRuleScene")
             Destroy(gameObject); */
        if (scene.name == "MainMap_1")
        {
            Debug.Log("�ı��Ǿ����");
            Destroy(gameObject);
        }
    }
}
