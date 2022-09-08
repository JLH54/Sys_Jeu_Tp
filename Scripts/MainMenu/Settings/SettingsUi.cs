using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsUi : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
