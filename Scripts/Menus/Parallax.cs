using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    //ce code vien de Dani sur youtube: https://www.youtube.com/watch?v=zit45k6CUMk
    private float Lenght, StartPos;

    public GameObject Camera;

    public float parallaxEffect;


    void Start()
    {
        //pour avoir la position de camera de depart
        StartPos = transform.position.x;

        //pour avoir la largeur du sprite pour quand on va savoir si on est a sa limite
        Lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //a chaque fois qu'on update on regarde si on a depasser la grosseur du sprite
        //si on la depase, on bouge les sprites a la position en avant de la camera
        float temp = (Camera.transform.position.x * (1 - parallaxEffect));
        float dist = (Camera.transform.position.x * parallaxEffect);

        transform.position = new Vector3(StartPos + dist, transform.position.y, transform.position.z);

        if (temp > StartPos + Lenght) StartPos += Lenght;
        else if (temp < StartPos - Lenght) StartPos -= Lenght;
    }
}
