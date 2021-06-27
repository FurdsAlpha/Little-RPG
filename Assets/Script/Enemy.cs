﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float Life = 1f;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    /*public void Target()
    {
        player.GetComponent<Deplacement>().adversaire = this.gameObject;
        player.GetComponent<Deplacement>().SetPoinEncrage();
    }*/
    
    public void GetAttaked()
    {
        Life -= player.GetComponent<Deplacement>().GetComponent<Armes>().degat;
    }
}
