using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Item/Armes/LowRange", order = 1)]
public class ArmeLowRange : Armes
{
    [Space(32)]
    public Sprite Visuel;
    [Space(32)]
    public Vector2 DistanceIdeal = new Vector2(0, 2);
    public Vector2 DistanceAcceptable = new Vector2(0, 3);
}
