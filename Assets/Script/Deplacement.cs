using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class Deplacement : MonoBehaviour
{
    [Header("Statistique Player")]
    public Image LifeBareUI;
    public TextMeshProUGUI LifeBareUIText;
    public float Life;
    public float _Life;
    public float degatIdeal;
    public float degatAcceptable;
    public Vector2 DistanceIdeal;
    public Vector2 DistanceAcceptable;
    [Header("Déplacement Settings")]
    public Rigidbody rigidBody;
    public Vector2 MovementDirection;
    public float speed;
    [Header("Combat Settings")]
    public bool enCombat;
    public GameObject adversaire;
    public GameObject Self;
    public GameObject poinDAncrage;
    public LineRenderer ligne;
    public float TurnDirection;
    public Armes arme;
    public float distance;
    [Header("UI Settings")]
    public GameObject attackPanel;
    public GameObject MiniMap;
    public TextMeshProUGUI A;
    public TextMeshProUGUI Z;
    public TextMeshProUGUI E;
    public TextMeshProUGUI R;


    private void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        Self = this.gameObject;
        poinDAncrage = GameObject.FindGameObjectWithTag("PointEncrage");
        enCombat = false;
    }

    void Update()
    {
        stat();
        if (enCombat == true)
        {
            Turn();
            SetLignePosition();
            SetText();
            attackPanel.SetActive(true);
            MiniMap.SetActive(false);
        }
        else
        {
            Move();
            attackPanel.SetActive(false);
            MiniMap.SetActive(true);
        }
        esquive -= 1 * Time.deltaTime;
        //LifeBareUI.fillAmount = _Life / Life;
        if(GameObject.FindGameObjectWithTag("Enemy") == null)
        {
            enCombat = false;
        }
    }

    
    public void OnMove(InputValue value)
    {
        Vector2 Mouvement = value.Get<Vector2>();
        MovementDirection = new Vector2(Mouvement.x, Mouvement.y);
    }
    public void Move()
    {
        rigidBody.velocity = MovementDirection * speed;
    }
    public void OnTurn()
    {
        if(TurnDirection < 0.1)
        {
            TurnDirection = 1f;
        }
        else if(TurnDirection > 0.1)
        {
            TurnDirection = -1f;
        }
    }
    
    
    public void Turn()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(poinDAncrage.transform.position, new Vector3(0,0,TurnDirection), 20 * Time.deltaTime);
        rigidBody.velocity = MovementDirection * 0.5f;
        SetText();
    }

    public void SetPoinEncrage()
    {
        poinDAncrage.transform.position = (adversaire.transform.position + Self.transform.position)/2;
    }

    public void SetLignePosition()
    {
        ligne.SetPosition(0, Self.transform.position + new Vector3(0, 0, 1));
        ligne.SetPosition(1, adversaire.transform.position + new Vector3(0, 0, 1));
        distance = Mathf.Abs(adversaire.transform.position.x - Self.transform.position.x) + Mathf.Abs(adversaire.transform.position.y - Self.transform.position.y);

        if (distance < DistanceIdeal.y & distance > DistanceIdeal.x)
        {
            ligne.material.color = Color.green;
        }
        else if (distance < DistanceAcceptable.y & distance > DistanceAcceptable.x)
        {
            ligne.material.color = Color.yellow;
        }
        else
        {
            ligne.material.color = Color.white;
        }
    }
    public void SetText()
    {
        A.SetText(arme.A);
        Z.SetText(arme.Z);
        E.SetText(arme.E);
        R.SetText(arme.R);
    }
    public void OnAttaque()
    {
        adversaire.GetComponent<Enemy>().GetAttaked();
        Debug.Log("attaque  " + adversaire.GetComponent<Enemy>()._Life);
    }
    public void OnBlocker()
    {

    }
    float esquive;
    public void OnEsquive()
    {
        esquive = 3f;
    }
    public void OnResetPointEncrage()
    {
        SetPoinEncrage();
    }
    public void stat()
    {
        if (arme is ArmeLongRange)
        {
            ArmeLongRange o = arme as ArmeLongRange;
            degatAcceptable = o.degatAcceptable;
            DistanceAcceptable = o.DistanceAcceptable;
            degatIdeal = o.degatIdeal;
            DistanceIdeal = o.DistanceIdeal;
        }
        else if (arme is ArmeMidRange)
        {
            ArmeMidRange o = arme as ArmeMidRange;
            degatAcceptable = o.degatAcceptable;
            DistanceAcceptable = o.DistanceAcceptable;
            degatIdeal = o.degatIdeal;
            DistanceIdeal = o.DistanceIdeal;
        }
        else if (arme is ArmeLowRange)
        {
            ArmeLowRange o = arme as ArmeLowRange;
            degatAcceptable = o.degatAcceptable;
            DistanceAcceptable = o.DistanceAcceptable;
            degatIdeal = o.degatIdeal;
            DistanceIdeal = o.DistanceIdeal;
        }
        LifeBareUIText.SetText(_Life.ToString() + " / " + Life.ToString());
        LifeBareUI.fillAmount = _Life / Life;
    }
}
