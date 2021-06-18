using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Item/Armes/MidRange", order = 1)]
public class ArmeMidRange : Armes
{
    [Space(32)]
    public Sprite Visuel;
    [Space(32)]
    public Vector2 DistanceIdeal = new Vector2(2, 4);
    public Vector2 DistanceAcceptable = new Vector2(1, 5);
}
