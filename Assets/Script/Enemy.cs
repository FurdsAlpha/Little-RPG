using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float Life = 1f;
    public Vector2 turnCD;
    public float attackCD;
    public float AttackRange;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Target();
    }
    public void Target()
    {
        player.GetComponent<Deplacement>().adversaire = this.gameObject;
        player.GetComponent<Deplacement>().SetPoinEncrage();
    }
    
    public void GetAttaked()
    {
        Life -= player.GetComponent<Deplacement>().GetComponent<Armes>().degat;
    }
}
