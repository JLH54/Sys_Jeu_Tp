using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevels : MonoBehaviour
{
    [SerializeField]
    private GameObject b_ReturnToLvlSelector;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Finish"))
        {
            b_ReturnToLvlSelector.SetActive(true);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            Destroy(gameObject.GetComponent<PlayerMovementInLevels>());

        }
    }
}
