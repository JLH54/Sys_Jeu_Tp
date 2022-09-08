using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Script pour le mouvement du joueur
    [SerializeField]
    private float PlayerSpeed;

    [SerializeField]
    private float JumpForce;

    private Animator AnimatorController;

    private SpriteRenderer Sprite;

    private void Start()
    {
        AnimatorController = GetComponent<Animator>();
        Sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //Ceci est le mouvement du joueur avec les limites
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * PlayerSpeed * Time.deltaTime);
            AnimatorController.SetBool("Running", true);
            Sprite.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * PlayerSpeed * Time.deltaTime);
            AnimatorController.SetBool("Running", true);
            Sprite.flipX = true;
        }
        else
        {
            Sprite.flipX = false;
            AnimatorController.SetBool("Running", false);
        }
    }
}
