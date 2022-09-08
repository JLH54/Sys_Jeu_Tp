using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChooseGameUi : MonoBehaviour
{
   public void StartNewGameButtonCLick()
    {
        SceneManager.LoadScene(3);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
