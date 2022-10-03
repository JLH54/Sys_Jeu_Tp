using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/MainMenu/LvlSelector")]
public class LvlSelector : ScriptableObject
{
    //information des niveaux avec:
    //titre
    //3 description pour pouvoir les passer
    //Ne fait pas attention au WidthIcon et HeightIcon, dans mes premier scripts j'en avais besoin,
    //j'ai oublier de les enlever, je pense que sa efface tout si je l'enleve. Donc je les laisse la en attendant
    public string SceneName;
    public string title;
    public string description1;
    public string description2;
    public string description3;
    public float WidthIcon;
    public float HeightIcon;
}
