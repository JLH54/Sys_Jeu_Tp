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
        //if((Player.transform.position.x + (PlayerWidth / 2) > LevelIcon.transform.position.x) &&
        //    (Player.transform.position.x + (PlayerWidth / 2) < LevelIcon.transform.position.x + Data.WidthIcon) &&
        //    (Player.transform.position.y + (PlayerHeight / 2) > LevelIcon.transform.position.y) &&
        //    (Player.transform.position.y + (PlayerHeight / 2) < LevelIcon.transform.position.y + Data.HeightIcon))
        //{
        //    LvlText.text = Data.title;
        //    ObjectLvlText.SetActive(true);

        //    TalkingTextBox.text = Data.description;
        //    ObjectTalkingTextBox.SetActive(true);

        //    StartButton.SetActive(true);

        //    Debug.Log("Activated level");
        //}
        //else
        //{
        //    ObjectLvlText.SetActive(false);
        //    ObjectTalkingTextBox.SetActive(false);
        //    StartButton.SetActive(false);
        //}
        SendLevelToUi();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            LvlText.text = Data.title;
            ObjectLvlText.SetActive(true); 

            TalkingTextBox.text = Data.description;
            ObjectTalkingTextBox.SetActive(true);

            StartButton.SetActive(true);

            LvlSelected = Data.id;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ObjectLvlText.SetActive(false);
        ObjectTalkingTextBox.SetActive(false);
        StartButton.SetActive(false);
    }

    private void SendLevelToUi()
    {

    }
}
