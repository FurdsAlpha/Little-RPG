using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Item/Armes/LongRange", order = 1)]
public class ArmeLongRange : Armes
{
    [Space(32)]
    public Sprite Visuel;
    [Space(32)]
    public Vector2 DistanceIdeal = new Vector2(6, 8);
    public Vector2 DistanceAcceptable = new Vector2(4, 10);
}
