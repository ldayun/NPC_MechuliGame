using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaneulSoundManager : MonoBehaviour
{
    public AudioSource bgm;

    public void Awake()
    {
        var soundManagers = FindObjectsOfType<BaneulSoundManager>();
        
        if (soundManagers.Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
      
    }
    void Start()
    {
        bgm.Play();
    }
    void Update()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        // ���̸��� MainMap_1�̸� ���� ������Ʈ �ı�
        if (currentSceneName == "MainMap_1")
            Destroy(gameObject);
    }
}
