using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float Life = 30f;
    public float _Life = 30f;
    public Vector2 turnCD;
    public float attackCD;
    public float degat;
    public float AttackRange;
    public GameObject selfUI;
    public Image LifeBareUI;
    public bool enemyAttack;

    public void Start()
    {
        _Life = Life;
        player = GameObject.FindGameObjectWithTag("Player");
        Target();
    }
    public void Target()
    {
        player.GetComponent<Deplacement>().enCombat = true;
        player.GetComponent<Deplacement>().adversaire = this.gameObject;
        player.GetComponent<Deplacement>().SetPoinEncrage();
        player.GetComponent<Deplacement>().attackPanel.SetActive(true);
    }
    private void Update()
    {
        LifeBareUI.fillAmount = _Life / Life;
        if(_Life <= 0)
        {
            Die();
        }
    }

    public void GetAttaked()
    {
        if (player.GetComponent<Deplacement>().distance < player.GetComponent<Deplacement>().DistanceIdeal.y & player.GetComponent<Deplacement>().distance > player.GetComponent<Deplacement>().DistanceIdeal.x)
        {
            _Life -= player.GetComponent<Deplacement>().degatIdeal;
        }
        else if (player.GetComponent<Deplacement>().distance < player.GetComponent<Deplacement>().DistanceAcceptable.y & player.GetComponent<Deplacement>().distance > player.GetComponent<Deplacement>().DistanceAcceptable.x)
        {
            _Life -= player.GetComponent<Deplacement>().degatAcceptable;
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<Animator>().SetTrigger("Turn");
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
}
