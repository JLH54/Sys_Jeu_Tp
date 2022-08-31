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

    [SerializeField]
    private string LvlMessage;

    [SerializeField]
    private GameObject ObjectLvlText;

    [SerializeField]
    private Text LvlText;

    [SerializeField]
    private GameObject ObjectTalkingTextBox;

    [SerializeField]
    private Text TalkingTextBox;

    [SerializeField]
    private string TalkingBox;

    [SerializeField]
    private GameObject StartButton;

    [SerializeField]
    private float PlayerWidth;

    [SerializeField]
    private float PlayerHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.x + (PlayerWidth / 2) > LevelIcon.transform.position.x) &&
            (transform.position.x + (PlayerWidth / 2) < LevelIcon.transform.position.x + WidthIcon) &&
            (transform.position.y + (PlayerHeight / 2) > LevelIcon.transform.position.y) &&
            (transform.position.y + (PlayerHeight / 2) < LevelIcon.transform.position.y + HeightIcon))
        {
            LvlText.text = LvlMessage;
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
