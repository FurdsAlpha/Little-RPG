using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nouvelle Objet", menuName = "Objet")]
public class ObjetTest : ScriptableObject
{
    [Header("Basic informmation")]
    public new string name;
    [TextArea]
    public string description;

    [Header("Visuel")]
    public Sprite artwork;

    [Header("Statistic")]
    public int _degat;
    public int cooldown;
}
