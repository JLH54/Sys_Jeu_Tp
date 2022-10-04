using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private Text p_cash;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
            float points =  float.Parse(p_cash.text);
            points++;
            p_cash.text = points.ToString();
        }
    }
}
