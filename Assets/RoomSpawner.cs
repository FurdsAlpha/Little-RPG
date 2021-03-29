using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int OpeningDirection;
    // 1 == Down Door needed
    // 2 == Top Door needed
    // 3 == Left Door needed
    // 4 == Right Door needed

    public RoomTemplate Template;
    public GameObject[] _Template;
    private int rand;

    public void Start()
    {
        _Template = GameObject.FindGameObjectsWithTag("Rooms");
        Template.GetComponent<RoomTemplate>();
    }
    public void Update()
    {
        if (OpeningDirection == 1)
        {
            
        }
    }
}
