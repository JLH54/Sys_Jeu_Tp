using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject LevelIcon;

    [SerializeField]
    private GameObject ObjectLvlText;

    [SerializeField]
    private Text LvlText;

    [SerializeField]
    private GameObject ObjectTalkingTextBox;

    [SerializeField]
    private Text TalkingTextBox;

    [SerializeField]
    private GameObject StartButton;

    [SerializeField]
    private LvlSelector Data;

    private int LvlSelected;

    private int idx;

    private bool IsOnLvlSelector;

    // Start is called before the first frame update
    void Start()
    {
        idx = 1;
        IsOnLvlSelector = false;
    }

    // Update is called once per frame
    void Update()
    {
        SendLevelToUi();
        if(IsOnLvlSelector)
        {
            if (Input.GetKeyDown(KeyCode.Space) && idx == 1)
            {
                Debug.Log("Second text");
                StopAllCoroutines();
                LvlText.text = Data.title;
                TalkingTextBox.text = "";
                StartCoroutine(TypeWriter(Data.description2, TalkingTextBox));
                idx++;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && idx == 2)
            {
                StopAllCoroutines();
                LvlText.text = Data.title;
                TalkingTextBox.text = "";
                StartCoroutine(TypeWriter(Data.description3, TalkingTextBox));
                StartButton.SetActive(true);
                idx++;
            }
        }
    }

    private IEnumerator TypeWriter(string text, Text textBox)
    {
        foreach (char c in text)
        {
            textBox.text += c;
            yield return new WaitForSeconds(0.125f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            
            ObjectLvlText.SetActive(true);
            StartCoroutine(TypeWriter(Data.title, LvlText));

            ObjectTalkingTextBox.SetActive(true);
            StartCoroutine(TypeWriter(Data.description1, TalkingTextBox));

            IsOnLvlSelector = true;

            LvlSelected = Data.id;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ObjectLvlText.SetActive(false);
        ObjectTalkingTextBox.SetActive(false);
        StartButton.SetActive(false);
        StopAllCoroutines();
        IsOnLvlSelector = false;
        LvlText.text = "";
        TalkingTextBox.text = "";
    }

    private void SendLevelToUi()
    {

    }
}
