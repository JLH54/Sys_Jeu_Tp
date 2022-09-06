using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnLevel : MonoBehaviour
{
    [SerializeField]
    private GameObject LevelIcon;

    [SerializeField]
    private float WidthIcon;

    [SerializeField]
    private float HeightIcon;

    private string LvlTitle;

    private GameObject ObjectLvlText;

    [SerializeField]
    private Text LvlText;

    [SerializeField]
    private GameObject ObjectTalkingTextBox;

    [SerializeField]
    private Text TalkingTextBox;

    private string TalkingBox;

    [SerializeField]
    private GameObject StartButton;

    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private float PlayerWidth;

    [SerializeField]
    private float PlayerHeight;

    [SerializeField]
    private LvlSelector Data;

    private int LvlSelected;

    // Start is called before the first frame update
    void Start()
    {
        LvlSelected = Data.id;
        LvlTitle = Data.title;
        TalkingBox = Data.description;
    }

    // Update is called once per frame
    void Update()
    {
        if((Player.transform.position.x + (PlayerWidth / 2) > LevelIcon.transform.position.x) &&
            (Player.transform.position.x + (PlayerWidth / 2) < LevelIcon.transform.position.x + WidthIcon) &&
            (Player.transform.position.y + (PlayerHeight / 2) > LevelIcon.transform.position.y) &&
            (Player.transform.position.y + (PlayerHeight / 2) < LevelIcon.transform.position.y + HeightIcon))
        {
            LvlText.text = LvlTitle;
            ObjectLvlText.SetActive(true);

            TalkingTextBox.text = TalkingBox;
            ObjectTalkingTextBox.SetActive(true);

            StartButton.SetActive(true);

            Debug.Log("Activated level");
        }
        else
        {
            ObjectLvlText.SetActive(false);
            ObjectTalkingTextBox.SetActive(false);
            StartButton.SetActive(false);
        }
    }
}
