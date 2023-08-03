using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public string names;
}

public class test : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;
    [SerializeField] private Text txt_nametag;

    [SerializeField] private GameObject game_method;
    [SerializeField] private GameObject bgd;

    private bool isDialogue = false;
    private int count_dia = 0;

    [SerializeField] private Dialogue[] dialogue;
   // [SerializeField] private Names[] names;

    /*public void ShowDialogue()
    {
        OnOff(true);

        count_dia = 0;
        NextDialogue();
    }*/
   private void OnOff(bool _flag)
    {
        sprite_DialogueBox.gameObject.SetActive(_flag);
        sprite_StandingCG.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        txt_nametag.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }
   

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count_dia].dialogue;
        sprite_StandingCG.sprite = dialogue[count_dia].cg;
        txt_nametag.text = dialogue[count_dia].names;
        count_dia++;
    }
    // Start is called before the first frame update
    void Start()
    {
        OnOff(true);

        count_dia = 0;
        NextDialogue();
    }
    void unknown()
    {
        game_method.SetActive(true);
        bgd.SetActive(true);
    }

    void gotoScene()
    {
        //SceneManager.LoadScene("MainScene");

        SceneManager.LoadScene("dangdang_gameMethod");

        SceneManager.LoadScene("gameMethod");

    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Collider2D hitCollider = Physics2D.OverlapPoint(clickPosition);

                // 특정 Collider2D를 클릭한 경우에만 다음 대화로 넘어갑니다.
                if (hitCollider != null)
                {
                    if (count_dia < dialogue.Length)
                        NextDialogue();
                    else
                    {
                        //OnOff(false);

                        gotoScene();

                    }
                }
            }
        }
    }
}
