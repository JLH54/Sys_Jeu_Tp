using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevels : MonoBehaviour
{
    [SerializeField]
    private GameObject b_ReturnToLvlSelector;

    [SerializeField]
    private Canvas p_ui;

    [SerializeField]
    private GameObject p_cash;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            float canvasHeight = p_ui.GetComponent<RectTransform>().rect.height;
            float canvasWidth = p_ui.GetComponent<RectTransform>().rect.width;
            p_cash.transform.position = new Vector3(canvasWidth / 2, canvasHeight / 2, 0);
            b_ReturnToLvlSelector.SetActive(true);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Destroy(gameObject.GetComponent<PlayerMovementInLevels>());

        }
    }
}
