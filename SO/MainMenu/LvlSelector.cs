using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/MainMenu/LvlSelector")]
public class LvlSelector : ScriptableObject
{
    //[System.Serializable]
    //public struct selector
    //{
    
    public int id;
    public string title;
    public string description1;
    public string description2;
    public string description3;

    public float WidthIcon;
    public float HeightIcon;
    //}

}
