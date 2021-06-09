using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JaiDetecter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Je suis entré en collision");
    }
}
