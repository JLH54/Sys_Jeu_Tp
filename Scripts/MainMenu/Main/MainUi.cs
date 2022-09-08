using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainUi : MonoBehaviour
{
    public void StartGameButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButtonClick()
    {
        SceneManager.LoadScene(2);
    }

    public void QuiGameButtonClick()
    {
        Application.Quit();
    }

    public void ChargeGameButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
