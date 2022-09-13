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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SendLevelToUi();
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
            StartCoroutine(TypeWriter(Data.description, TalkingTextBox));

            StartButton.SetActive(true);

            LvlSelected = Data.id;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ObjectLvlText.SetActive(false);
        ObjectTalkingTextBox.SetActive(false);
        StartButton.SetActive(false);
        StopAllCoroutines();
        LvlText.text = "";
        TalkingTextBox.text = "";
    }

    private void SendLevelToUi()
    {

    }

    
}
