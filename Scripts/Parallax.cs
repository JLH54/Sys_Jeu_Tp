using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    //les choses a faire le parallax dessus
    //public Transform[] Backgrounds;

    //leurs grosseurs
    //private float[] Scales;

    //comment on veut que sa sois beau(doit etre plus haut que 0)
    //public float Smoothing = 1f;

    //besoin de la position de la camera
    //[SerializeField]
    //private Transform MyCamera;

    //private Vector3 PositionCameraPrecedente;

    //private float PositionDeDepart;

    //private float GrosseurEcran;

    // Start is called before the first frame update

    private float lenght, startpos;

    public GameObject cam;

    public float parallaxEffect;


    void Start()
    {
        //PositionCameraPrecedente = MyCamera.position;
        //PositionDeDepart = MyCamera.position.x;
        //GrosseurEcran = GetComponent<SpriteRenderer>().bounds.size.x;
        //Scales = new float[Backgrounds.Length];

        //for (int i=0; i<Backgrounds.Length; i++)
        //{
        //Scales[i] = Backgrounds[i].position.z * -1;
        //}

        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < Backgrounds.Length; i++)
        //{
        //    float parallax = (PositionCameraPrecedente.x - MyCamera.position.x) * Scales[i];

        //    float BackgroundTargetPosX = Backgrounds[i].position.x + parallax;

        //    Vector3 BackgroundTargetPos = new Vector3(BackgroundTargetPosX, Backgrounds[i].position.y, Backgrounds[i].position.z);

        //    Backgrounds[i].position = Vector3.Lerp(Backgrounds[i].position, BackgroundTargetPos, Smoothing * Time.deltaTime);
        //}

        //PositionCameraPrecedente = MyCamera.position;

        //float temp = (MyCamera.transform.position.x * (1 - Smoothing));

        //if(temp> PositionDeDepart + GrosseurEcran)
        //{
        //    PositionDeDepart += GrosseurEcran;
        //}
        //else if(temp< PositionDeDepart - GrosseurEcran)
        //{
        //    PositionDeDepart -= GrosseurEcran;
        //}

        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + lenght) startpos += lenght;
        else if (temp < startpos - lenght) startpos -= lenght;
    }
}
