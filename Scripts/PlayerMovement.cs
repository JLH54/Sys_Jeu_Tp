using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Script pour le mouvement du joueur
    [SerializeField]
    private float PlayerSpeed;

    [SerializeField]
    private float LeftBound;

    [SerializeField]
    private float RightBound;

    [SerializeField]
    private float UpBound;

    [SerializeField]
    private float DownBound;

    void Update()
    {
        //Ceci est le mouvement du joueur avec les limites
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * PlayerSpeed * Time.deltaTime);
        }
    }
}
