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
        //SendLevelToUi();

        //Pour pouvoir aller a l'autre bloc de texte
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

    //fait l'effet de typewriter
    private IEnumerator TypeWriter(string text, Text textBox)
    {
        foreach (char c in text)
        {
            textBox.text += c;
            yield return new WaitForSeconds(0.125f);
        }
    }

    //Regarde quand le joueur touche le niveau
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ObjectLvlText.SetActive(true);
            StartCoroutine(TypeWriter(Data.title, LvlText));

            ObjectTalkingTextBox.SetActive(true);
            StartCoroutine(TypeWriter(Data.description1, TalkingTextBox));

            IsOnLvlSelector = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //remet tout comme avant pour que les autres niveaux puisse mettre leur information
        ObjectLvlText.SetActive(false);
        ObjectTalkingTextBox.SetActive(false);
        StartButton.SetActive(false);
        StopAllCoroutines();
        IsOnLvlSelector = false;
        LvlText.text = "";
        TalkingTextBox.text = "";
    }

    //sa va etre pour plus tard
    public string SendLevelToUi()
    {
        return Data.SceneName;
    }
}
