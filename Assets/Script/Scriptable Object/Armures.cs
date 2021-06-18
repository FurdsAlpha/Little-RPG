using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Item/Armures", order = 1)]
public class Armures : ScriptableObject
{
    public string Name;
    public float Defence;
    public float Regeneration;
    public float Torns;
    [Space(32)]
    public Sprite Visuel;
}
