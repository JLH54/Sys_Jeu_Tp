using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiInLevels : MonoBehaviour
{
    public void OnReturnLevelClick()
    {
        SceneManager.LoadScene("LvlSelector");
    }
}
